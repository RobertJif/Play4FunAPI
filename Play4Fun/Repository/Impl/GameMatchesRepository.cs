using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Play4Fun.Repository.Entities;

namespace Play4Fun.Repository.Impl
{
    public class GameMatchesRepository : IGameMatchesRepository
    {
        ApiDbContext db;
        public GameMatchesRepository(ApiDbContext db)
        {
            this.db = db;
        }
        public List<GameMatch> GetAll(string gameCode)
        {
            return db.GameMatches.Where(s => s.Game.Code == gameCode).OrderByDescending(s => s.Id).ToList();
        }
        public GameMatch Create()
    }
}