using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                "atus_id) VALUES (@CustomerId, @Belegdatum, @Printed, @Brutto, @Netto, @MWST, @Systemstatus)");
                    tmpCommand.Parameters.AddWithValue("@CustomerId", this.customerId);
                    tmpCommand.Parameters.AddWithValue("@Belegdatum", DateTime.Now);
                    tmpCommand.Parameters.AddWithValue("@Brutto", this.sumBrutto);
                    tmpCommand.Parameters.AddWithValue("@Netto", this.sumNetto);
                    tmpCommand.Parameters.AddWithValue("@MWST", this.sumMwst);
                    tmpCommand.Parameters.AddWithValue("@Systemstatus", 1);
                    tmpCommand.Connection = tmpConnection;
                    tmpCommand.Connection.Open();
                    if (tmpCommand.ExecuteNonQuery() == 1)
                        result = true;
                    else
                        result = false;
                }
                foreach (clsInvoicePosition pos in this.invoicePositions)
                {
                    pos.SetInvoiceId(this.id);
                    if (!pos.Save())
                        result = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("# " + DateTime.Now + "clsInvoice - Failed to execute SQL: " + ex);
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
                    MySqlCommand tmpCommand = new MySqlCommand("SELECT ID FROM tbInvoice WHERE customerId = @CustomerId AND date = @Date AND printed = @printed AND sumBrutto = @Brutto AND sumNetto = @Netto and sumMwst = @MWST");
                    tmpCommand.Parameters.AddWithValue("@CustomerId", pInvoice.customerId);
                    tmpCommand.Parameters.AddWithValue("@Date", pInvoice.date);
                    tmpCommand.Parameters.AddWithValue("@printed", pInvoice.printed);
                    tmpCommand.Parameters.AddWithValue("@Brutto", pInvoice.sumBrutto);
                    tmpCommand.Parameters.AddWithValue("@Netto", pInvoice.sumNetto);
                    tmpCommand.Parameters.AddWithValue("@MWST", pInvoice.sumMwst);
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
                Debug.WriteLine("# " + DateTime.Now + "clsInvoice - Failed to execute SQL: " + ex);
                return 0;
            }
            return tmpResult;
        }
    }
}

