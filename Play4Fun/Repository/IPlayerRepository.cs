using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Play4Fun.Repository.Entities;

namespace Play4Fun.Repository
{
    public interface IPlayerRepository
    {
        public Player GetActive(string username, string password);

        public int Create(string username, string password, byte[] salt);
    }
}