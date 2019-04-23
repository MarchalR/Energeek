using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Internal;

namespace API_Energeek.Models
{
    public static class UsersDebContextExtensions
    {
        public static void CreateUserData
               (this MyDbContext context)
        {
            if (context.Users.Any())
                return;
            var Users = new List<User>()
               {
                new User()
                    {
                         UserName = "ttison",
                         FirstName = "theo",
                         LastName = "tison",
                         Email = "tison_t@etna-alternance.net",
                         Password = "Etna"


                    },
                    new User()
                    {
                         UserName = "rmarchal",
                         FirstName = "remi",
                         LastName = "marchal",
                         Email = "marcha_r@etna-alternance.net",
                         Password = "Etna"
                    }
               };
            context.AddRange(Users);
            context.SaveChanges();
        }
    }
}
