using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Play4Fun.Repository.Entities;

namespace Play4Fun.Repository.Impl
{
    public class GameRepository : IGameRepository
    {
        ApiDbContext db;
        public GameRepository(ApiDbContext db)
        {
            this.db = db;
        }
        public List<Game> GetAllActive()
        {
            List<Game> games = db.Games.Where(s => s.Status != GameStatusEnum.INACTIVE).OrderBy(s => s.Id).ToList();
            return games;
        }
    }
}