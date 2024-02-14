﻿using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {

        public string Index()
        {
            return "This is the Index page!";
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}
