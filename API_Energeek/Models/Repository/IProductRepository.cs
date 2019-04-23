using System;
using System.Collections.Generic;
using API_Energeek.Models;

namespace API_Energeek.Models.Repository
{
    public interface IProductRepository : IDisposable
    {
        Product GetProductById(int value);
    }
}
