using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using WX.DVDCentral.BL;
using WX.DVDCentral.BL.Models;
using WX.DVDCentral.UI.Models;
using WX.DVDCentral.UI.ViewModels;

namespace WX.DVDCentral.UI.Controllers
{
    public class MovieController : Controller
    {
        private readonly IWebHostEnvironment _host;

        public MovieController(IWebHostEnvironment host)
        {
            _host = host;
        }

        // GET: MovieController
        public ActionResult Index()
        {
            ViewBag.Title = "Movies";
            return View(MovieManager.Load());
        }

        public ActionResult Browse(int id)
        {
            ViewBag.Title = "Movies";
            return View(nameof(Index), MovieManager.LoadByGenreId(id));
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Title = "Movie Information";
            return View(MovieManager.LoadbyId(id));
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                ViewBag.Title = "Add New Movie";
                MovieViewModel movieViewModel = new MovieViewModel();
                movieViewModel.Movie = new BL.Models.Movie();
                movieViewModel.Genres = GenreManager.Load();
                movieViewModel.Directors = DirectorManager.Load();
                movieViewModel.Ratings = RatingManager.Load();
                movieViewModel.Formats = FormatManager.Load();

                return View(movieViewModel);
            }
            else
            {
                return RedirectToAction("Login", "User", new { returnUri = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovieViewModel movieViewModel)
        { 
            try {
                // Insert first because we need the new tblStudent.Id for the advisors
                MovieManager.Insert(movieViewModel.Movie);

                IEnumerable<int> newGenreIds = new List<int>();
                if (movieViewModel.GenreIds != null)
                    newGenreIds = movieViewModel.GenreIds;

                // Do the db maintenance
                newGenreIds.ToList().ForEach(a => MovieGenreManager.Insert(movieViewModel.Movie.Id, a));

                if (movieViewModel.File != null)
                {
                    movieViewModel.Movie.ImagePath = movieViewModel.File.FileName;

                    // Upload the file
                    string path = _host.WebRootPath + "\\images\\";

                    if (!System.IO.File.Exists(path + movieViewModel.File.FileName))
                    {
                        using (var stream = System.IO.File.Create(path + movieViewModel.File.FileName))
                        {
                            movieViewModel.File.CopyTo(stream);
                            ViewBag.Message = "File Uploaded Successfully...";
                        }
                    }

                }

                MovieManager.Insert(movieViewModel.Movie);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Add New Movie";
                return View(movieViewModel);
            }

        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Title = "Update Movie";

            MovieViewModel movieViewModel = new MovieViewModel(id);

            // Stores exisiting movieGenre id
            HttpContext.Session.SetObject("genreids", movieViewModel.GenreIds);

            return View(movieViewModel);
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MovieViewModel movieViewModel)
        {
            try
            {
                if (movieViewModel.File != null)
                {
                    movieViewModel.Movie.ImagePath = movieViewModel.File.FileName;

                    // Upload the file
                    string path = _host.WebRootPath + "\\images\\";

                    if (!System.IO.File.Exists(path + movieViewModel.File.FileName))
                    {
                        using (var stream = System.IO.File.Create(path + movieViewModel.File.FileName))
                        {
                            movieViewModel.File.CopyTo(stream);
                            ViewBag.Message = "File Uploaded Successfully...";
                        }
                    }

                    MovieManager.Update(movieViewModel.Movie);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Update Movie";
                return View(movieViewModel);
            }


            try
            {
               
                IEnumerable<int> newGenreIds = new List<int>();
                if ( movieViewModel.GenreIds != null) 
                    newGenreIds = movieViewModel.GenreIds;

                IEnumerable<int> oldGenreIds = new List<int>();
                oldGenreIds = GetObject();

                // Delete all the old genres that aren't in the newgenres
                IEnumerable<int> deletes = oldGenreIds.Except(newGenreIds);
                IEnumerable<int> adds = newGenreIds.Except(oldGenreIds);

                // Do the db maintenance
                deletes.ToList().ForEach(d => MovieGenreManager.Delete(id, d));
                adds.ToList().ForEach(a => MovieGenreManager.Insert(id, a));
            
                MovieManager.Update(movieViewModel.Movie);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Update Movie";
                return View(movieViewModel);
            }
        }

        private IEnumerable<int> GetObject()
        {
            if (HttpContext.Session.GetObject<IEnumerable<int>>("genreids") != null)
            {
                return HttpContext.Session.GetObject<IEnumerable<int>>("genreids"); ;
            }
            else
            {
                return null;
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.Title = "Delete Movie";
            return View(MovieManager.LoadbyId(id));
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Movie movie)
        {
            try
            {
                MovieManager.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Delete Movie";
                return View();
            }
        }
    }
}
