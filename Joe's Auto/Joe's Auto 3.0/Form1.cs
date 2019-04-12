using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_s_Auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void invoiceBtn_Click(object sender, EventArgs e)
        {
            new Invoices().Show();
        }

        private void partBtn_Click(object sender, EventArgs e)
        {
            new Parts().Show();
        }

        private void customBtn_Click(object sender, EventArgs e)
        {
            new Customer().Show();
        }

        private void vehicleBtn_Click(object sender, EventArgs e)
        {
            new Vehicle().Show();
        }
    }
}
