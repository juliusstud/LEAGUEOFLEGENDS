using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lab2server.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int AdminId { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public string MembersIds { get; set; }
    }
}
