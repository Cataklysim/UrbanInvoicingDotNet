using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanInvoicing.Classes
{
    public abstract class clsDatabaseObject : clsSystemstatus
    {
        DateTime addedAt;
        DateTime editedAt;

        clsSystemstatus systemstatus;

        public abstract bool Save();
        public abstract void Load();

        protected void Delete()
        {
            this.systemstatus = new clsSystemstatus(clsSystemstatus.enmSystemstatus.Deleted);
            this.editedAt = DateTime.Now;
        }

        public static object GetValue(string pSqlCommand, string pFieldName)
        {
            object tmpResult = null;
            try
            {
                using (MySqlConnection tmpCon = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    using (var tmpCmd = new MySqlCommand(pSqlCommand, tmpCon))
                    {
                        tmpCon.Open();
                        using (var tmpReader = tmpCmd.ExecuteReader())
                        {
                            while (tmpReader.Read())
                            {
                                tmpResult = tmpReader[pFieldName];
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message.ToString(), "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return tmpResult;
        }

        public static System.Collections.IList GetValueList(string pSqlCommand, string pFieldName) 
        {
            List<object> tmpResult = new List<object>();
            try
            {
                String tmpComStr = pSqlCommand;
                using (MySqlConnection tmpCon = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    using (var tmpCmd = new MySqlCommand(tmpComStr, tmpCon))
                    {
                        tmpCon.Open();
                        using (var tmpReader = tmpCmd.ExecuteReader())
                        {
                            while (tmpReader.Read())
                            {
                                tmpResult.Add(tmpReader["name"]);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message.ToString(), "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return tmpResult;
        }
    }
}