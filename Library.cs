using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Library
    {
        private int _booklimit { get; set; }
        public int BookLimit
        {
            get
            {
                    return _booklimit;
            }
            set
            {
                if (value > 0)
                {
                    _booklimit = value;
                }
            }
        }
        public Book[] Books;
       
        public void AddBook( Book book)
        {
            if (Books.Length <= BookLimit)
            {
                Array.Resize(ref Books, Books.Length + 1); 
                Books[^1] = book;
            }
            else
            {
                throw new Exception();
            }
        }
        public void GetBookById(int? id)
        {
            foreach (Book item in Books)
            {
                if (Book.Id==(int)id)
                {
                    Console.WriteLine($"Name: {item.Name} Price: {item.Price} Author Name: {item.AuthorName} Page count: {item.PageCount}");
                }
            }
        }
    }
}
