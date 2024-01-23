using gg.ggFaqs.BL.Models;
using gg.ggFaqs.BL;
using System.Collections.Generic;
using System;

namespace gg.ggFaqs.UI.ViewModels
{
    public class GameListViewModel : BaseViewModel
    {
        public List<Game> Games { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Manufacturer> Manufacturers { get; set; }
        public List<Genre> Genres { get; set; }
        public List<BL.Models.System> Systems { get; set; }
        public Game Game { get; set; }

        public GameListViewModel()
        {
            Games = GameManager.Load();
            Games = Games
              .GroupBy(g => g.Title)
              .Select(ga => ga.First())
              .ToList();
            Ratings = RatingManager.Load();
            Manufacturers = ManufacturerManager.Load();
            Genres = GenreManager.Load();
            Systems = SystemManager.Load();
        }
    }
}
