using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.domain.Commands.Requests
{
    public class ReviewCreateRequest
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public string Content { get; set; }
    }
}