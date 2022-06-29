using System;
using library.domain.Exceptions;

namespace library.domain.Entities
{
    public class Book : Base
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Isbn { get; private set; }
        public DateTime PublishedDate { get; private set; }

        public Book(string title, string author, int isbn)
        {
            if (string.IsNullOrEmpty(title) && title.Length < 3 || title.Length > 100)
                throw new RequestInvalidException("Título deve ter entre 3 e 100 caracteres");

            if (string.IsNullOrEmpty(author) && author.Length < 3 || author.Length > 100)
                throw new RequestInvalidException("Autor deve ter entre 3 e 100 caracteres");

            Title = title;
            Author = author;
            Isbn = isbn;
            PublishedDate = DateTime.Now;
        }
    }
}