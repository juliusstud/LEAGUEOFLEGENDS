using System.Collections.Generic;
using System.Linq;
using lab2server.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Newtonsoft.Json;

namespace lab2server.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly MySqlContext _db;
        public UserController(MySqlContext context)
        {
            _db = context;
        }

        [Route("user/getUser/{id}")]
        [HttpGet]
        public IActionResult getUser(int id)
        {
            var user = _db.Users.Where(u => u.Id == id).FirstOrDefault();
            var serialized = JsonConvert.SerializeObject(user);
            return Ok(serialized);
        }
    }
}