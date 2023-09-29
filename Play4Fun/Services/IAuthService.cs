using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play4Fun.Services
{
    public interface IAuthService
    {
        public bool CheckCredential(string username, string password);
    }
}