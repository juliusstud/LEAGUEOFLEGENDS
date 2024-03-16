using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab2server.Models;

namespace lab2server.Data
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> opt) : base(opt)
        {


        }
        public DbSet<User> Users { get; set; }
    }
}
