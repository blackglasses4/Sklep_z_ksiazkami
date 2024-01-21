using Microsoft.AspNetCore.Identity;

namespace Sklep_z_ksiazkami.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public virtual Book? Book { get; set; }

        public string status {  get; set; }
        public DateTime date {  get; set; }

        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
