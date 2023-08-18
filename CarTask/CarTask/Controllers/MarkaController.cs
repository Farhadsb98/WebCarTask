﻿using CarTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeTaskMVC2.Controllers
{
    public class MarkaController : Controller
    {
        private List<Marka>_markas;

        public MarkaController()
        {
            _markas = new()
            {
               new() {Id=1,MarkaName="Toyota"},
               new() {Id=2,MarkaName="Dodge"},
               new() {Id=3,MarkaName="Dodge"},
               new() {Id=4,MarkaName="Ford"}
            };
        }
        public IActionResult Index()
        {
            return View(_markas);
        }
    }
}
