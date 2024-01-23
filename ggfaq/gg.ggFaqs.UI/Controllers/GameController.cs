using gg.ggFaqs.BL;
using gg.ggFaqs.BL.Models;
using gg.ggFaqs.UI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;

namespace gg.ggFaqs.UI.Controllers
{
    public class GameController : Controller
    {
        // GET: GameController
        public ActionResult Index(GameListViewModel gameListViewModel)
        {
            return View(gameListViewModel);
        }

        // GET: GameController/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(new GameDetailsViewModel(GameManager.LoadById(id)));
        }

        // GET: GameController/Create
        public ActionResult Create()
        {
            return View();
        }

        //Get: GameController/Search
        public ActionResult IndexSearch(Game game)
        {
            GameListViewModel gameListViewModel = new GameListViewModel();
            //Load all the games
            List<Game> games = GameManager.Load();
            List<Game> searchedGames = new List<Game>();
            //if the search was not empty
            if (game.Title != null)
            {
                //sort the list if it contains anything of the input value
                searchedGames = games.FindAll(g => g.Title.Contains(game.Title));
                //if there is anything in the list that contains the inputted value
                if (searchedGames.Count > 0)
                {
                    //if there is less that 10 games returned from the search, we will also include games from that genre
                    if(searchedGames.Count < 10)
                    {
                        List<Game> GenreGames = GameManager.LoadByGenreId(searchedGames[0].GenreId); 
                        searchedGames.AddRange(GenreGames);
                        gameListViewModel.Games = searchedGames;
                        gameListViewModel.Games = gameListViewModel.Games.GroupBy(g => g.Title)
                        .Select(ga => ga.First())
                        .ToList();
                    }
                    else
                    {
                        gameListViewModel.Games = searchedGames;
                    }
                }
                else
                {
                    gameListViewModel.Games = games;
                }
            }
            
            return View("Index", gameListViewModel);
        }

        // POST: GameController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Game game)
        {
            try
            {
                GameManager.Insert(game);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GameController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(GameManager.LoadById(id));
        }

        // POST: GameController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Game game)
        {
            try
            {
                GameManager.Update(game);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GameController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(GameManager.LoadById(id));
        }

        // POST: GameController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Game game)
        {
            try
            {
                GameManager.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ApplyFilters(GameListViewModel gVM)
        {
            List<Game> games = new List<Game>();
            //loop though all the genres, check if their checkbox is check, if so load all the games in that genre
            foreach (Genre g in gVM.Genres)
            {
                if(g.IsChecked == true)
                {
                    games.AddRange(GameManager.LoadByGenreId(g.Id));
                }
            }

            //loop though all the ratings, check if their checkbox is check, if so load all the games in that rating
            foreach (Rating r in gVM.Ratings)
            {
                if (r.IsChecked == true)
                {
                    games.AddRange(GameManager.LoadByRatingId(r.Id));
                }
            }

            //Make sure the list is unique and that we dont have duplicates
            gVM.Games = games
              .GroupBy(g => g.Title)
              .Select(ga => ga.First())
              .ToList();
            return View("Index", gVM);
        }

    }
}
