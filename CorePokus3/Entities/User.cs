using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CorePokus3.Entities
{
    public class User : IdentityUser<int>
    {
        public int Id { get; set; }
        public string Login { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int PersonId { get; set; }
    }
}
