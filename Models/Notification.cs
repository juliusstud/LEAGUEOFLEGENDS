using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lab2server.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int SenderId { get; set; }
        [Required]
        public int ReceiverId { get; set; }
    }
}
