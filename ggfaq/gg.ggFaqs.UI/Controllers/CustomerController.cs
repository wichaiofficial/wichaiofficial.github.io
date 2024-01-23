using gg.ggFaqs.BL;
using gg.ggFaqs.BL.Models;
using gg.ggFaqs.UI.Models;
using gg.ggFaqs.UI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace gg.ggFaqs.UI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View(CustomerManager.LoadById(id));
        }

        // GET: CustomerController/Create
        public ActionResult Create(string returnUri)
        {
            TempData["returnuri"] = returnUri;
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            try
            {
                customer.Address = "";
                customer.City = "";
                customer.State = "";
                customer.ZipCode = "";
                customer.Phone = "";
                customer.ProfileImage = "img/GameCovers/DefaultProfilePicture.jpg";
                customer.AboutMe = "";
                customer.SocialSites = "";
                CustomerManager.Insert(customer);
                Login(customer);
                if (TempData["returnuri"] != null)
                {
                    return Redirect(TempData["returnuri"]?.ToString());
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                Customer customer = HttpContext.Session.GetObject<Customer>("customerobject");
                if (customer != null)
                {
                    return View(new CustomerProfileViewModel(customer));
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                //Should not get to this point due to this being handled right within the layout page
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            try
            {
                CustomerManager.Update(customer);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(CustomerManager.LoadById(id));
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Game game)
        {
            try
            {
                CustomerManager.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Login
        public ActionResult Login(string returnUri)
        {
            TempData["returnuri"] = returnUri;
            return View();
        }

        // POST: CustomerController/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Customer customer)
        {
            try
            {
                if(CustomerManager.Login(customer.Username, customer.Password))
                {
                    customer = CustomerManager.LoadByUsername(customer.Username);
                    SetCustomer(customer);

                    if (TempData["returnuri"] != null)
                    {
                        return Redirect(TempData["returnuri"]?.ToString());
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(customer);
            }
        }

        public ActionResult Logout()
        {
            SetCustomer(null);
            HttpContext.Session.Remove("customername");
            return RedirectToAction("Index", "Home");
        }

        //Sets the customer information in session
        private void SetCustomer(Customer customer)
        {
            //Full object put into session
            HttpContext.Session.SetObject("customerobject", customer);

            //This is just putting the name so we can display at the top of screen into session (used in the layout file)
            if (customer != null)
            {
                //Set the welcome message based on time of day
                if(DateTime.Now.Hour > 12)
                { HttpContext.Session.SetObject("customername", customer.DisplayName); }
                else
                { HttpContext.Session.SetObject("customername", customer.DisplayName); }
            }
            else
            {
                HttpContext.Session.SetObject("customername", string.Empty);
            }
        }


    }
}
