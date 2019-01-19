using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanInvoicing.Classes;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Diagnostics;
using System.Windows.Forms;

namespace UrbanInvoicing.Classes
{
    public class clsInvoicePosition : clsDatabaseObject
    {

        private int Id { get; set; }

        private int InvoiceId { get; set; }

        public String Bemerkung { get; set; }

        public double Brutto { get; set; }

        public double Netto { get; set; }

        public double MwSt { get; set; }

        public double MwStCalculated { get; set; }

        public double Rabatt { get; set; }

        public int ArtikelId { get; set; }

        public int TypeId { get; set; }

        public double Count { get; set; }

        private clsType InvoiceType { get; set; }

        private clsArticle Articel { get; set; }

        private clsInvoice Invoice { get; set; }

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
                    MySqlCommand tmpCommand = new MySqlCommand("INSERT INTO tbInvoicePosition(invoice_id, bemerkung, brutto, netto, mwst, rabatt, artikel_id, type_id" +
                        ", systemstatus_id, createdAt, editedAt) VALUES (@InvoiceId, @Bemerkung, @Brutto, @Netto, @MWST, @Rabatt, @Artikel_Id, @Type_Id, 1, NOW(), NOW())");
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
                if (Properties.Settings.Default.DevBuild)
                    Debug.WriteLine("# " + DateTime.Now + "clsInvoicePosition - Failed to execute SQL: " + ex);
                else
                    MessageBox.Show("Fehler während der Datenbankabfrage.\r\nFehler bei: clsInvoicePosition - Save", "Datenbank Fehler", MessageBoxButtons.OK);
                result = false;
            }
            return result;
        }

        public static List<clsInvoicePosition> LoadByInvoiceId(int pInvoiceId)
        {
            List<clsInvoicePosition> tmpResult = new List<clsInvoicePosition>();
            try
            {

                using (MySqlConnection tmpCon = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCom = new MySqlCommand("SELECT * FROM tbInvoicePosition WHERE invoice_id = @Id");
                    tmpCom.Parameters.AddWithValue("@Id", pInvoiceId);
                    tmpCon.Open();
                    tmpCom.Connection = tmpCon;
                    using (MySqlDataReader tmpReader = tmpCom.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        clsInvoicePosition tmpEntry = new clsInvoicePosition()
                        {
                            InvoiceId = Convert.ToInt32(tmpReader["invoice_id"]),
                            Bemerkung = tmpReader["bemerkung"].ToString(),
                            Netto = Convert.ToDouble(tmpReader["netto"]),
                            MwSt = Convert.ToDouble(tmpReader["mwst"]),
                            Rabatt = Convert.ToDouble(tmpReader["rabatt"]),
                            ArtikelId = Convert.ToInt32(tmpReader["artikel_id"]),
                            TypeId = Convert.ToInt32(tmpReader["type_id"]),
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.DevBuild)
                    Debug.WriteLine("# " + DateTime.Now + "clsInvoicePosition - Failed to execute SQL: " + ex);
                else
                    MessageBox.Show("Fehler während der Datenbankabfrage.\r\nFehler bei: clsInvoicePosition - LoadByInvoiceId", "Datenbank Fehler", MessageBoxButtons.OK);
                return null;
            }
            return tmpResult;
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }
    }
}