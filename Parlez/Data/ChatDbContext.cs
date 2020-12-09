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

        public DbSet<MessageRating> MessageRating { get; set; }

        public DbSet <Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Messages>()
               .HasKey(m => new { m.UserId });

            modelBuilder.Entity<Messages>()
                .HasOne(m => m.Users)
                .WithMany(u => u.Messages)
                .HasForeignKey(fk => new { fk.UserId });

            modelBuilder.Entity<MessageRating>()
                 .HasKey(mr => new { mr.UserId, mr.MessageId });

            modelBuilder.Entity<MessageRating>()
               .HasOne(mr => mr.Users)
               .WithMany(u => u.MessageRatings)
               .HasForeignKey(fk => new { fk.UserId }); 

            modelBuilder.Entity<MessageRating>()
                .HasOne(mr => mr.Messages)
                .WithMany(m => m.MessageRatings)
                .HasForeignKey(fk => new { fk.MessageId });

         
        }
    }
}
