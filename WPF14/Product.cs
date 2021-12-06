using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF14
{
    public enum ECategory
    {
        FOOD,
        ELECTRONIC
    }
    public class Product
    {



        public string Name { get; set; }
        public int Price { get; set; }
        public string Pic { get; set; }
        public ECategory Category { get; set; }

        public Product(string name, int price, string pic, ECategory category)
        {
            Name = name;
            Price = price;
            Pic = pic;
            Category = category;
        }
    }
}
