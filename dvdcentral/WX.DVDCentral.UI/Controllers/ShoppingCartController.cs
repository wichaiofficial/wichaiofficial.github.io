using Microsoft.AspNetCore.Mvc;
using WX.DVDCentral.UI.Models;
using WX.DVDCentral.BL.Models;
using WX.DVDCentral.BL;
using WX.DVDCentral.PL;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http.Extensions;

namespace WX.DVDCentral.UI.Controllers
{
    public class ShoppingCartController : Controller
    {
        ShoppingCart cart;
        public IActionResult Index()
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                ViewBag.Title = "Shopping Cart";
                cart = GetShoppingCart();

                return View(cart);
            }
            else
            {
                return RedirectToAction("Login", "User", new { returnUri = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        
        }

        private ShoppingCart GetShoppingCart()
        {
            if (HttpContext.Session.GetObject<ShoppingCart>("cart") != null)
            {
                return HttpContext.Session.GetObject<ShoppingCart>("cart");
            }
            else
            {
                return new ShoppingCart();
            }
        }

        public IActionResult AddToCart(int id)
        {

            cart = GetShoppingCart();
            BL.Models.Movie movie = MovieManager.LoadbyId(id);
            cart.Items.Add(movie);
            HttpContext.Session.SetObject("cart", cart);
            return RedirectToAction(nameof(Index), "movie");
        }


        public IActionResult Remove(int id)
        {
            cart = GetShoppingCart();
            BL.Models.Movie movie = cart.Items.FirstOrDefault(i => i.Id == id);
            cart.Items.Remove(movie);
            HttpContext.Session.SetObject("cart", cart);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Checkout()
        {
            cart = GetShoppingCart();

            if (Authenticate.IsAuthenticated(HttpContext))
            {

                // Create a new Order Object and it's Order.OrderItems.
                Order order = new Order();
                {
                    order.CustomerId = 1;
                    order.UserId = 1;
                    order.OrderDate = DateTime.Now;
                    order.ShipDate = DateTime.Now.AddDays(3);

                };
                // Loop through the ShoppingCart.Items and them to the Order.OrderItems.
                order.Orderitem = new List<OrderItem>();
                foreach (var item in cart.Items)
                {
                    OrderItem orderitem = new OrderItem();
                    orderitem.MovieId = item.Id;
                    orderitem.Quantity = 1;
                    orderitem.Cost = item.Cost;
                    order.Orderitem.Add(orderitem);
                }
                //OrderManager.Insert(order);
                OrderManager.Insert(order);
                HttpContext.Session.SetObject("cart", null);

                return View();
            }
            else
            {
                return RedirectToAction("Login", "User", new { returnUri = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

    }
}
