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
            var playerUsername = username.ToLower();
            var now = DateTime.UtcNow;
            var player = new Player
            {
                Salt = salt,
                DisplayName = playerUsername,
                Username = playerUsername,
                Password = password,
                Status = PlayerStatusEnum.ACTIVE,
                CreatedAt = now,
                ModifiedAt = now,
                CreatedBy = playerUsername,
                ModifiedBy = playerUsername
            };
            db.Players.Add(player);

            db.SaveChanges();

            return player.Id;
        }

        public Player? Get(string username)
        {
            var player = db.Players.FirstOrDefault(s => s.Username == username.ToLower());
            return player;
        }

        public Player? Get(string username, PlayerStatusEnum status)
        {
            var player = db.Players.FirstOrDefault(s => s.Username == username.ToLower() & s.Status == status);
            return player;
        }
    }
}