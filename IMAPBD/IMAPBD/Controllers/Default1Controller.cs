﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMAPBD.Models;

namespace IMAPBD.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            TweetClass obj = new TweetClass();
            obj.GetTweet();
            return View();
        }

    }
}
