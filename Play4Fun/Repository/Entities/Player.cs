using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Play4Fun.Repository.Entities
{
    public class Player : BaseEntity
    {
        public PlayerStatus Status { get; set; }

        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }

        public ICollection<GameMatchPlayer> GameMatchPlayers { get; set; }
        public ICollection<PlayerToken> PlayerTokens { get; set; }

    }

    public class PlayerEntityTypeConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.Property(b => b.Username).IsRequired().HasMaxLength(20);
            builder.Property(b => b.DisplayName).IsRequired().HasMaxLength(20);
            builder.Property(b => b.Password).IsRequired().HasMaxLength(128);
            builder.Property(b => b.Status).IsRequired();
            builder.Property(b => b.Salt).IsRequired();

            builder.HasIndex(b => b.Username).IsUnique();
            builder.HasMany(s => s.GameMatchPlayers).WithOne(p => p.Player).HasForeignKey(p => p.PlayerId);
            builder.HasMany(s => s.PlayerTokens).WithOne(p => p.Player).HasForeignKey(p => p.PlayerId);
        }
    }

    public enum PlayerStatus
    {
        ACTIVE,
        SUSPENDED,
        TERMINATED,
        LOCKED
    }
}