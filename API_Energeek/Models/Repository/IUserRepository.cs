using System;
using System.Collections.Generic;
using API_Energeek.Models;

namespace API_Energeek.Models.Repository
{
    public interface IUserRepository : IDisposable
    {

        User GetUserByLogin(User user);
        String AddNewUser(User value);
        User GetUserById(int value);

    }
}
