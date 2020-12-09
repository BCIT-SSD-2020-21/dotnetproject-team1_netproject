using Microsoft.EntityFrameworkCore;
using Parlez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parlez.Data
{
    public class ChatDbSeeder
    {
        public static async Task SeedAsync(ChatDbContext chatContext)
        {
            if (!await chatContext.Messages.AnyAsync())
            {
                await chatContext.Messages.AddRangeAsync(
                   GetPreconfiguredMessages());

                await chatContext.SaveChangesAsync();
            }
            if (!await chatContext.Users.AnyAsync())
            {
                await chatContext.Users.AddRangeAsync(
                    GetPreconfiguredUsers());

                await chatContext.SaveChangesAsync();
            }

        }

        static IEnumerable<Messages> GetPreconfiguredMessages()
        {
            return new List<Messages>()
            {
                new Messages(1,"First Message",DateTime.Now)
                
            };
        }

        static IEnumerable<Users> GetPreconfiguredUsers()
        {
            return new List<Users>()
            {
                new Users("testUser","img/test","FirstNameUser","LasstNameUser","test@test.com", true)

            };
        }
    }
}
