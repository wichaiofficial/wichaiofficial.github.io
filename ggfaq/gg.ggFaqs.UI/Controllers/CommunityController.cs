using gg.ggFaqs.UI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gg.ggFaqs.UI.Controllers
{
    public class CommunityController : Controller
    {
        // GET: CommunityController
        public ActionResult Index()
        {
            EventViewModel threadVM = new EventViewModel();
            return View(threadVM);
        }

        // GET: CommunityController/Details/5
        public ActionResult Threads(int id)
        {
            return View(new ThreadListViewModel(id));
        }

        // GET: CommunityController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommunityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommunityController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CommunityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommunityController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CommunityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
