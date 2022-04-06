using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
   abstract class Product
    {
        public static int Id { get; set; }
        private int _id { get; }
        private string _name { get; set; }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "" || value==" ")
                {
                    Console.WriteLine("Please enter the price");
                }
                else
                {
                    _name = value;
                }
            }
        }
        private double _price { get; set; }
        public double Price 
        {
            get
            {
                return _price;
            }
            set 
            {
                if (value == 0)
                {
                    Console.WriteLine("Please enter the price");
                }
                else
                {
                    _price = value;
                }
            }
        }
        public int Count { get; set; }
        protected double TotalIncome { get; set;  }
        public Product()
        {
            _id++;
            Id = _id;
        }
        public abstract void Sell();
        public abstract void ShowInfo();

    }
}
