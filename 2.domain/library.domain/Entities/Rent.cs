using System;
using library.domain.Exceptions;

namespace library.domain.Entities
{
    public class Rent
    {
        public int UserId { get; private set; }
        public int BookId { get; private set; }
        public DateTime CheckoutDate { get; private set; }
        public DateTime ReturnDate { get; private set; }

        public Rent(int userId, int bookId)
        {
            if (userId <= 0)
                throw new RequestInvalidException("Usuário inválido");

            if (bookId <= 0)
                throw new RequestInvalidException("Livro inválido");

            CheckoutDate = DateTime.Now;
            ReturnDate = CheckoutDate.AddDays(3);
        }

        public void AddDaysToReturnDate(int days)
        {
            ReturnDate.AddDays(days);
        }
    }
}