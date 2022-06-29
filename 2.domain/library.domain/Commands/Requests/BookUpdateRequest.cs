using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.domain.Commands.Requests
{
    public class BookUpdateRequest
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int? Isbn { get; set; }
    }
}