using Microsoft.AspNetCore.Mvc;
using WX.DVDCentral.UI.Models;

namespace WX.DVDCentral.UI.ViewComponents
{
    public class ShoppingCart : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (HttpContext.Session.GetObject<BL.Models.ShoppingCart>("cart") != null)
            {
                return View(HttpContext.Session.GetObject<BL.Models.ShoppingCart>("cart"));
            }
            else
            {
                return View(new BL.Models.ShoppingCart());
            }
        }
    }
}
