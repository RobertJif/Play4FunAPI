using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Play4Fun.Repository.Entities;

namespace Play4Fun.Repository.Impl
{
    public class PlayerRepository : IPlayerRepository
    {
        ApiDbContext db;
        public PlayerRepository(ApiDbContext db)
        {
            this.db = db;
        }

        public int Create(string username, string password, byte[] salt)
        {
            var player = new Player
            {
                Salt = salt,
                DisplayName = username,
                Username = username,
                Password = password,
                Status = PlayerStatus.ACTIVE
            };
            db.Players.Add(player);
            db.SaveChanges();

            return player.Id;
        }

        public Player GetActive(string username, string password)
        {
            var player = db.Players.Where(s => s.Username == username & s.Password == password & s.Status == PlayerStatus.ACTIVE).First();
            return player;
        }
    }
}