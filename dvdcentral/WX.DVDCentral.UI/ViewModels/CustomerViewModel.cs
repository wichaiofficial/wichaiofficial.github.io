using WX.DVDCentral.BL.Models;

namespace WX.DVDCentral.UI.ViewModels
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }
        public List<Customer> Customer { get; set; }
        public List<Order> Orders { get; set; }
        public ShoppingCart Cart { get; set; }

    }
}
