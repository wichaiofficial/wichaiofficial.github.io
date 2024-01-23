using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHelloWorld
{
    public partial class FrmHelloWorld : Form
    {
        public FrmHelloWorld()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Will close out the application.

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Will change text on lable to show Welcome sign.

            lblWelcome.Text = "Welcome to Virtual Studio ~ C#!";




            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Will clear the text on Welcome label

            lblWelcome.Text = "";

        }
    }
}
