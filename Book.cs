using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Book : Product
    {
        private string _authorName { get; set; }
        public string AuthorName
        {
            get
            {
                return _authorName;
            }
            set
            {
                if (value == "" || value == " ")
                {
                    Console.WriteLine("Please enter the price");
                }
                else
                {
                    _authorName = value;
                }
            }
        }
        private int _pageCount { get; set; }
        public int PageCount
        {
            get
            {
                return _pageCount;
            }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Please enter the price");
                }
                else
                {
                    _pageCount = value;
                }
            }
        }
        public override void Sell()
        {
            if (Count>0)
            {
                Count--;
                TotalIncome += Price;
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{AuthorName} {PageCount}");
        }
        public Book():base()
        {

        }
    }
}
