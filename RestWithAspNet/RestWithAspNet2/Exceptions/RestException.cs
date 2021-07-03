using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspNet2.Exceptions
{
    public class RestException : Exception
    {
        public RestException(string mensagem): base(mensagem)
        {

        }

        public string LocalCallMethod { get; set; } = string.Empty;
    }
}
