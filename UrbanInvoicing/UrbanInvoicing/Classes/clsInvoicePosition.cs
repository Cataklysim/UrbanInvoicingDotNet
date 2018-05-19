using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanInvoicing.Classes;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Diagnostics;

namespace UrbanInvoicing.Classes
{
    public class clsInvoicePosition : clsDatabaseObject
    {

        private int Id{ get; set; }

        private int InvoiceId{ get; set; }

        public String Bemerkung{ get; set; }

        public double Brutto{ get; set; }

        public double Netto{ get; set; }

        public double MwSt{ get; set; }

        public double Rabatt{ get; set; }

        public int ArtikelId{ get; set; }

        public int TypeId{ get; set; }

        private clsType InvoiceType{ get; set; }

        private clsArticle Articel{ get; set; }

        private clsInvoice Invoice{ get; set; }

        public clsInvoicePosition()
        {

        }

        public clsInvoicePosition(int pId, int pInvoiceId, int pArtikelId, String pBemerkung, double pBrutto, double pNetto, double pMwst, double pRabat, clsType pType)
        {
            this.Id = pId;
            this.InvoiceId = pInvoiceId;
            this.InvoiceType = pType;
            this.TypeId = this.InvoiceType.id;
            this.ArtikelId = pArtikelId;
            this.Bemerkung = pBemerkung;
            this.Brutto = pBrutto;
            this.Netto = pNetto;
            this.MwSt = pMwst;
            this.Rabatt = pRabat;
        }

        public void SetInvoiceId(int pInvoiceId)
        {
            this.InvoiceId = pInvoiceId;
        }

        public override bool Save()
        {
            bool result = false;
            try
            {

                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("INSERT INTO tbInvoicePosition(invoice_id, bemerkung, brutto, netto, mwSt, rabatt, artikel_id, type_id" +
                        ", systemstatus_id) VALUES (@InvoiceId, @Bemerkung, @Brutto, @Netto, @MWST, @Rabatt, @Artikel_Id, @Type_Id)");
                    tmpCommand.Parameters.AddWithValue("@InvoiceID", this.InvoiceId);
                    tmpCommand.Parameters.AddWithValue("@Bemerkung", this.Bemerkung);
                    tmpCommand.Parameters.AddWithValue("@Brutto", this.Brutto);
                    tmpCommand.Parameters.AddWithValue("@Netto", this.Netto);
                    tmpCommand.Parameters.AddWithValue("@MWST", this.MwSt);
                    tmpCommand.Parameters.AddWithValue("@Rabatt", this.Rabatt);
                    tmpCommand.Parameters.AddWithValue("@Artikel_Id", this.ArtikelId);
                    tmpCommand.Parameters.AddWithValue("@Type_Id", this.TypeId);
                    tmpCommand.Connection = tmpConnection;
                    tmpCommand.Connection.Open();
                    if (tmpCommand.ExecuteNonQuery() == 1)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("# " + DateTime.Now + "clsInvoicePosition - Failed to execute SQL: " + ex);
                result = false; 
            }
            return result;
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }
    }
}