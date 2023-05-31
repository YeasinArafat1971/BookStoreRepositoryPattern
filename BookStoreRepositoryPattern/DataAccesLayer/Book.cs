using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreRepositoryPattern.DataAccesLayer
{
    public class Book
    {
        public int BookID;
        public string BookName;
        public string Author;
        public double Price;
        public string PublishedDate;

        public Book()
        {
            
        }
        public Book(int bookid, string bookname, string author, double price, string publisheddate)

        {
            BookID = bookid;
            BookName = bookname;
            Author = author;
            Price = price;
            PublishedDate = publisheddate;

        }
    }
}
