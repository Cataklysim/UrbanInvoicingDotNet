using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrbanInvoicing.Classes;

namespace UrbanInvoicing.Forms
{
    public partial class frmContacts : Form
    {
        public frmContacts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<clsCustomer> tmpCustomers = new List<clsCustomer>();
            tmpCustomers.AddRange(clsCustomer.GetCustomerFromDB());

            frmContactDetail frm = new frmContactDetail(tmpCustomers[2]);
            frm.ShowDialog();
        }
    }
}
