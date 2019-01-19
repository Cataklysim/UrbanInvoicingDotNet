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
            this._ContactDetail = new ctlContactDetail();
            this._ContactDetail.Parent = this.groupBoxDetails;
            this._ContactDetail.Dock = DockStyle.Fill;
        }

        private ctlContactDetail _ContactDetail { get; set; }
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
                    clsCustomer tmpCustomer = this.Customer.Where(w => w.id == tmpCustomerId).FirstOrDefault();
                    if (tmpCustomer != null)
                        this._ContactDetail.LoadOrCreateCustomer(tmpCustomer);
                    this._ContactDetail.Refresh();
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

        private void buttonNewAddress_Click(object sender, EventArgs e)
        {
            this._ContactDetail.LoadOrCreateCustomer();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this._ContactDetail = null;
            this.Dispose();
        }
    }
}
