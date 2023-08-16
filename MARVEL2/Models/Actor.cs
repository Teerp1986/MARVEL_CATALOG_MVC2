using AspNetCore;
using MARVEL2.Controllers;
using MARVEL2.Models.Helper;
using MARVEL2.Models.ViewModels;

namespace MARVEL2.Models
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Age
        {
            get
            {
                var age = DateTime.UtcNow - Birthdate;
                return (int)(age.TotalDays / 365.3426);
            }
        }

        public DateTime Birthdate { get; set; }
        public string? HeroName { get; set; }
        public string? Movies { get; set; }

        

    }
}
