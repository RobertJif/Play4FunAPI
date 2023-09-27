using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Play4Fun.Repository.Entities
{
    public class Game : BaseEntity
    {
        public string Code { get; set; } = "";

        public string DescriptionHTML { get; set; } = "";

        public string GameImagePath { get; set; } = "";

        public string Name { get; set; } = "";

        public int PlayerCount { get; set; }
    }

    public class GameEntityTypeConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.Property(b => b.Code).IsRequired();
            builder.Property(b => b.DescriptionHTML).IsRequired();
            builder.Property(b => b.GameImagePath).IsRequired();
            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.PlayerCount).IsRequired();
        }
    }
}