using gg.ggFaqs.BL.Models;

namespace gg.ggFaqs.UI.Models
{
    public static class Authenticate
    {
        public static bool IsAuthenticated(HttpContext context)
        {
            if (context.Session.GetObject<Customer>("customerobject") != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
