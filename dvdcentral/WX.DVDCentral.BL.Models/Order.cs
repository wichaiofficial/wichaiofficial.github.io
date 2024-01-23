using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.DVDCentral.BL.Models
{
    public class Order
    {
        [DisplayName("Order Number")]
        public int Id { get; set; }
        [DisplayName("Customer Id")]
        public int CustomerId { get; set; }
        [DisplayName("Order Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime OrderDate { get; set; }
        [DisplayName("User Id")]
        public int UserId { get; set; }
        [DisplayName("Shiped Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ShipDate { get; set; }
        [DisplayName("Ordered Item")]
        public List<OrderItem> Orderitem { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public double SubTotal
        {
            get
            {
                double subtotal = 0;

                return Orderitem.Sum(i => i.Cost += subtotal);
            }
        }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public double Tax { get { return SubTotal * .055; } }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public double Total { get { return SubTotal + Tax; } }
        [DisplayFormat(DataFormatString = "{0:c}")]

        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        [DisplayName("User Name")]
        public string Username { get; set; }
        [DisplayName("User Full Name")]
        public string UserFullName { get; set; }

    }
}
