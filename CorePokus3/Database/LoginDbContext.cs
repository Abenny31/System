using CorePokus3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace CorePokus3.Database
{
    public class LoginDbContext : IdentityDbContext<User,AppRole,int>
    {
        public LoginDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }
       
        //public DbSet<RegisterViewModel> RegisterViewModel { get; set; }
    }
}
