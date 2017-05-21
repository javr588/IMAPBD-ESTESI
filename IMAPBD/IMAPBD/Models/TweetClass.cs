using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using System.IO.Compression;
using System.Text.RegularExpressions;
using Tweetinvi;
using Google;
using System.Net.Http;
using Google.Cloud.Datastore.V1;
using Google.Protobuf;

namespace IMAPBD.Models
{
    public class TweetClass
    {
        string projectID = "imapbd-load";
        public void GetTweet()
        {
               QueryCountry();

            Auth.SetUserCredentials("SbeN3F01n4VfL38DyMgFJtCaU", "ZWh95vzbBIBoLc0oUP4HeOSAAJ76i9vYd9rcKsYruVesPkcV9h", "855199954087944193-siJw0Huqbl64Kcyyq3tPxBm75eeS4E7", "oenJfXW32nD2llokrS0ZO3eMND6nB7k36WxRs7VeJK3P6");
            var userTweet = User.GetAuthenticatedUser();
            var hashTags = new List<string> { "#vacaciones", "#viaje", "#playas", "#campo", "#diversion", "#travel", "#summer", "#verano", "#invierno", "#primavera" };
            IList<Tweetinvi.Models.ITweet> tweetTemp = new List<Tweetinvi.Models.ITweet>();
            IList<object> tweets = new List<object>();
            foreach (string hash in hashTags)
            {
                var searchParam = Search.SearchQueryParameterGenerator.CreateSearchTweetParameter(hash);// multi "#viaje #playas" campo diversion travel summer verano invierno primavera
                searchParam.MaximumNumberOfResults = 15;

                searchParam.Until = DateTime.Now;
                searchParam.Since = DateTime.Now.Date.AddDays(-1);

                searchParam.FilterTweetsNotContainingGeoInformation = true;

                var getHash = Search.SearchTweets(searchParam);
                //  IList<object> tweets = new List<object>();
                if (getHash != null)
                {
                    foreach (var tweet in getHash)
                    {
                        string tweetPolut = Regex.Replace(tweet.FullText, @"http[^\s]+", "").Replace(",", string.Empty).Replace("\\", string.Empty);
                        tweetPolut = Regex.Replace(tweetPolut, @"[^\u0000-\u007F]+", string.Empty);

                        tweets.Add(System.Text.RegularExpressions.Regex.Replace(tweetPolut, @"\s+", " "));
                        tweetTemp.Add(tweet);
                    }
                }

            }
            var tweetCreated = tweetTemp.ToArray();


            Google.Apis.Auth.OAuth2.UserCredential credential;

            using (var stream = new FileStream(HttpContext.Current.Server.MapPath(@"~\OAuth\imapbd_pred_cred.json"), FileMode.Open, FileAccess.Read))
            {

                credential = Google.Apis.Auth.OAuth2.GoogleWebAuthorizationBroker.AuthorizeAsync(
                    Google.Apis.Auth.OAuth2.GoogleClientSecrets.Load(stream).Secrets, new[] { Google.Apis.Prediction.v1_6.PredictionService.Scope.Prediction },
                    "935711578483-hidc4rdc27k9641mvhc4v5leqoj1eqh2.apps.googleusercontent.com",
                    CancellationToken.None,
                    new Google.Apis.Util.Store.FileDataStore("tpwen")
                    ).Result;

            }

            var trainedModel = new Google.Apis.Prediction.v1_6.PredictionService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApiKey = "AIzaSyDNbIphNLJl0Q9Et8-UYc-JIrg1I2lStnI",
                ApplicationName = "imapbd-load"
            });

