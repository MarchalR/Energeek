using System;
namespace API_Energeek.Models
{
    public class UsersProduct
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
        public int Quantity { get; set; }
    }
}
