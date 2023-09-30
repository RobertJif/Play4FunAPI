using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play4Fun.Exceptions
{
    public class AuthException
    {
        public Exception DuplicateUsername = new Exception("Username already exist");
    }
}