﻿using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class HomeController : Controller
    {

        private IRestaurantData restaurantData;


        public HomeController(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }



        public ActionResult Index()
        {

            var model = restaurantData.GetAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}