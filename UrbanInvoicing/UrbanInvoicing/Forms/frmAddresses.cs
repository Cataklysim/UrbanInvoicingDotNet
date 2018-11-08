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
    public partial class frmAddresses : Form
    {
        public frmAddresses()
        {
            InitializeComponent();
        }

        private void frmAddresses_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            this.bindingSourceAddresses.DataSource = clsCustomer.GetCustomerFromDB();
        }
    }
}
