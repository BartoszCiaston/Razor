﻿using Microsoft.AspNetCore.Mvc;
using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product myProduct = new Product
            {
                ProductID = 1,
                Name = "Kajak",
                Description = "Jednoosobowa łódka",
                Category = "Sporty wodne",
                Price = 275M
            };
            return View(myProduct);
        }
    }
}
