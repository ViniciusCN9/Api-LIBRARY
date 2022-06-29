using System;
using library.domain.Exceptions;

namespace library.domain.Entities
{
    public class Review : Base
    {
        public int UserId { get; private set; }
        public int BookId { get; private set; }
        public string Content { get; private set; }
        public DateTime PublishedDate { get; private set; }

        public Review(int userId, int bookId, string content)
        {
            if (userId <= 0)
                throw new RequestInvalidException("Usuário inválido");

            if (bookId <= 0)
                throw new RequestInvalidException("Livro inválido");

            if (string.IsNullOrEmpty(content) && content.Length < 3 || content.Length > 255)
                throw new RequestInvalidException("Conteúdo deve ter entre 3 e 100 caracteres");

            UserId = userId;
            BookId = bookId;
            Content = content;
            PublishedDate = DateTime.Now;
        }
    }
}