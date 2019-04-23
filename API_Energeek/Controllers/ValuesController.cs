using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Energeek.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_Energeek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly MyDbContext _context;

        public ValuesController(MyDbContext context){
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public Microsoft.EntityFrameworkCore.DbSet<Product> Get()
        {
            var products = _context.Products;
            /*var products = JsonConvert.SerializeObject(_context.Products);
            return products;*/

            //return new string[] { "value1", "value2" };

            return products;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            /*bool productExists = _context.Products.Any(product => product.Id.Equals(id));
            if (productExists == true)
                return Ok(new Product() { Id = 1, Name = "Laptop", Kwh_yr = 22, Generating = false });
            return NotFound();*/
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            return product != null ? Ok(product) : (ActionResult)NotFound();
        }

        /*[HttpGet("{id}")]
        public Product Get(int id)
        {
            if (id == 1)
            return new Product() {Id = 1, Name = "Laptop", Kwh_yr = 22, Generating = false};
        }*/

        // POST api/values
        /*[HttpPost]
        public void Post([FromBody] string value)
        {
        }*/

        [HttpPost]
        public void Post([FromBody] Product value)
        {
            _context.Products.Add(value); //AJOUTER METHODE VERIF DE LA VALUE ET CODE D'ERREUR
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
