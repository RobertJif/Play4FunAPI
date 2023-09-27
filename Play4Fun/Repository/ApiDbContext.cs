using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Play4Fun.Repository.Entities;

namespace Play4Fun.Repository
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<Game> Games { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new GameEntityTypeConfiguration().Configure(modelBuilder.Entity<Game>());
        }
    }
}