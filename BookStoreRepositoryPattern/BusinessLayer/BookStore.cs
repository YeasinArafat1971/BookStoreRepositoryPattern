using BookStoreRepositoryPattern.DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreRepositoryPattern.BusinessLayer
{
    public class BookStore
    {
        IBookRepository _repository;
        
        public BookStore(IBookRepository repository)
        {
            _repository = repository;
        }
        public List<Book> Get()
        {
            return _repository.Get();
        }
        public Book Get(int BookID)
        {
            return _repository.Get(BookID);
        }
        public bool Add(Book model)
        {
            return _repository.Add(model);
        }

        public bool Update(Book model)
        {
            return _repository.Update(model);
        }
        public bool Delete (int BookID)
        {
            return _repository.Delete(BookID);  
        }
    }
    
}
