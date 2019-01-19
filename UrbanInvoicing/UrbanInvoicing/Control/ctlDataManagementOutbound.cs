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
            this.LoadCells();
        }
        private void dataGridViewOutboundInvoice_SelectionChanged(object sender, EventArgs e)
        {
            int tmpInvoideId = 0;
            if (this.dataGridViewOutboundInvoice.SelectedRows.Count > 0 && this.dataGridViewOutboundInvoice.SelectedRows[0] != null && this.dataGridViewOutboundInvoice.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"] != null)
            {
                tmpInvoideId = Convert.ToInt32(this.dataGridViewOutboundInvoice.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"]);
                if (tmpInvoideId > 0)
                {
                    this.ChangePositionDataSource(tmpInvoideId);
                    this.LoadPositionCells();
                }
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


        private void LoadPositionCells()
        {
            foreach (DataGridViewRow tmpRow in this.dataGridViewOutboundInvoicePosition.Rows)
            {
                foreach (DataGridViewCell tmpCell in tmpRow.Cells)
                {
                    if (tmpCell != null && tmpCell.OwningColumn.Name == "article")
                    {
                        int tmpArticleId = 0;
                        if (tmpRow.Cells["artikelIdDataGridViewTextBoxColumn"] != null)
                        {
                            tmpArticleId = Convert.ToInt32(tmpRow.Cells["artikelIdDataGridViewTextBoxColumn"].Value);
                            clsArticle tmpArticle = this.Articles.Where(w => w.id == tmpArticleId).FirstOrDefault();
                            if (tmpArticle != null)
                                tmpCell.Value = tmpArticle.name;
                        }
                    }
                    else if (tmpCell != null && tmpCell.OwningColumn.Name == "Type")
                    {
                        int tmpTypeId = 0;
                        if (tmpRow.Cells["TypeIdDataGridViewTextBoxColumn"] != null)
                        {
                            tmpTypeId = Convert.ToInt32(tmpRow.Cells["TypeIdDataGridViewTextBoxColumn"].Value);
                            clsType tmpType = this.Types.Where(w => w.id == tmpTypeId).FirstOrDefault();
                            if (tmpType != null)
                                tmpCell.Value = tmpType.name;
                        }
                    }
                }
            }
        }

        private void LoadCells()
        {
            foreach (DataGridViewRow tmpRow in this.dataGridViewOutboundInvoice.Rows)
            {
                foreach (DataGridViewCell tmpCell in tmpRow.Cells)
                {
                    if (tmpCell != null && tmpCell.OwningColumn.Name == "customer")
                    {
                        int tmpCustomerId = 0;
                        if (tmpRow.Cells["customerIdDataGridViewTextBoxColumn"] != null)
                        {
                            tmpCustomerId = Convert.ToInt32(tmpRow.Cells["customerIdDataGridViewTextBoxColumn"].Value);
                            clsCustomer tmpCustomer = this.Customer.Where(w => w.id == tmpCustomerId).FirstOrDefault();
                            if (tmpCustomer != null)
                                tmpCell.Value = (String.IsNullOrWhiteSpace(tmpCustomer.invoiceName) ? tmpCustomer.name : tmpCustomer.invoiceName) + " " + (String.IsNullOrWhiteSpace(tmpCustomer.invoiceLastName) ? tmpCustomer.lastName : tmpCustomer.invoiceName);
                        }
                    }
                }
            }
        }
    }
}
