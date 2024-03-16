
using System;
using System.ComponentModel.DataAnnotations;

namespace lab2server.Models
{
    public class LoginRequest
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
