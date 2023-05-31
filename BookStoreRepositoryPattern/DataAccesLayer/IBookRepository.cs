using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreRepositoryPattern.DataAccesLayer
{
    public  interface IBookRepository
    {
        List<Book> Get();
        Book Get(int BookID);
        bool Add(Book model);
        bool Update(Book model);
        bool Delete(int BookID);
    }
}
