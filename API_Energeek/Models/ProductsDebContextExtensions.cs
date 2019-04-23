using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Internal;

namespace API_Energeek.Models
{
    public static class ProductsDebContextExtensions
    {
        public static void CreateSeedData
               (this MyDbContext context)
        {
            if (context.Products.Any())
                return;
            var products = new List<Product>()
               {
                new Product()
                    {
                         Name = "Panneau solaire",
                         Kwh_yr = 110,
                         Generating = true

                    },
                    new Product()
                    {
                         Name = "Eclairage",
                         Kwh_yr = 22,
                         Generating = false
                    },
                    new Product()
                    {
                         Name = "Frigidaire",
                         Kwh_yr = 200,
                         Generating = false
                    }
               };
            context.AddRange(products);
            context.SaveChanges();
        }
    }
}
