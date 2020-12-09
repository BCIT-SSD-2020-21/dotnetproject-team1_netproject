using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parlez.Models
{
    public class Users : BaseEntity
    {
        
        public string Username { get; set; }
        public string ImageUri { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

        public virtual ICollection<Messages> Messages{ get; set; }
        public virtual ICollection<MessageRating> MessageRatings { get; set; }
        public Users (string username, string imageUri, string firstName, string lastName,
            string email, bool isAdmin)
        {
            Username = username;
            ImageUri = imageUri;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            IsAdmin = isAdmin;
        }
    }

}
