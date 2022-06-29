using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.domain.Repositories
{
    public interface RentRepository
    {
        List<Rent> GetUsersBooksByUser(int userId);
        List<Rent> GetUsersBooksByBook(int bookId);
        Rent GetRent(int userId, int bookId);
        void CreateRent(Rent rent);
        void UpdateRent(int userId, int bookId, Rent rent);
        void DeleteRent(int userId, int bookId);
    }
}