using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Play4Fun.Repository;

namespace Play4Fun.Services.Impl
{
    public class AuthService : IAuthService
    {
        ApiDbContext db;
        IConfiguration configuration;
        public AuthService(ApiDbContext db, IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }
        public bool CheckCredential(string username, string password)
        {

            return true;
        }
    }
}