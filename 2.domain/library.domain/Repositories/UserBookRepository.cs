using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.domain.Repositories
{
    public interface UserBookRepository
    {
        List<UserBook> GetUsersBooksByUser(int userId);
        List<UserBook> GetUsersBooksByBook(int bookId);
        UserBook GetUserBook(int userId, int bookId);
        void CreateUserBook(UserBook userBook);
        void UpdateUserBook(int userId, int bookId, UserBook userBook);
        void DeleteUserBook(int userId, int bookId);
    }
}