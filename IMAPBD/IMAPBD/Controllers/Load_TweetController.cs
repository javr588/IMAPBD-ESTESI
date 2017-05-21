using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMAPBD.Controllers
{
    public class Load_TweetController : Controller
    {
        //
        // GET: /Load_Tweet/

        public ActionResult Index()
        {
                   return View();
        }

        public ActionResult Load()
        {
            IMAPBD.Controllers.TweetClass tweet = new IMAPBD.Controllers.TweetClass();
            List<object> tweets = tweet.GetTweet();

           /* TweetList.DataSource = tweets;
            TweetList.DataBind();*/
            return View();
        }

    }

    
}
