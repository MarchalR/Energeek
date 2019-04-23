using System;
using System.Collections.Generic;
using System.Linq;
using API_Energeek.Models;

namespace API_Energeek.Models.Repository
{
    public class UserProductRepository : IUserProductRepository
    {
        private readonly MyDbContext _context;
        private bool _disposed;


        public UserProductRepository(MyDbContext context)
        {
            _context = context;
        }

        public UsersProduct GetUserProductById(int user_product)
        {
            UsersProduct res = _context.UsersProducts.Where(p => p.Id == user_product).FirstOrDefault();
            return res;
        }

        public UsersProduct AddUserProduct(User user, Product product, int quantity){
            UsersProduct usersProduct = new UsersProduct
            {
                User = user,
                Product = product,
                Quantity = quantity
            };
            _context.UsersProducts.Add(usersProduct);
            _context.SaveChanges();
            return usersProduct;
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
