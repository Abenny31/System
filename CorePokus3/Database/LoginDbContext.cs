using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorePokus3.Models;
using CorePokus3.Database;

namespace CorePokus3.Database
{
    public class LoginDbContext :  DbContext
    {
        public LoginDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CorePokus3.Models.RegisterViewModel> RegisterViewModel { get; set; }
    }

   

}
