using gg.ggFaqs.BL;
using gg.ggFaqs.BL.Models;

namespace gg.ggFaqs.UI.ViewModels
{
    public class GameViewModel : BaseViewModel
    {
        public Game Game { get; set; }
        public Rating Rating { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Genre Genre { get; set; }
        public List<BL.Models.Thread> Threads { get; set; }

        public GameViewModel(int GameId)
        {
            Game = GameManager.LoadById(GameId);
            Rating = RatingManager.LoadById(Game.RatingId);
            Manufacturer = ManufacturerManager.LoadById(Game.PublisherId);
            Genre = GenreManager.LoadById(Game.GenreId);
            Threads = ThreadManager.LoadByGameId(Game.Id);
        }
    }
}
