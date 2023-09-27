using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Play4Fun.Repository.Entities;

namespace Play4Fun.Repository
{
    public interface IGameRepository
    {
        public List<Game> GetAll();
    }
}