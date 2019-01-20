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
        public bool DataReload = false;

        public frmUserInput()
        {
            InitializeComponent();
        }

        public frmUserInput(bool pCreateArticle)
        {
            InitializeComponent();
            _ArticleCreation = pCreateArticle;
            this.label3.Text = pCreateArticle ? "Artikel anlegen: " : "Typ anlegen: ";
            if (!pCreateArticle)
            {
                this.labelVat.Hide();
                this.textBoxVat.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ArticleCreation)
            {
                var tmpArticle = new clsArticle();
                try
                {
                    bool tmpError = false;
                    tmpArticle.name = textBoxName.Text;
                    try
                    {
                        tmpArticle.vatRate = Convert.ToDouble(textBoxVat.Text);
                    }
                    catch (Exception)
                    {
                        tmpError = true;
                    }

                    if (!tmpError && tmpArticle.Save())
                    {
                        MessageBox.Show("Speichern erfolgreich", "Erfolg", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else if(tmpError)
                    {
                        MessageBox.Show("MwSt enthält einen nicht numerischen Wert.", "Formatierungsfehler", MessageBoxButtons.OK);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                var tmpType = new clsType();
                try
                {
                    tmpType.name = textBoxName.Text;

                    if (tmpType.Save())
                        MessageBox.Show("Speichern erfolgreich", "Erfolg", MessageBoxButtons.OK);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            this.DataReload = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
