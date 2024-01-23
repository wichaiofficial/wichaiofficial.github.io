using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using WX.DVDCentral.BL;
using WX.DVDCentral.BL.Models;
using WX.DVDCentral.UI.Models;

namespace WX.DVDCentral.UI.Controllers
{
    public class DirectorController : Controller
    {
        // GET: DirectorController
        public ActionResult Index()
        {
            ViewBag.Title = "Movie Directors";
            return View(DirectorManager.Load());
        }

        // GET: DirectorController/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Title = "Movie Director";
            return View(DirectorManager.LoadbyId(id));
        }

        // GET: DirectorController/Create
        public ActionResult Create()
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                ViewBag.Title = "Add New Director";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "User", new { returnUri = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // POST: DirectorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Director director)
        {
            try
            {
                DirectorManager.Insert(director);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Create New Director";
                return View();
            }
        }

        // GET: DirectorController/Edit/5
        public ActionResult Edit(int id)
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                ViewBag.Title = "Edit Director Info.";
                return View(DirectorManager.LoadbyId(id));
            }
            else
            {
                return RedirectToAction("Login", "User", new { returnUri = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // POST: DirectorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Director director)
        {
            try
            {
                ViewBag.Title = "Edit Director";
                DirectorManager.Update(director);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Edit Director";
                return View();
            }
        }

        // GET: DirectorController/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.Title = "Delete Director";
            return View(DirectorManager.LoadbyId(id));
        }

        // POST: DirectorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Director director)
        {
            try
            {
                DirectorManager.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Delete Director";
                return View();
            }
        }
    }
}
