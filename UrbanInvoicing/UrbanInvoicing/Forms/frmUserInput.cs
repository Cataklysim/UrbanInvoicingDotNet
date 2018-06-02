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
    public partial class frmUserInput : Form
    {
        public static string _Name = "";
        public static double _MwSt = 0.0;
        public static bool _ArticleCreation;


        public frmUserInput()
        {
            InitializeComponent();
        }

        public frmUserInput(bool pCreateArticle)
        {
            _ArticleCreation = pCreateArticle;
            this.label3.Text = pCreateArticle?"Artikel anlegen: ":"Typ anlegen: ";
            if (!pCreateArticle)
            {
                this.labelVat.Hide();
                this.textBoxVat.Hide();
            }
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tmpArticle = new clsArticle();
            try
            {
                tmpArticle.name = textBoxName.Text;
                tmpArticle.vatRate = Convert.ToDouble(textBoxVat.Text);

                tmpArticle.Save();

                MessageBox.Show("Speichern erfolgreich", "Erfolg", MessageBoxButtons.OK);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
