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
    }
}