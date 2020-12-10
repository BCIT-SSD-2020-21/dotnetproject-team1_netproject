using Microsoft.EntityFrameworkCore;
using Parlez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parlez.Data
{
    public class ChatDbContext : DbContext
    {
        public ChatDbContext(DbContextOptions<ChatDbContext> options) : base(options) { }

        public DbSet<Messages> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Messages>().HasData(
            new {Id = 1, UserName = "suup", MessageText = "Clean house", CreatedOn = DateTime.Now }
        ) ; 
        }
    }
}
