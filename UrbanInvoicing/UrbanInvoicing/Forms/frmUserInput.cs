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


        public frmUserInput()
        {
            InitializeComponent();
        }
        public frmUserInput(string pName,double pVat)
        {
            _Name = pName;
            _MwSt = pVat;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tmpArticle = new clsArticle();
            try
            {
            tmpArticle.name = _Name;
            tmpArticle.vatRate = _MwSt;

            tmpArticle.Save();

            MessageBox.Show("Speichern erfolgreich","Erfolg",MessageBoxButtons.OK);

            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                
            }
        }
    }
}
