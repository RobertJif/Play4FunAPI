using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Play4Fun.Repository.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }

    public class BaseEntityTypeConfiguration : IEntityTypeConfiguration<BaseEntity>
    {
        public void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.CreatedBy).HasDefaultValue("system");
            builder.Property(b => b.CreatedAt).HasDefaultValue(DateTime.UtcNow);
            builder.Property(b => b.ModifiedBy).HasDefaultValue("system");
            builder.Property(b => b.ModifiedAt).HasDefaultValue(DateTime.UtcNow);
        }
    }
}