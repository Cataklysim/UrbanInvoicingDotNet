using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanInvoicing.Classes
{
    public class clsArticle : clsDatabaseObject
    {

        public int id { get; set; }

        public String name { get; set; }

        public double vatRate { get; set; }

        public double price { get; set; }

        public double squareMeter { get; set; }
        
        public void clsArticel()
        {

        }

        public static List<String> GetArticlesFromDB()
        {
            List<String> tmpResult = new List<String>();
            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("SELECT name FROM tbArtikel WHERE systemstatus_id = 1");
                    tmpCommand.Connection = tmpConnection;
                    tmpCommand.Connection.Open();
                    using (MySqlDataReader tmpReader = tmpCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (tmpReader.Read())
                        {
                            tmpResult.Add(tmpReader["name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("# " + DateTime.Now + "clsArticle - Failed to execute SQL: " + ex);
                return null;
            }
            return tmpResult;
        }

        public static int GetId(String pArticleName)
        {
            int tmpResult = 1;
            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("SELECT ID FROM tbArtikel WHERE Systemstatus_id = 1 AND name LIKE @Name");
                    tmpCommand.Parameters.AddWithValue("@Name", pArticleName);
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
                Debug.WriteLine("# " + DateTime.Now + "clsArticle - Failed to execute SQL: " + ex);
                return 0;
            }
            finally
            {
            }
            return tmpResult;
        }

        public static Double GetMwst(String pArticleName)
        {
            Double tmpResult = 0;
            try
            {

                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("SELECT mwstSatz FROM tbArtikel WHERE Systemstatus_id = 1 AND name LIKE @Name");
                    tmpCommand.Parameters.AddWithValue("@Name", pArticleName);
                    tmpCommand.Connection = tmpConnection;
                    tmpCommand.Connection.Open();
                    using (MySqlDataReader tmpReader = tmpCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (tmpReader.Read())
                        {
                            tmpResult = Convert.ToInt32(tmpReader["mwstSatz"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("# " + DateTime.Now + "clsArticle - Failed to execute SQL: " + ex);
                return 0;
            }
            return tmpResult;
        }

        public override bool Save() 
        {
            bool result = false;
            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("INSERT INTO tbArtikel (name, mwstSatz, systemstatus_id) VALUES (@Name, @MWST, @Systemstatus");
                    tmpCommand.Parameters.AddWithValue("@Name", this.name);
                    tmpCommand.Parameters.AddWithValue("@MWST", this.vatRate);
                    tmpCommand.Parameters.AddWithValue("@Systemstatus", 1);
                    tmpCommand.Connection = tmpConnection;
                    tmpCommand.Connection.Open();
                    if (tmpCommand.ExecuteNonQuery() == 1)
                        result = true;
                    else
                        result = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("# " + DateTime.Now + "clsArticle - Failed to execute SQL: " + ex);
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

