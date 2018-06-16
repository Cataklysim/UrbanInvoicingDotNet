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


/*ToDo: Das wird sie Überfordern. Wir müssen es als eine Ansicht für Eingangsrechnung und
 * eine für Ausgangsrechnungen, sowie die Extra maske für die Adressübersicht machen*/
namespace UrbanInvoicing.Forms
{
    public partial class frmDataManagement : Form
    {
        public frmDataManagement()
        {
            InitializeComponent();
        }

        private void frmDataManagement_Load(object sender, EventArgs e)
        {
            this.bindingSourceCustomer.DataSource = clsCustomer.GetCustomerFromDB();
            this.bindingSourceArtikel.DataSource = clsArticle.GetArticlesFromDB();
            this.bindingSourceType.DataSource = clsType.GetTypesFromDB();
                this.bindingSourceInvoice.DataSource = clsInvoice.GetDbList();
        }

        private void dataGridViewInvoice_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewInvoice.SelectedRows.Count == 1)
                this.bindingSourceInvoicePosition.DataSource = clsInvoicePosition.LoadByInvoiceId((int)this.dataGridViewInvoice.SelectedRows[0].Cells["id"].Value);
        }

        public void LoadRepositories()
        {
            List<clsArticle> tmpArticles = new List<clsArticle>();
            List<clsType> tmpTypes = new List<clsType>();
            DataGridViewComboBoxColumn tmpComboBoxArticle = new DataGridViewComboBoxColumn()
            {
                DataSource = this.bindingSourceArtikel,
                DisplayMember = "name",
                ValueMember = "id",
                HeaderText = "Artikel",
                Name = "comboBoxArticle",
            };
            DataGridViewComboBoxColumn tmpComboBoxType = new DataGridViewComboBoxColumn()
            {
                DataSource = this.bindingSourceType,
                DisplayMember = "name",
                ValueMember = "id",
                HeaderText = "Typ",
                Name = "comboBoxType",
            };
            DataGridViewComboBoxColumn tmpComboBoxCustomer = new DataGridViewComboBoxColumn()
            {
                DataSource = this.bindingSourceCustomer,
                DisplayMember = "name",
                ValueMember = "id",
                HeaderText = "Typ",
                Name = "comboBoxCustomer",
            };
            int tmpArtikelIndex = this.dataGridViewInvoice.Columns["artikelIdDataGridViewTextBoxColumn"].DisplayIndex;
            tmpComboBoxArticle.DataPropertyName = this.dataGridViewInvoice.Columns["artikelIdDataGridViewTextBoxColumn"].DataPropertyName;

            int tmpTypIndex = this.dataGridViewInvoice.Columns["typeIdDataGridViewTextBoxColumn"].DisplayIndex;
            tmpComboBoxType.DataPropertyName = this.dataGridViewInvoice.Columns["typeIdDataGridViewTextBoxColumn"].DataPropertyName;

            int tmpCustomerIndex = this.dataGridViewInvoice.Columns["customerIdDataGridViewTextBoxColumn"].DisplayIndex;
            tmpComboBoxCustomer.DataPropertyName = this.dataGridViewInvoice.Columns["customerIdDataGridViewTextBoxColumn"].DataPropertyName;

            tmpComboBoxArticle.DisplayIndex = tmpArtikelIndex;
            tmpComboBoxArticle.AutoComplete = true;

            tmpComboBoxType.DisplayIndex = tmpTypIndex;
            tmpComboBoxType.AutoComplete = true;

            tmpComboBoxCustomer.DisplayIndex = tmpCustomerIndex;
            tmpComboBoxCustomer.AutoComplete = true;

            this.dataGridViewInvoice.Columns.Add(tmpComboBoxArticle);
            this.dataGridViewInvoice.Columns.Add(tmpComboBoxType);
            this.dataGridViewInvoice.Columns.Add(tmpComboBoxCustomer);

            this.dataGridViewPositions.Columns.Add(tmpComboBoxArticle);
            this.dataGridViewPositions.Columns.Add(tmpComboBoxType);
        }
    }
}
