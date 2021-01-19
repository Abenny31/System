using CorePokus3.Entities;
using CorePokus3.ViewModels;
using Microsoft.EntityFrameworkCore;
using CorePokus3.Database;


namespace CorePokus3.Database
{
    public class LoginDbContext :  DbContext
    {
        public LoginDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RegisterViewModel> RegisterViewModel { get; set; }
    }
}
