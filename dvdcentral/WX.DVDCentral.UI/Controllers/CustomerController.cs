using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using WX.DVDCentral.BL;
using WX.DVDCentral.BL.Models;
using WX.DVDCentral.UI.Models;

namespace WX.DVDCentral.UI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: CustomerController
        public ActionResult Index()
        {
            ViewBag.Title = "Customers";
            return View(CustomerManager.Load());
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Title = "Customer Information";
            return View(CustomerManager.LoadbyId(id));
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                ViewBag.Title = "Add New Customer";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "User", new { returnUri = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            try
            {
                CustomerManager.Insert(customer);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Create New Customer";
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                ViewBag.Title = "Edit Customer Info.";
                return View(CustomerManager.LoadbyId(id));
            }
            else
            {
                return RedirectToAction("Login", "User", new { returnUri = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                CustomerManager.Update(customer);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Edit Customer";
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.Title = "Delete Customer";
            return View(CustomerManager.LoadbyId(id));
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Customer customer)
        {
            try
            {
                CustomerManager.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Delete Customer";
                return View();
            }
        }
    }
}
