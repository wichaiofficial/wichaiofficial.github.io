using Castle.Core.Resource;
using gg.ggFaqs.BL;
using gg.ggFaqs.BL.Models;
using gg.ggFaqs.UI.Models;
using gg.ggFaqs.UI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace gg.ggFaqs.UI.Controllers
{
    public class LibraryController : Controller
    {
        // GET: LibraryController
        public ActionResult Index()
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                Customer customer = HttpContext.Session.GetObject<Customer>("customerobject");
                if(customer != null)
                {
                    LibraryViewModel libraryVM = new LibraryViewModel(customer.Id);
                    return View(libraryVM);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return RedirectToAction("Login", "Customer", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // GET: LibraryController/Details/5
        public ActionResult Details(int id)
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                return View(LibraryGameManager.LoadById(id));
            }
            else
            {
                return RedirectToAction("Login", "Customer", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        public ActionResult AddGameToLibrary(int id)
        {
            try
            {
                if (Authenticate.IsAuthenticated(HttpContext))
                {
                    Customer customer = HttpContext.Session.GetObject<Customer>("customerobject");
                    if(customer != null)
                    { 
                        if(GameManager.LoadById(id) != null)
                        {
                            Library library = LibraryManager.LoadByCustomerId(customer.Id);
                            List<LibraryGame> libraryGames = LibraryGameManager.LoadByLibraryId(library.Id);
                            //check if they already have the game in their library, if so just send them to their library and dont insert
                            foreach(LibraryGame lgame in libraryGames)
                            {
                                if(lgame.GameId ==id) 
                                {
                                    return View("Index", new LibraryViewModel(customer.Id));
                                }
                            }
                            LibraryGame lb = new LibraryGame() { LibraryId = library.Id, GameId = id };
                            LibraryGameManager.Insert(lb);
                        }
                    }
                    return View("Index", new LibraryViewModel(customer.Id));
                }
                else
                {
                    return RedirectToAction("Login", "Customer", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
                }
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: LibraryController/Edit/5
        public ActionResult Edit(int id)
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                return View(LibraryManager.LoadById(id));
            }
            else
            {
                return RedirectToAction("Login", "Customer", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // POST: LibraryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Library library)
        {
            try
            {
                if (Authenticate.IsAuthenticated(HttpContext))
                {
                    LibraryManager.Update(library);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return RedirectToAction("Login", "Customer", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: LibraryController/Delete/5
        public ActionResult Delete(int id)
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                return View(LibraryManager.LoadById(id));
            }
            else
            {
                return RedirectToAction("Login", "Customer", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // POST: LibraryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Library library)
        {
            try
            {
                if (Authenticate.IsAuthenticated(HttpContext))
                {
                    LibraryManager.Delete(id);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return RedirectToAction("Login", "Customer", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
                }
            }
            catch
            {
                return View();
            }
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
                if (games.Count > 0)
                {
                    gameListViewModel.Games = searchedGames;
                }
                else
                {
                    gameListViewModel.Games = games;
                }
            }

            //Get customer and load their VM to reput on screen
            Customer customer = HttpContext.Session.GetObject<Customer>("customerobject");
            if (customer != null)
            {
                LibraryViewModel libraryVM = new LibraryViewModel(customer.Id);
                libraryVM.GameListViewModel = gameListViewModel;
                return View("Index", libraryVM);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
