using System;
using System.Collections.Generic;
using System.Text;

namespace homewooorrrkkk.Models
{
    class Product
    {
        public string name;
        public double Price;
        public int totalcount;
        private double _discountedprice;
        static int code = 1000;
        public string no;
        public string Type;

        public Product(string product,double price)
        {
            Type = product;
            Price = price;
            no = $"{Type[0]} {code}";
            code++;
            totalcount++;
        }
        public double Discountedprice
        {
            get => _discountedprice;
            set
            {
                string[]array=Enum.GetNames(typeof(Productypes));
                foreach (string item in array)
                {
                    if (Type == item)
                    {
                        _discountedprice = Price - (Price * 10 / 100);
                    }
                }
            }       
        }
    }
}
