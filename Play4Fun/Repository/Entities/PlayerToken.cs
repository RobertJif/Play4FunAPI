using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Play4Fun.Repository.Entities
{
    public class PlayerToken : BaseEntity
    {
        public string RefreshToken { get; set; }

        public int PlayerId { get; set; }

        public Player Player { get; set; }
    }

    public class PlayerTokenEntityTypeConfiguration : IEntityTypeConfiguration<PlayerToken>
    {
        public void Configure(EntityTypeBuilder<PlayerToken> builder)
        {
            builder.Property(b => b.RefreshToken).HasMaxLength(128);
            builder.HasOne(s => s.Player);
        }
    }
}