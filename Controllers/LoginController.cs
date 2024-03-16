using System.Collections.Generic;
using System.Linq;
using lab2server.Data;
using lab2server.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Newtonsoft.Json;

namespace lab2server.Controllers
{
    public class LoginController : ControllerBase
    {
        private readonly MySqlContext _db;
        public LoginController(MySqlContext context)
        {
            _db = context;
        }

        [Route("login/")]
        [HttpPost]
        public IActionResult login([FromBody] LoginRequest loginRequest)
        {
            var userName = loginRequest.UserName;
            var password = loginRequest.Password;

            var maybeUser = _db.Users.Where(u => u.Username == userName && u.Password == password).FirstOrDefault();

            if (maybeUser != null)
            {
                var response = new LoginResponse() { UserId = maybeUser.Id.ToString(), UserName = maybeUser.Username };
                var responseJson = JsonConvert.SerializeObject(response);

                return Ok(responseJson);
            }

            return NotFound();
        }

        [Route("register/")]
        [HttpPost]
        public IActionResult register([FromBody] RegisterRequest registerRequest)
        {
            var userName = registerRequest.UserName;
            var password = registerRequest.Password;
            var email = registerRequest.Email;
            var newUser = new User() { Username = userName, Password = password, Email = email };

            _db.Users.Add(newUser);
            _db.SaveChanges();

            return Ok();
        }
    }
}