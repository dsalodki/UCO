﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UCO.Data;
using UCO.Models;

namespace UCO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<SomeTestClass> Items = new List<SomeTestClass>();
            Items.Add(new SomeTestClass() { ID = 1, Title = "Title 1", Data1 = "Data1 1", Data2 = "Data2 1", Data3 = "Data3 1", Data4 = "Data4 1", OtherTypeValue = new SomeTestClass.OtherType() { ID = 1, Title = "Ot1" } });
            Items.Add(new SomeTestClass() { ID = 2, Title = "Title 2", Data1 = "Data1 2", Data2 = "Data2 2", Data3 = "Data3 2", Data4 = "Data4 2", OtherTypeValue = new SomeTestClass.OtherType() { ID = 2, Title = "Ot2" } });
            Items.Add(new SomeTestClass() { ID = 3, Title = "Title 3", Data1 = "Data1 3", Data2 = "Data2 3", Data3 = "Data3 3", Data4 = "Data4 3", OtherTypeValue = new SomeTestClass.OtherType() { ID = 3, Title = "Ot3" } });
            Items.Add(new SomeTestClass() { ID = 4, Title = "Title 4", Data1 = "Data1 4", Data2 = "Data2 4", Data3 = "Data3 4", Data4 = "Data4 4", OtherTypeValue = new SomeTestClass.OtherType() { ID = 4, Title = "Ot4" } });
            Items.Add(new SomeTestClass() { ID = 5, Title = "Title 5", Data1 = "Data1 5", Data2 = "Data2 5", Data3 = "Data3 5", Data4 = "Data4 5", OtherTypeValue = new SomeTestClass.OtherType() { ID = 5, Title = "Ot5" } });

            var viewModel = Items.Where(x => x.ID == 1 || x.ID == 2);

            return View(viewModel);
        }

        [HttpGet]
        public JsonResult Data()
        {
            List<SomeTestClass> Items = new List<SomeTestClass>();
            Items.Add(new SomeTestClass() { ID = 1, Title = "Title 1", Data1 = "Data1 1", Data2 = "Data2 1", Data3 = "Data3 1", Data4 = "Data4 1", OtherTypeValue = new SomeTestClass.OtherType() { ID = 1, Title = "Ot1" } });
            Items.Add(new SomeTestClass() { ID = 2, Title = "Title 2", Data1 = "Data1 2", Data2 = "Data2 2", Data3 = "Data3 2", Data4 = "Data4 2", OtherTypeValue = new SomeTestClass.OtherType() { ID = 2, Title = "Ot2" } });
            Items.Add(new SomeTestClass() { ID = 3, Title = "Title 3", Data1 = "Data1 3", Data2 = "Data2 3", Data3 = "Data3 3", Data4 = "Data4 3", OtherTypeValue = new SomeTestClass.OtherType() { ID = 3, Title = "Ot3" } });
            Items.Add(new SomeTestClass() { ID = 4, Title = "Title 4", Data1 = "Data1 4", Data2 = "Data2 4", Data3 = "Data3 4", Data4 = "Data4 4", OtherTypeValue = new SomeTestClass.OtherType() { ID = 4, Title = "Ot4" } });
            Items.Add(new SomeTestClass() { ID = 5, Title = "Title 5", Data1 = "Data1 5", Data2 = "Data2 5", Data3 = "Data3 5", Data4 = "Data4 5", OtherTypeValue = new SomeTestClass.OtherType() { ID = 5, Title = "Ot5" } });

            var viewModel = Items.Where(x => x.ID == 4 || x.ID == 5);

            return Json(viewModel);
        }
    }
}
