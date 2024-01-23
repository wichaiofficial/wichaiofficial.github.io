using gg.ggFaqs.BL;
using gg.ggFaqs.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace gg.ggFaqs.UI.Controllers
{
    public class ManufacturerController : Controller
    {
        // GET: ManufacturerController
        public ActionResult Index()
        {
            return View(ManufacturerManager.Load());
        }

        // GET: ManufacturerController/Details/5
        public ActionResult Details(int id)
        {
            return View(ManufacturerManager.LoadById(id));
        }
    }
}
