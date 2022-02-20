using ConsoleApp;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CurrencyController : Controller
    {
        public IActionResult Get()
        {
            List<ValueViewModel> valutes = ValueViewModel.GetAll();
            return View(valutes);
        }

    }
}
