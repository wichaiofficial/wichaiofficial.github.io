using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSalesTax
{
    public class CTransaction
    {
        // Properties
        private double taxRate;

        public double TaxRate
        {
            get { return taxRate; }
            set { taxRate = value; }
        }
        // Method
        public double CalculateSalesTax (double dblSales)
        {
            return (taxRate * dblSales);
        }
    }
}
