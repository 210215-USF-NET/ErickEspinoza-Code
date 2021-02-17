using System;

namespace Personal_Shop
{
    public class Product
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public float Price { get; set; }

        public Product()
        {
            this.Name = "NULL";
            this.Description = "NO DESCRIPTION";
            this.Price = 0.00f;
        }

        public Product(String name, String description, float price)
        {
            Name = name;
            Description = description;
            Price = price;

        }
    }
}
