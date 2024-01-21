using Microsoft.AspNetCore.Identity;

namespace Sklep_z_ksiazkami.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img {  get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
