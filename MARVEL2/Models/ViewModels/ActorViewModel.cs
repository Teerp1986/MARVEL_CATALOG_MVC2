using MARVEL2.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MARVEL2.Models.ViewModels
{
    public class ActorViewModel : Actor
    {
        public string? SelectedHeroes { get; set; }
        
        public List<SelectListItem>? HeroesSelectList { get; set; }
    }
}
