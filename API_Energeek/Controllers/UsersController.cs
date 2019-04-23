using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Energeek.Models;
using API_Energeek.Models.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Energeek.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly MyDbContext _context;
        private readonly IUserRepository _userRepository;

        public UsersController(MyDbContext context, IUserRepository userRepository) {
            _context = context;
            _userRepository = userRepository;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var user = _context.Users.FirstOrDefault(p => p.Id == id);
            return user != null ? Ok(user) : (ActionResult)NotFound();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]User value)
        {
            _context.Users.Add(value); //AJOUTER METHODE VERIF DE LA VALUE ET CODE D'ERREUR
            _context.SaveChanges();
        }

        // POST api/users/login
        [HttpPost("login")]
        public User Login([FromBody]User value)
        {
            return _userRepository.GetUserByLogin(value);
        }

        // POST api/users/add
        [HttpPost("add")]
        public string AddUser([FromBody]User value)
        {
            return _userRepository.AddNewUser(value);
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
