using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            book1.Name="lord of the rings";
            book1.PageCount=700;
            book1.Price=50;
            book1.AuthorName="idk";

            book2.Name="game of thrones";
            book2.PageCount = 400;
            book2.Price = 20;
            book2.AuthorName = "idk";

            book3.Name="harry potter";
            book3.PageCount = 700;
            book3.Price = 50;
            book3.AuthorName = "idk";
        }
    }
}
