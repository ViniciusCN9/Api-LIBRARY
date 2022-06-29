using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.domain.Commands
{
    public class Response
    {
        public string Response { get; private set; }

        public Response(string response)
        {
            Response = $"{response} com sucesso!";
        }
    }
}