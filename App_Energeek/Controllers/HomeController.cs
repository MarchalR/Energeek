using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App_Energeek.Models;
using Newtonsoft.Json;

namespace App_Energeek.Controllers
{
    public class HomeController : Controller
    {
        private ProductService _service;

        public HomeController(ProductService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            string message = string.Empty;
            message = JsonConvert.SerializeObject(_service.GetAll());
            ViewBag.Message = message;
            return View(_service.GetAll());
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            _service.AddProduct(product);
            return View(_service.GetAll());
        }


        public IActionResult Login()
        {
            System.Diagnostics.Debug.WriteLine(" Dans HomeController/Login/ ");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Product()
        {

            return View(_service.Get(1));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
