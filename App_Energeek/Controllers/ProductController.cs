using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Energeek.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App_Energeek.Controllers
{
    public class ProductController : Controller
    {
        private ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }
        public IActionResult Stats()
        {
            string message = string.Empty;
            message = JsonConvert.SerializeObject(_service.GetStats());
            ViewBag.Message = message;
            Console.WriteLine("hello");
            return View(_service.GetStats());
        }

    }
}
