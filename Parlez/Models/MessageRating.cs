using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parlez.Models
{
    public class MessageRating
    {
        [Key, Column(Order = 0)]
        public int UserId { get; set; }
        [Key, Column(Order = 1)]
        public int MessageId { get; set; }
        public int Rating { get; set; }

        public virtual Messages Messages { get; set; }
        public virtual Users Users { get; set; }

        public MessageRating(int userId, int messageId, int rating)
        {
            UserId = userId;
            MessageId = messageId;
            Rating = rating;
        }
    }

}
