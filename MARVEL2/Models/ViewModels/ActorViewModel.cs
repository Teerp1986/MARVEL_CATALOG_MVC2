using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace MARVEL2.Models.ViewModels
{
    public class ActorViewModel : Actor
    {
        public string? SelectedHeroes { get; set; }

        public new List<SelectListItem>? HeroesSelectList { get; set; }
        

        public string? SelectedMovies { get; set; }

        public new List<SelectListItem>? MoviesSelectList { get; set; }

    }   
}