            int tweetCount = 0;
            foreach (string sing_tweet in tweets)
            {

                IList<object> sent_tweet = new List<object>();
                sent_tweet.Add(sing_tweet);

                var tweetSent = new Google.Apis.Prediction.v1_6.Data.Input();
                var body = new Google.Apis.Prediction.v1_6.Data.Input.InputData();
                body.CsvInstance = sent_tweet;
                tweetSent.InputValue = body;

                var sentiment = new Google.Apis.Prediction.v1_6.TrainedmodelsResource.PredictRequest(trainedModel, tweetSent, "imapbd-load", "sentimiento");

                //var sent = sentiment.Predict(tweetSent,"tpwen-150404","sentimiento").ExecuteAsync();
                var snt = sentiment.Execute();
                List<string> sentScore = new List<string>();
                string sentTag = "";
                foreach (var tag in snt.OutputMulti)
                {
                    sentScore.Add(tag.Score);
                    sentTag += tag.Label + ",";
                }
                //sent_tweet.Add(sentScore);

                DateTime tweetDate = tweetCreated[tweetCount].CreatedAt.Date;
                var tweetPlace = tweetCreated[tweetCount].Place;
                #region file write
                /*
                string path = @"C:\Users\Javier\Downloads\IMAPBD-Misc\Sentiment analisis\sent_place.csv";
                if (!File.Exists(path))
                {
                    using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (string sent in sent_tweet)
                        {
                            sw.WriteLine("Tweet," + sentTag + "Dia,Mes,Año,Lugar,Pais");

                        }
                    }

                }
                if (File.Exists(path))
                {    using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                         // sw.WriteLine(sent + "," + sentScore + tweetDate.DayOfWeek + "," + tweetDate.Month + "," + tweetDate.Year + "," + tweetPlace.Name + "," + tweetPlace.Country);
                            //access
                    }  }
*/
                #endregion

                foreach (string sent in sent_tweet)
                {

                    InsertBD(sent, sentScore.ToArray(), tweetDate, tweetPlace);

                }

                tweetCount++;
            }
         

        }

        public void InsertBD(string InsertTweet, string[] tweetScore, DateTime fecha, Tweetinvi.Models.IPlace lugar)
        {
            #region db access
            ///////////////////////////////////////////// db access ///////////////////////////////////
            string credential_path = HttpContext.Current.Server.MapPath(@"~\OAuth\IMAPBD - Load-db-access.json");
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);

          

            DatastoreDb db = DatastoreDb.Create(projectID, "");
            string kind = "Lugar_Tweet";

            KeyFactory keyFactory = db.CreateKeyFactory(kind);
            Key key = keyFactory.CreateIncompleteKey();

            Entity task = new Entity();
            task.Key = key;
            task.Properties.Add("tweet", InsertTweet);

            task.Properties.Add("tedioso", Convert.ToDouble(tweetScore[0]));
            task.Properties.Add("malo", Convert.ToDouble(tweetScore[1]));
            task.Properties.Add("bueno", Convert.ToDouble(tweetScore[2]));
            task.Properties.Add("regular", Convert.ToDouble(tweetScore[3]));

            task.Properties.Add("dia", fecha.DayOfWeek.ToString());
            task.Properties.Add("mes", fecha.Month);
            task.Properties.Add("anio", fecha.Year);
            
            if(lugar == null){
                task.Properties.Add("lugar", "");
                task.Properties.Add("pais", "");
            }else
            {
                task.Properties.Add("pais", lugar.Country);
                task.Properties.Add("lugar", lugar.Name);
            }            
            
            
            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                transaction.Upsert(task); 
                transaction.Commit();
            }
            ///////////////////////////////////////////// db access ///////////////////////////////////
            #endregion
        }

        public void InsertPaquete(string destino, string origen, DateTime fecha_llegada, DateTime fecha_salida, DateTime fecha_venc, string info_gen, string moneda, double costo, string empresa,List<string> actividades)
        {
            #region db access
            ///////////////////////////////////////////// db access ///////////////////////////////////
            string credential_path = HttpContext.Current.Server.MapPath(@"~\OAuth\IMAPBD - Load-db-access.json");
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);

            string projectID = "imapbd-load";

            DatastoreDb db = DatastoreDb.Create(projectID, "");
            string kind = "paqueteList";

            KeyFactory keyFactory = db.CreateKeyFactory(kind);
            Key key = keyFactory.CreateIncompleteKey();

            Entity task = new Entity();
            task.Key = key;
          
            //paquete
            task.Properties.Add("destino","Trujillo");
            task.Properties.Add("fecha_llegada",DateTime.Now);
            task.Properties.Add("fecha_salida",DateTime.Now);
            task.Properties.Add("fecha_venc",DateTime.Now);
            task.Properties.Add("info_general","info genral del paquete");
            task.Properties.Add("moneda","GBP");
            task.Properties.Add("costo", Convert.ToDouble(15.5));
            task.Properties.Add("empresa","viaje");
            task.Properties.Add("origen","Lima");

            foreach(string act in actividades)
            {
                task.Properties.Add("Tipo"+i.ToString(), "tipo"+i.ToString());
                task.Properties.Add("OrigenAct"+i.ToString(),"orien"+i.ToString() );
                task.Properties.Add("DestinoAct"+i.ToString(), "destino"+i.ToString());
                task.Properties.Add("FechaSal"+i.ToString(), "fecsal"+i.ToString());
                task.Properties.Add("FechaLleg"+i.ToString(), "fecll"+i.ToString());
                task.Properties.Add("costo" + i.ToString(), i);
                task.Properties.Add("moneda" + i.ToString(), "moneda"+i.ToString());
            
            }

                using (DatastoreTransaction transaction = db.BeginTransaction())
                {
                    transaction.Upsert(task);
                    transaction.Commit();
                }
            ///////////////////////////////////////////// db access ///////////////////////////////////
            #endregion
        }

        public void QueryCountry() {
            string credential_path = HttpContext.Current.Server.MapPath(@"~\OAuth\IMAPBD - Load-db-access.json");
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);

            DatastoreDb db = DatastoreDb.Create(projectID, "");
            Query query = new Query("Lugar_Tweet")//paqueteList
            {
                Filter = Filter.Equal("pais", "Mexico"),
              //  DistinctOn = {"lugar" },
                //Order = { { "bueno", PropertyOrder.Types.Direction.Descending } }
            };
          
          
          DatastoreQueryResults tasks = db.RunQuery(query);
           /* List<object> lugarQuery = new List<object>();
            foreach (Entity entity in db.RunQueryLazily(query))
            {
                string title = (string)entity["title"];
                DateTime published = (DateTime)entity["published"];
                Console.WriteLine("{0} was published in {1}",title, published);

              
                task.Properties.Add("bueno", Convert.ToDouble(tweetScore[2]));
            

                task.Properties.Add("dia", fecha.DayOfWeek.ToString());
                task.Properties.Add("mes", fecha.Month);
                task.Properties.Add("anio", fecha.Year);

               
                    task.Properties.Add("pais", lugar.Country);
                    task.Properties.Add("lugar", lugar.Name);
                       
            

            }*/
        }
    }
}