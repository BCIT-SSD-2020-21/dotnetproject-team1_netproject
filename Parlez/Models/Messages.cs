using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parlez.Models
{
    public class Messages
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string MessageText { get; set; }
        public DateTime CreatedOn { get; set; }

        public Messages(int id, string userName, string messageText, DateTime createdOn)
        {
            Id = id;
            UserName = userName;
            MessageText = messageText;
            CreatedOn = createdOn;
        }

    }
}
