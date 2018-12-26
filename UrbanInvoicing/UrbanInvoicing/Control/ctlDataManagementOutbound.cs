using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrbanInvoicing.Classes;

namespace UrbanInvoicing.Control
{
    public partial class ctlDataManagementOutbound : UserControl
    {
        public ctlDataManagementOutbound()
        {
            InitializeComponent();
            this.Articles = clsArticle.GetArticlesFromDB();
            this.Customer = clsCustomer.GetCustomerFromDB();
            this.Types = clsType.GetTypesFromDB();
        }

        private List<clsArticle> Articles { get; set; }
        private List<clsCustomer> Customer { get; set; }
        private List<clsType> Types { get; set; }

        public void RefreshDataSources()
        {
            List<clsInvoice> tmpInvoices = clsInvoice.GetDbList();
            this.bindingSourceOutboundInvoices.DataSource = tmpInvoices.Where(w => w.IsExport == true).ToList();
            this.Articles = clsArticle.GetArticlesFromDB();
            this.Customer = clsCustomer.GetCustomerFromDB();
            this.Types = clsType.GetTypesFromDB();
        }
        private void dataGridViewOutboundInvoice_SelectionChanged(object sender, EventArgs e)
        {
            int tmpInvoideId = 0;
            if (this.dataGridViewOutboundInvoice.SelectedRows[0] != null && this.dataGridViewOutboundInvoice.SelectedRows[0].Cells["Id"] != null)
            {
                tmpInvoideId = Convert.ToInt32(this.dataGridViewOutboundInvoice.SelectedRows[0].Cells["Id"]);
                if (tmpInvoideId > 0)
                    this.ChangePositionDataSource(tmpInvoideId);
            }
        }
        private void ChangePositionDataSource(int pInvoiceId)
        {
            List<clsInvoicePosition> tmpPositions = clsInvoicePosition.LoadByInvoiceId(pInvoiceId);
            if (tmpPositions != null)
                this.bindingSourcePositions.DataSource = tmpPositions;
            else
                this.bindingSourcePositions.DataSource = new List<clsInvoicePosition>();

        }
        private void dataGridViewOutboundInvoice_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell tmpCurrentCell = (sender as DataGridViewCell);
            if (tmpCurrentCell.OwningColumn.Name == "customer")
            {
                int tmpCustomerId = 0;
                if (this.dataGridViewOutboundInvoice.Rows[e.RowIndex] != null && this.dataGridViewOutboundInvoice.Rows[e.RowIndex].Cells["CustomerId"] != null)
                {
                    tmpCustomerId = Convert.ToInt32(this.dataGridViewOutboundInvoice.Rows[e.RowIndex].Cells["CustomerId"].Value);
                    clsCustomer tmpCustomer = this.Customer.Where(w => w.id == tmpCustomerId).FirstOrDefault();
                    if (tmpCustomer != null)
                        e.Value = tmpCustomer.invoiceName + " " + tmpCustomer.invoiceLastName;
                }
            }
        }
        private void dataGridViewOutboundInvoicePosition_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell tmpCurrentCell = (sender as DataGridViewCell);
            if (tmpCurrentCell.OwningColumn.Name == "article")
            {
                int tmpArticleId = 0;
                if (this.dataGridViewOutboundInvoicePosition.Rows[e.RowIndex] != null && this.dataGridViewOutboundInvoicePosition.Rows[e.RowIndex].Cells["ArtikelId"] != null)
                {
                    tmpArticleId = Convert.ToInt32(this.dataGridViewOutboundInvoicePosition.Rows[e.RowIndex].Cells["ArtikelId"].Value);
                    clsArticle tmpArticle = this.Articles.Where(w => w.Id == tmpArticleId).FirstOrDefault();
                    if (tmpArticle != null)
                        e.Value = tmpArticle.name;
                }
            }
            else if (tmpCurrentCell.OwningColumn.Name == "Type")
            {
                int tmpTypeId = 0;
                if (this.dataGridViewOutboundInvoicePosition.Rows[e.RowIndex] != null && this.dataGridViewOutboundInvoicePosition.Rows[e.RowIndex].Cells["TypeId"] != null)
                {
                    tmpTypeId = Convert.ToInt32(this.dataGridViewOutboundInvoicePosition.Rows[e.RowIndex].Cells["TypeId"].Value);
                    clsType tmpType = this.Types.Where(w => w.id == tmpTypeId).FirstOrDefault();
                    if (tmpType != null)
                        e.Value = tmpType.name;
                }
            }
        }
    }
}
