using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.domain.Repositories
{
    public interface BookRepository
    {
        List<Book> GetBooks();
        Book GetBook(int id);
        void CreateBook(Book book);
        void UpdateBook(int id, Book book);
        void DeleteBook(int id);
    }
}