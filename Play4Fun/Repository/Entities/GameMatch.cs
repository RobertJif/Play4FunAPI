using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Play4Fun.Repository.Entities
{
    public class GameMatch : BaseEntity
    {

        public DateTime MatchEndAt { get; set; }
        public MatchStatusEnum MatchStatus { get; set; }
        public int WinnerId { get; set; }
        public int GameId { get; set; }

        #region Relations
        public ICollection<GameMatchPlayer> Players { get; set; }
        public Player Winner { get; set; }
        public Game Game { get; set; }
        public List<string> Result { get; set; }
        #endregion
    }

    public class GameMatchEntityTypeConfiguration : IEntityTypeConfiguration<GameMatch>
    {
        public void Configure(EntityTypeBuilder<GameMatch> builder)
        {
            builder.HasOne(s => s.Game);
            builder.Property(b => b.MatchStatus).HasDefaultValue(MatchStatusEnum.READY);

            builder.HasMany(s => s.Players).WithOne(p => p.GameMatch).HasForeignKey(s => s.GameMatchId);
            builder.HasOne(s => s.Winner);
        }
    }

    public enum MatchStatusEnum
    {
        READY,
        IN_PROGRESS,
        ENDED
    }
}