using WX.DVDCentral.BL;
using WX.DVDCentral.BL.Models;
using WX.DVDCentral.PL;
using Microsoft.Build.Construction;

namespace WX.DVDCentral.UI.ViewModels
{
    public class MovieViewModel
    {
        public BL.Models.Movie Movie { get; set; }
        public List<Genre> Genres { get; set; } // All Genres
        public IEnumerable<int> GenreIds { get; set; } // the Genres for the movie
        public List<Director> Directors { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Format> Formats { get; set; }
        public IFormFile File { get; set; }

        public MovieViewModel()
        {
            Movie = new Movie();
            Genres = GenreManager.Load();
            Directors = DirectorManager.Load();
            Ratings = RatingManager.Load();
            Formats = FormatManager.Load();

        }

        public MovieViewModel(int id)
        {
            Genres = GenreManager.Load();
            Directors = DirectorManager.Load();
            Ratings = RatingManager.Load();
            Formats = FormatManager.Load();
            Movie = MovieManager.LoadbyId(id);

            GenreIds = Movie.Genres.Select(a => a.Id);
        }
    }
}
