using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSalesTax
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        // When clicked, this will close out the about form.
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
