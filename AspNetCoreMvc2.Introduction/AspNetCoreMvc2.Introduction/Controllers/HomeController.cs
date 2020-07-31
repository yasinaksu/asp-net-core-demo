﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc2.Introduction.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from first application.";
        }
        public ViewResult Index2()
        {
            return View();
        }
    }
}
