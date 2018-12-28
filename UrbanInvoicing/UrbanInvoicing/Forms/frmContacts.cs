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
            this.Text = "Adressbuch";
            this.Customer = clsCustomer.GetCustomerFromDB();
            this.bindingSourceCustomer.DataSource = this.Customer;
        }

        private List<clsCustomer> Customer { get; set; }

        private void dataGridViewCustomer_DoubleClick(object sender, EventArgs e)
        {
            this.OpenDetails();
        }

        private void OpenDetails()
        {
            if (this.dataGridViewCustomer.SelectedRows[0] != null && this.dataGridViewCustomer.SelectedRows[0].Cells["Id"] != null)
            {
                int tmpCustomerId = 0;
                tmpCustomerId = Convert.ToInt32(this.dataGridViewCustomer.SelectedRows[0].Cells["Id"].Value);
                if (tmpCustomerId > 0)
                {
                    frmContactDetail tmpDetails = new frmContactDetail(this.Customer.Where(w => w.id == tmpCustomerId).FirstOrDefault());
                    tmpDetails.Show();
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewCustomer.SelectedRows.Count > 0)
                this.OpenDetails();
        }

        private void dataGridViewCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewCustomer.SelectedRows.Count > 0)
                this.buttonOpen.Enabled = true;
            else
                this.buttonOpen.Enabled = false;
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
