using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreRepositoryPattern.DataAccesLayer
{
    internal class BookRepository : IBookRepository
    {
        List<Book> listBook = new List<Book>()
        {
            new Book(1, "Programming", "Suja Uddola", 120, "12/02/2022"),
            new Book(2, "Hack the World", "White Hack Hacker", 3000, "14/02/2023"),
            new Book(3, "Never Give Up", "Arafa", 2000, "14/02/2023"),
            new Book(4, "Java full Reference", "Shaymol", 5000, "15/02/2023"),
            new Book(5, "Object Oriented Programming", "John Sharp", 15000, "17/02/2022")
        }; 
        public List<Book> Get()
        {
            return listBook.OrderBy(x=>x.BookName).ToList();
        }
        public Book Get(int id)
        {
            Book oBook = listBook.Where(x=>x.BookID==id).FirstOrDefault();
            return oBook;
        }
        public bool Add(Book model)
        {
            listBook.Add(model);
            return true;
        }
        public bool Update(Book model)
        {
            bool isExecuted = false;
            Book oBook = listBook.Where(x=>x.BookID==model.BookID).FirstOrDefault();
            if(oBook!=null)
            {
                listBook.Remove(oBook);
                listBook.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }
        public bool Delete(int id)
        {
            bool isExecuted = false;
            Book oBook = listBook.Where(x => x.BookID == id).FirstOrDefault();
            if(oBook!=null)
            {
                listBook.Remove(oBook);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
