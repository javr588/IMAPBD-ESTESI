using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using IMAPBD.Models;


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
            TweetClass tweet = new TweetClass();
            tweet.GetTweet();

           /* TweetList.DataSource = tweets;
            TweetList.DataBind();*/
            return View();
        }

    }

    
}
