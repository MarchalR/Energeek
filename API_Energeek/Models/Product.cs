using System;
namespace API_Energeek.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Kwh_yr { get; set; }
        public bool Generating { get; set; }
    }
}
