using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.domain.Commands.Requests
{
    public class UserUpdateRequest
    {
        public string? Username { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
    }
}