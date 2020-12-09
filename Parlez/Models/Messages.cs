using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parlez.Models
{
    public class Messages : BaseEntity
    {
        [Key]
        [ForeignKey("Users")]
       public int? UserId { get; set; }
        public string MessageText { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual Users Users { get; set; }

        public virtual ICollection<MessageRating> MessageRatings{ get; set; }

        public  Messages (int? userId, string messageText, DateTime createdOn)
        {
            UserId = userId;
            MessageText = messageText;
            CreatedOn = createdOn;
        }
        
    }
}
