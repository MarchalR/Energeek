using System;
using System.Collections.Generic;
using System.Linq;
using API_Energeek.Models;

namespace API_Energeek.Models.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyDbContext _context;
        private bool _disposed;


        public ProductRepository(MyDbContext context)
        {
            _context = context;
        }

        public Product GetProductById(int product)
        {
            Product res = _context.Products.Where(p => p.Id == product).FirstOrDefault();
            return res;
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
