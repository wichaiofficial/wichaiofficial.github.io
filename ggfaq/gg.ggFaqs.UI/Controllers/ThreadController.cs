using gg.ggFaqs.BL;
using gg.ggFaqs.BL.Models;
using gg.ggFaqs.UI.Models;
using gg.ggFaqs.UI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace gg.ggFaqs.UI.Controllers
{
    public class ThreadController : Controller
    {
        // GET: ThreadController
        public ActionResult Index()
        {
            ThreadListViewModel threadVM = new ThreadListViewModel();
            return View(threadVM);
        }

        // GET: ThreadController/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                return View(new ThreadViewModel(id));
            }
            else
            {
                return RedirectToAction("Login", "Customer", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // GET: ThreadController/Create
        public ActionResult Create()
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Customer", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // POST: ThreadController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(BL.Models.Thread thread)
        {
            try
            {
                if (Authenticate.IsAuthenticated(HttpContext))
                {
                    Customer customer = HttpContext.Session.GetObject<Customer>("customerobject");
                    if (customer != null)
                    {
                        thread.CustomerId = customer.Id;
                        thread.Created = DateTime.Now;
                    }
                    ThreadManager.Insert(thread);
                    Game game = GameManager.LoadById(thread.GameId);
                    return RedirectToAction("Details", "Thread", new { id = thread.Id });
                }
                else
                {
                    return RedirectToAction("Login", "Customer", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
                }
            }
            catch
            {
                return RedirectToAction("ThreadError", "Thread");
            }
        }

        // GET: ThreadController/Edit/5
        public ActionResult Edit(int id)
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                return View(ThreadManager.LoadById(id));
            }
            else
            {
                return RedirectToAction("Login", "Customer", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // POST: ThreadController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BL.Models.Thread thread)
        {
            try
            {
                if (Authenticate.IsAuthenticated(HttpContext))
                {
                    BL.Models.Thread updatedThread = ThreadManager.LoadById(thread.Id);
                    updatedThread.Title = thread.Title;
                    updatedThread.Subject = thread.Subject;

                    ThreadManager.Update(updatedThread);
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

        // GET: ThreadController/Delete/5
        public ActionResult Delete(int id)
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                return View(ThreadManager.LoadById(id));
            }
            else
            {
                return RedirectToAction("Login", "Customer", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // POST: ThreadController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, BL.Models.Thread thread)
        {
            try
            {
                if (Authenticate.IsAuthenticated(HttpContext))
                {
                    ThreadManager.Delete(id);
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

        //If they try to post something not so nice
        public ActionResult ThreadError()
        {
            return View();  
        }
    }
}
