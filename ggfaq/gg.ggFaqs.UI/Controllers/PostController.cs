using gg.ggFaqs.BL.Models;
using gg.ggFaqs.BL;
using gg.ggFaqs.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using gg.ggFaqs.UI.ViewModels;

namespace gg.ggFaqs.UI.Controllers
{
    public class PostController : Controller
    {
        // GET: PostController/Create
        public ActionResult CreatePost()
        {
            return View();
        }

        // POST: PostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreatePost(Post post)
        {
            try
            {
                if (Authenticate.IsAuthenticated(HttpContext))
                {
                    Customer customer = HttpContext.Session.GetObject<Customer>("customerobject");
                    if (customer != null)
                    {
                        post.ImagePath = "";
                        post.CustomerId = customer.Id;
                        post.Created = DateTime.Now;
                        PostManager.Insert(post);
                    }
                    return RedirectToAction("Details", "Thread", new { id = post.ThreadID });
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

        // GET: PostController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostController/Edit/5
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

        // GET: PostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostController/Delete/5
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
