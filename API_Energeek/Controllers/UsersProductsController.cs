using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using API_Energeek.Models;
using API_Energeek.Models.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Energeek.Controllers
{
    [Route("api/[controller]")]
    public class UsersProductsController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUserProductRepository _userproductRepository;

        public UsersProductsController (IUserRepository userRepository, IProductRepository productRepository, IUserProductRepository userProductRepository)
        {
            _userRepository = userRepository;
            _productRepository = productRepository;
            _userproductRepository = userProductRepository;
        }


        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public UsersProduct Post([FromBody]JObject value)
        {
            int customer = (int)value.GetValue("idUser");
            int idProduct = (int)value.GetValue("idProduct");
            int quantity = (int)value.GetValue("quantity");
            User user = _userRepository.GetUserById(customer);
            Product product = _productRepository.GetProductById(idProduct);
            UsersProduct usersProduct =  _userproductRepository.AddUserProduct(user, product, quantity);
            return usersProduct;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
