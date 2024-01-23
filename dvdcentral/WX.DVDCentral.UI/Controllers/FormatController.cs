using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WX.DVDCentral.BL.Models;
using WX.DVDCentral.BL;

namespace WX.DVDCentral.UI.Controllers
{
    public class FormatController : Controller
    {
        // GET: FormatController
        public ActionResult Index()
        {
            ViewBag.Title = "Movie Formats";
            return View(FormatManager.Load());
        }

        // GET: FormatController/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Title = "Movie Format";
            return View(FormatManager.LoadbyId(id));
        }

        // GET: FormatController/Create
        public ActionResult Create()
        {
            ViewBag.Title = "Creat New Movie Format";
            return View();
        }

        // POST: FormatController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Format format)
        {
            try
            {
                FormatManager.Insert(format);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Create New Movie Format";
                return View();
            }
        }

        // GET: FormatController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Title = "Edit Movie Format";
            return View(FormatManager.LoadbyId(id));
        }

        // POST: FormatController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Format format)
        {
            try
            {
                FormatManager.Update(format);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Edit Movie Format";
                return View();
            }
        }

        // GET: FormatController/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.Title = "Delete Movie Format";
            return View(FormatManager.LoadbyId(id));
        }

        // POST: FormatController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Format format)
        {
            try
            {
                FormatManager.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Delete Movie Format";
                return View();
            }
        }
    }
}
