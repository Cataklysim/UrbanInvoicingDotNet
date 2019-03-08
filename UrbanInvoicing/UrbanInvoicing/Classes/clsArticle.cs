using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static List<clsArticle> GetArticlesFromDB()
        {
            List<clsArticle> tmpResult = new List<clsArticle>();
            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("SELECT id, name, mwstSatz FROM tbArtikel WHERE systemstatus_id = 1 ORDER BY name");
                    tmpCommand.Connection = tmpConnection;
                    tmpCommand.Connection.Open();
                    using (MySqlDataReader tmpReader = tmpCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (tmpReader.Read())
                        {
                            tmpResult.Add(new clsArticle() { name = tmpReader["name"].ToString(), vatRate = Convert.ToDouble(tmpReader["mwstSatz"].ToString()), id = Convert.ToInt32(tmpReader["id"].ToString())});
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.DevBuild)
                    Debug.WriteLine("# " + DateTime.Now + "clsArticle - Failed to execute SQL: " + ex);
                else
                    MessageBox.Show("Fehler während der Datenbankabfrage.\r\nFehler bei: clsAticle - GetArticlesFromDB", "Datenbank Fehler", MessageBoxButtons.OK);
                return null;
            }
            return tmpResult;
        }

        public static List<clsArticle> GetRoomsFromDB()
        {
            List<clsArticle> tmpResult = new List<clsArticle>();
            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("SELECT id, name, mwstSatz FROM tbArtikel WHERE systemstatus_id = 1 AND squareMeter IS NOT Null ORDER BY name");
                    tmpCommand.Connection = tmpConnection;
                    tmpCommand.Connection.Open();
                    using (MySqlDataReader tmpReader = tmpCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (tmpReader.Read())
                        {
                            tmpResult.Add(new clsArticle() { name = tmpReader["name"].ToString(), vatRate = Convert.ToDouble(tmpReader["mwstSatz"].ToString()), id = Convert.ToInt32(tmpReader["id"].ToString()) });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.DevBuild)
                    Debug.WriteLine("# " + DateTime.Now + "clsArticle - Failed to execute SQL: " + ex);
                else
                    MessageBox.Show("Fehler während der Datenbankabfrage.\r\nFehler bei: clsAticle - GetArticlesFromDB", "Datenbank Fehler", MessageBoxButtons.OK);
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
                if (Properties.Settings.Default.DevBuild)
                    Debug.WriteLine("# " + DateTime.Now + "clsArticle - Failed to execute SQL: " + ex);
                else
                    MessageBox.Show("Fehler während der Datenbankabfrage.\r\nFehler bei: clsAticle - GetId", "Datenbank Fehler", MessageBoxButtons.OK);

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
                if (Properties.Settings.Default.DevBuild)
                    Debug.WriteLine("# " + DateTime.Now + "clsArticle - Failed to execute SQL: " + ex);
                else
                    MessageBox.Show("Fehler während der Datenbankabfrage.\r\nFehler bei: clsAticle - GetMwst", "Datenbank Fehler", MessageBoxButtons.OK);
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
                    MySqlCommand tmpCommand = new MySqlCommand("INSERT INTO tbArtikel (name, mwstSatz, systemstatus_id) VALUES (@Name, @MWST, @Systemstatus)");
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
                if (Properties.Settings.Default.DevBuild)
                    Debug.WriteLine("# " + DateTime.Now + "clsArticle - Failed to execute SQL: " + ex);
                else
                    MessageBox.Show("Fehler während der Datenbankabfrage.\r\nFehler bei: clsAticle - Save", "Datenbank Fehler", MessageBoxButtons.OK);
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

