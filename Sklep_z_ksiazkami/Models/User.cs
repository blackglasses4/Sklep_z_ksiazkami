using Microsoft.AspNetCore.Identity;

namespace Sklep_z_ksiazkami.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
