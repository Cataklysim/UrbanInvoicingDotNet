using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace UrbanInvoicing.Classes
{
    public class clsInvoice : clsDatabaseObject
    {

        public int id { get; set; }

        public int customerId { get; set; }

        public DateTime date { get; set; }

        bool printed { get; set; }

        public double sumBrutto { get; set; }

        public double sumNetto { get; set; }

        public double sumMwst { get; set; }
        public string invoiceNumber { get; set; }

        public List<clsInvoicePosition> invoicePositions = new List<clsInvoicePosition>();

        public clsInvoice()
        {

        }

        override public void Load()
        {

        }

        override public bool Save()
        {
            bool result = false;

            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("INSERT INTO tbInvoice (customer_id, belegdatum, printed, summeBrutto, summeNetto, summeMwst, systemst" +
                "atus_id, invoiceNumber, createdAt, editedAt) VALUES (@CustomerId, @Belegdatum, @Printed, @Brutto, @Netto, @MWST, @Systemstatus, @invoiceNumber,now(),now())");
                    tmpCommand.Parameters.AddWithValue("@CustomerId", this.customerId);
                    tmpCommand.Parameters.AddWithValue("@Belegdatum", DateTime.Now);
                    tmpCommand.Parameters.AddWithValue("@Brutto", this.sumBrutto);
                    tmpCommand.Parameters.AddWithValue("@Netto", this.sumNetto);
                    tmpCommand.Parameters.AddWithValue("@MWST", this.sumMwst);
                    tmpCommand.Parameters.AddWithValue("@Systemstatus", 1);
                    tmpCommand.Parameters.AddWithValue("@invoiceNumber", this.invoiceNumber);
                    tmpCommand.Parameters.AddWithValue("@Printed", this.printed);
                    tmpCommand.Connection = tmpConnection;
                    tmpCommand.Connection.Open();
                    if (tmpCommand.ExecuteNonQuery() == 1)
                        result = true;
                    else
                        result = false;
                }
                if (result)
                {
                    using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                    {
                        MySqlCommand tmpCommand = new MySqlCommand("SELECT * FROM tbInvoice WHERE customer_Id = @CustomerId AND printed = @printed AND summeBrutto = @Brutto AND summeNetto = @Netto and summeMwst = @MWST AND invoiceNumber = @invoiceNumber");
                        tmpCommand.Parameters.AddWithValue("@CustomerId", this.customerId);
                        tmpCommand.Parameters.AddWithValue("@Date", this.date);
                        tmpCommand.Parameters.AddWithValue("@printed", this.printed);
                        tmpCommand.Parameters.AddWithValue("@Brutto", this.sumBrutto);
                        tmpCommand.Parameters.AddWithValue("@Netto", this.sumNetto);
                        tmpCommand.Parameters.AddWithValue("@MWST", this.sumMwst);
                        tmpCommand.Parameters.AddWithValue("@invoiceNumber", this.invoiceNumber);
                        tmpCommand.Connection = tmpConnection;
                        tmpCommand.Connection.Open();
                        using (MySqlDataReader tmpReader = tmpCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (tmpReader.Read())
                            {
                                this.id = Convert.ToInt32(tmpReader["id"]);
                            }
                        }
                    }

                    foreach (clsInvoicePosition pos in this.invoicePositions)
                    {
                        pos.SetInvoiceId(this.id);
                        if (!pos.Save())
                            result = false;
                    }
                }
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.DevBuild)
                    Debug.WriteLine("# " + DateTime.Now + "clsInvoice - Failed to execute SQL: " + ex);
                else
                    MessageBox.Show("Fehler während der Datenbankabfrage.\r\nFehler bei: clsInvoice - Save", "Datenbank Fehler", MessageBoxButtons.OK);
                result = false;
            }
            return result;
        }

        public static int GetId(clsInvoice pInvoice)
        {
            int tmpResult = 1;
            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("SELECT ID FROM tbInvoice WHERE customerId = @CustomerId AND date = @Date AND printed = @printed AND sumBrutto = @Brutto AND sumNetto = @Netto and sumMwst = @MWST AND invoiceNumber = @invoiceNumber");
                    tmpCommand.Parameters.AddWithValue("@CustomerId", pInvoice.customerId);
                    tmpCommand.Parameters.AddWithValue("@Date", pInvoice.date);
                    tmpCommand.Parameters.AddWithValue("@printed", pInvoice.printed);
                    tmpCommand.Parameters.AddWithValue("@Brutto", pInvoice.sumBrutto);
                    tmpCommand.Parameters.AddWithValue("@Netto", pInvoice.sumNetto);
                    tmpCommand.Parameters.AddWithValue("@MWST", pInvoice.sumMwst);
                    tmpCommand.Parameters.AddWithValue("@invoiceNumber", pInvoice.invoiceNumber);
                    tmpCommand.Connection = tmpConnection;
                    tmpCommand.Connection.Open();
                    using (MySqlDataReader tmpReader = tmpCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (tmpReader.Read())
                        {
                            tmpResult = Convert.ToInt32(tmpReader["Id"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.DevBuild)
                    Debug.WriteLine("# " + DateTime.Now + "clsInvoice - Failed to execute SQL: " + ex);
                else
                    MessageBox.Show("Fehler während der Datenbankabfrage.\r\nFehler bei: clsInvoice - GetId", "Datenbank Fehler", MessageBoxButtons.OK);
                return 0;
            }
            return tmpResult;
        }

        public static List<clsInvoice> GetDbList()
        {
            List<clsInvoice> tmpResult = new List<clsInvoice>();
            try
            {
                using (MySqlConnection tmpCon = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCom = new MySqlCommand("SELECT * FROM TBINVOICE WHERE Systemstaus_Id <> 11");
                    tmpCon.Open();
                    tmpCom.Connection = tmpCon;
                    using (MySqlDataReader tmpReader = tmpCom.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (tmpReader.Read())
                        {
                            clsInvoice tmpEntry = new clsInvoice()
                            {
                                Id = Convert.ToInt32(tmpReader["Id"]),
                                customerId = Convert.ToInt32(tmpReader["customerId"]),
                                date = Convert.ToDateTime(tmpReader["date"]),
                                invoiceNumber = tmpReader["invoiceNumber"].ToString(),
                                printed = Convert.ToBoolean(tmpReader["printed"]),
                                sumBrutto = Convert.ToDouble(tmpReader["sumBrutto"]),
                                sumNetto = Convert.ToDouble(tmpReader["sumNetto"]),
                                sumMwst = Convert.ToDouble(tmpReader["sumMwst"]),
                            };
                            tmpResult.Add(tmpEntry);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.DevBuild)
                    Debug.WriteLine("# " + DateTime.Now + "clsInvoice - Failed to execute SQL: " + ex);
                else
                    MessageBox.Show("Fehler während der Datenbankabfrage.\r\nFehler bei: clsInvoice - GetDbList", "Datenbank Fehler", MessageBoxButtons.OK);
                return null;
            }
            return tmpResult;
        }
    }
}

