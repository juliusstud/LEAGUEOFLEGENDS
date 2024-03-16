using System;
using System.ComponentModel.DataAnnotations;

namespace lab2server.Models
{
    public class RegisterRequest
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}
