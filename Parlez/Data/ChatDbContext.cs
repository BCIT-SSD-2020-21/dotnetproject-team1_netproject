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

            modelBuilder.Entity<Users>().HasData
                (

                new {
                    UserId = 1,
                    Username = "TestUser1", 
                    ImageUri = "img/pic1", 
                    FirstName = "TestFirst1", 
                    LastName="TestLast1", 
                    Email = "test1@test.com", 
                    IsAdmin = true 
                },
                new
                {
                    UserId = 2,
                    Username = "TestUser2",
                    ImageUri = "img/pic2",
                    FirstName = "TestFirst2",
                    LastName = "TestLast2",
                    Email = "test2@test.com",
                    IsAdmin = true
                },
                new
                {
                    UserId = 3,
                    Username = "TestUser3",
                    ImageUri = "img/pic3",
                    FirstName = "TestFirst3",
                    LastName = "TestLast3",
                    Email = "test3@test.com",
                    IsAdmin = false
                }
                );

            modelBuilder.Entity<Messages>().HasData
                (

                new
                {
                    UserId = 2,
                    MessageText = "How are you?",
                    CreatedOn = DateTime.Now,
                    MessageId = 1,
                },

                new
                {
                    UserId = 3, 
                    MessageText = "WasUp?",
                    CreatedOn = DateTime.Now,
                    MessageId = 2,
                }

               );

            modelBuilder.Entity<MessageRating>().HasData
                (

                new
                {
                    Rating = 5,
                    UserId = 2,
                    MessageId = 1,
                },

                new
                {
                    Rating = 5,
                    UserId = 3,
                    MessageId = 2,
                }

               );

        }
    }
}
