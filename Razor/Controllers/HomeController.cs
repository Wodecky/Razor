﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Product myProduct = new Product
        {
            ProductId = 1,
            Name = "Kajak",
            Description = "Jednoosobowa łódka",
            Category = "Spory wodne",
            Price = 275M
        };

        public ActionResult Index()
        {
            return View(myProduct);
        }
    }
}