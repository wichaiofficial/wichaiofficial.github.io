using System.ComponentModel.DataAnnotations;


namespace WX.DVDCentral.BL.Models
{
    public class ShoppingCart
    {
        public List<Movie> Items { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public double SubTotal 
        {
            get
            {
                double subtotal = 0;

                return Items.Sum(i => i.Cost += subtotal) ;
            }  
        }

        public int TotalCount { get { return Items.Count; } }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public double Tax { get { return SubTotal * .055; } }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public double Total { get { return SubTotal + Tax; } }

        public ShoppingCart()
        { 
            Items = new List<Movie>();
        }

    }
}
