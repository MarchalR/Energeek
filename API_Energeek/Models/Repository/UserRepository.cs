using System;
using System.Collections.Generic;
using System.Linq;
using API_Energeek.Models;
namespace API_Energeek.Models.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MyDbContext _context;
        private bool _disposed;


        public UserRepository(MyDbContext context)
        {
            _context = context;
        }

        public User GetUserByLogin(User user)
        {
            User res = _context.Users.Where(u => u.UserName == user.UserName && u.Password == user.Password && u.Email == user.Email).FirstOrDefault();
            return res;
        }

        public User GetUserById(int user)
        {
            User res = _context.Users.Where(u => u.Id == user ).FirstOrDefault();
            return res;
        }

        string IUserRepository.AddNewUser(User user)
        {
            if (this.GetUserByLogin(user) != null)
            {
                return "user exist";
            }
            else
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return "ok";
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
