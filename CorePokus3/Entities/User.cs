using Microsoft.AspNetCore.Identity;

namespace CorePokus3.Entities
{
    public class User : IdentityUser<int>
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int PersonId { get; set; }
    }
}
