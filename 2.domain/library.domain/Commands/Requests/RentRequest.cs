using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.domain.Commands.Requests
{
    public class RentRequest
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}