using System;
using System.Collections.Generic;
using API_Energeek.Models;

namespace API_Energeek.Models.Repository
{
    public interface IUserProductRepository : IDisposable
    {
        UsersProduct GetUserProductById(int value);
        UsersProduct AddUserProduct(User user, Product product, int quantity);
    }
}
