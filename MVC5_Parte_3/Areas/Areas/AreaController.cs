﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas
{
    public class AreaController : Controller
    {
        // GET: Area
        public ActionResult Index()
        {
            return View();
        }
    }
}