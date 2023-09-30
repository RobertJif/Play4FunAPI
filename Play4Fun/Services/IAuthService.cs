using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Play4Fun.Repository.Entities;
using Play4Fun.Services.Dtos;

namespace Play4Fun.Services
{
    public interface IAuthService
    {
        public PlayerDto? IsCredentialOk(string username, string password);
        public void Create(CreatePlayerDto player);
    }
}