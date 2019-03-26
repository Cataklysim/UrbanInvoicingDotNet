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
    public class clsCustomer : clsDatabaseObject
    {

        public int id { get; set; }
        public new String name { get; set; }
        public String lastName { get; set; }
        public String plz { get; set; }
        public String street { get; set; }
        public String city { get; set; }
        public String land { get; set; }
        public String telefone { get; set; }
        public String telefax { get; set; }
        public String email { get; set; }
        public String comment { get; set; }
        public bool useOtherAdress { get; set; }
        public String invoiceName { get; set; }
        public String invoiceLastName { get; set; }
        public String invoicePlz { get; set; }
        public String invoiceStreet { get; set; }
        public String invoiceCity { get; set; }
        public String invoiceLand { get; set; }
        public String invoiceTelefone { get; set; }
        public String invoiceTelefax { get; set; }
        public String invoiceEmail { get; set; }
        public String invoiceComment { get; set; }
        public bool isCompany { get; set; }
        public int systemstatus_id { get; set; }

        public clsCustomer()
        { }

        public static List<clsCustomer> GetCustomerFromDB(bool pIsCompany = false, bool pIsCustomer = false)
        {
            List<clsCustomer> tmpResult = new List<clsCustomer>();
            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    String tmpAditionalWhere = String.Empty;
                    if (pIsCompany  && !pIsCustomer)
                    {
                        tmpAditionalWhere += "AND isCompany = 1 ";
                    } else if (!pIsCompany && pIsCustomer)
                    {
                        tmpAditionalWhere += "AND isCustomer = 1 ";
                    } else if (pIsCompany && pIsCustomer)
                    {
                        tmpAditionalWhere += " AND (isCompany = 1 OR isCustomer = 1) ";
                    }
                    MySqlCommand tmpCommand = new MySqlCommand("SELECT * FROM tbCustomer WHERE systemstatus_id = 1 "+tmpAditionalWhere+"ORDER BY name");
                    tmpCommand.Connection = tmpConnection;
                    tmpCommand.Connection.Open();
                    using (MySqlDataReader tmpReader = tmpCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (tmpReader.Read())
                        {
                            clsCustomer customer = new clsCustomer();
                            if (tmpReader["id"] != DBNull.Value)
                                customer.id = Convert.ToInt32(tmpReader["id"]);
                            if (tmpReader["name"] != DBNull.Value)
                                customer.name = tmpReader["name"].ToString();
                            if (tmpReader["lastName"] != DBNull.Value)
                                customer.lastName = tmpReader["lastName"].ToString();
                            if (tmpReader["plz"] != DBNull.Value)
                                customer.plz = tmpReader["plz"].ToString();
                            if (tmpReader["street"] != DBNull.Value)
                                customer.street = tmpReader["street"].ToString();
                            if (tmpReader["city"] != DBNull.Value)
                                customer.city = tmpReader["city"].ToString();
                            if (tmpReader["land"] != DBNull.Value)
                                customer.land = tmpReader["land"].ToString();
                            if (tmpReader["telefone"] != DBNull.Value)
                                customer.telefone = tmpReader["telefone"].ToString();
                            if (tmpReader["telefax"] != DBNull.Value)
                                customer.telefax = tmpReader["telefax"].ToString();
                            if (tmpReader["email"] != DBNull.Value)
                                customer.email = tmpReader["email"].ToString();
                            if (tmpReader["comment"] != DBNull.Value)
                                customer.comment = tmpReader["comment"].ToString();
                            if (tmpReader["useOtherAdress"] != DBNull.Value)
                                customer.useOtherAdress = Convert.ToBoolean(tmpReader["useOtherAdress"]);
                            if (tmpReader["invoiceName"] != DBNull.Value)
                                customer.invoiceName = tmpReader["invoiceName"].ToString();
                            if (tmpReader["invoiceLastName"] != DBNull.Value)
                                customer.invoiceLastName = tmpReader["invoiceLastName"].ToString();
                            if (tmpReader["invoicePlz"] != DBNull.Value)
                                customer.invoicePlz = tmpReader["invoicePlz"].ToString();
                            if (tmpReader["invoiceStreet"] != DBNull.Value)
                                customer.invoiceStreet = tmpReader["invoiceStreet"].ToString();
                            if (tmpReader["invoiceCity"] != DBNull.Value)
                                customer.invoiceCity = tmpReader["invoiceCity"].ToString();
                            if (tmpReader["invoiceLand"] != DBNull.Value)
                                customer.invoiceLand = tmpReader["invoiceLand"].ToString();
                            if (tmpReader["invoiceTelefone"] != DBNull.Value)
                                customer.invoiceTelefone = tmpReader["invoiceTelefone"].ToString();
                            if (tmpReader["invoiceTelefax"] != DBNull.Value)
                                customer.invoiceTelefax = tmpReader["invoiceTelefax"].ToString();
                            if (tmpReader["invoiceEmail"] != DBNull.Value)
                                customer.invoiceEmail = tmpReader["invoiceEmail"].ToString();
                            if (tmpReader["invoiceComment"] != DBNull.Value)
                                customer.invoiceComment = tmpReader["invoiceComment"].ToString();
                            if (tmpReader["isCompany"] != DBNull.Value)
                                customer.isCompany = Convert.ToBoolean(tmpReader["isCompany"]);
                            if (tmpReader["systemstatus_id"] != DBNull.Value)
                                customer.systemstatus_id = Convert.ToInt32(tmpReader["systemstatus_id"]);
                            tmpResult.Add(customer);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.DevBuild)
                    Debug.WriteLine("# " + DateTime.Now + "clsCustomer - Failed to execute SQL: " + ex);
                else
                    MessageBox.Show("Fehler während der Datenbankabfrage.\r\nFehler bei: clsCustomer - GetCustomerFromDB", "Datenbank Fehler", MessageBoxButtons.OK);
                return null;
            }
            return tmpResult;
        }

        public static int GetId(String pName)
        {
            int tmpResult = 0;
            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("SELECT id FROM tbCustomer WHERE systemstatus_id = 1 AND isCompany = 1 AND name LIKE @Name");
                    tmpCommand.Parameters.AddWithValue("@Name", pName);
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
                    Debug.WriteLine("# " + DateTime.Now + "clsCustomer - Failed to execute SQL: " + ex);
                else
                    MessageBox.Show("Fehler während der Datenbankabfrage.\r\nFehler bei: clsCustomer - GetId", "Datenbank Fehler", MessageBoxButtons.OK);
                return tmpResult;
            }
            return tmpResult;
        }

        public void DeleteOnDb()
        {
            using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                MySqlCommand tmpCommand = new MySqlCommand("UPDATE tbCustomer SET systemstatus_id = 11 WHERE id = @id", tmpConnection);
                if (this.id == 0)
                {
                    this.id = clsCustomer.GetId(this.name);
                }
                tmpCommand.Parameters.AddWithValue("@id", this.id);
                tmpCommand.Connection.Open();
                tmpCommand.ExecuteNonQuery();
                tmpCommand.Connection.Close();
            }
        }

        public static bool NameOnDb(string pName)
        {
            bool tmpResult = false;
            using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                MySqlCommand tmpCommand = new MySqlCommand("SELECT COUNT(Id) AS Result FROM tbCustomer WHERE name = @name", tmpConnection);
                tmpCommand.Parameters.AddWithValue("@name", pName);
                tmpCommand.Connection.Open();

                using (MySqlDataReader tmpReader = tmpCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                {
                    while (tmpReader.Read())
                    {
                        if (tmpReader["Result"] != DBNull.Value)
                        {
                            int tmp = Convert.ToInt32(tmpReader["Result"]);
                            if (tmp > 1)
                                tmpResult = true;
                        }
                    }
                }

            }
            return tmpResult;
        }

        public override bool Save()
        {
            bool tmpResult = false;
            using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                if (this.id > 0)
                {
                    MySqlCommand tmpCommand = new MySqlCommand("UPDATE tbCustomer SET name = @name ,lastName = @lastName , plz = @plz ,street = @street , city = @city , land = @land , telefone = @telefone , telefax = @telefax , email = @email , comment = @comment , useOtherAdress = @useOtherAdress , invoiceName =@invoiceName ,invoiceLastName = @invoiceLastName , invoicePlz = @invoicePlz , invoiceStreet = @invoiceStreet , invoiceCity = @invoiceCity , invoiceLand = @invoiceLand , invoiceTelefone = @invoiceTelefone , invoiceTelefax = @invoiceTelefax , invoiceEmail = @invoiceEmail , invoiceComment = @invoiceComment, systemstatus_id = 1, isCompany = @isCompany WHERE id=@id", tmpConnection);
                    tmpCommand.Parameters.AddWithValue("@name", this.name);
                    tmpCommand.Parameters.AddWithValue("@lastName", this.lastName);
                    tmpCommand.Parameters.AddWithValue("@plz", this.plz);
                    tmpCommand.Parameters.AddWithValue("@street", this.street);
                    tmpCommand.Parameters.AddWithValue("@city", this.city);
                    tmpCommand.Parameters.AddWithValue("@land", this.land);
                    tmpCommand.Parameters.AddWithValue("@telefone", this.telefone);
                    tmpCommand.Parameters.AddWithValue("@telefax", this.telefax);
                    tmpCommand.Parameters.AddWithValue("@email", this.email);
                    tmpCommand.Parameters.AddWithValue("@comment", this.comment);
                    tmpCommand.Parameters.AddWithValue("@useOtherAdress", this.useOtherAdress);
                    tmpCommand.Parameters.AddWithValue("@invoiceName", this.invoiceName);
                    tmpCommand.Parameters.AddWithValue("@invoiceLastName", this.invoiceLastName);
                    tmpCommand.Parameters.AddWithValue("@invoicePlz", this.invoicePlz);
                    tmpCommand.Parameters.AddWithValue("@invoiceStreet", this.invoiceStreet);
                    tmpCommand.Parameters.AddWithValue("@invoiceCity", this.invoiceCity);
                    tmpCommand.Parameters.AddWithValue("@invoiceLand", this.invoiceLand);
                    tmpCommand.Parameters.AddWithValue("@invoiceTelefone", this.invoiceTelefone);
                    tmpCommand.Parameters.AddWithValue("@invoiceTelefax", this.invoiceTelefax);
                    tmpCommand.Parameters.AddWithValue("@invoiceEmail", this.invoiceEmail);
                    tmpCommand.Parameters.AddWithValue("@invoiceComment", this.invoiceComment);
                    tmpCommand.Parameters.AddWithValue("@isCompany", this.isCompany);
                    tmpCommand.Parameters.AddWithValue("@id", this.id);
                    tmpCommand.Connection.Open();
                    tmpCommand.ExecuteNonQuery();
                    tmpResult = true;
                    tmpCommand.Connection.Close();
                }
                else
                {
                    MySqlCommand tmpCommand = new MySqlCommand("INSERT INTO tbCustomer (name , lastName , plz , street , city , land , telefone , telefax , email , comment , useOtherAdress , invoiceName , invoiceLastName , invoicePlz , invoiceStreet , invoiceCity , invoiceLand , invoiceTelefone , invoiceTelefax , invoiceEmail , invoiceComment, systemstatus_id, isCompany) " + Environment.NewLine +
                        "VALUES (@name , @lastName , @plz , @street , @city , @land , @telefone , @telefax , @email , @comment , @useOtherAdress , @invoiceName , @invoiceLastName , @invoicePlz , @invoiceStreet , @invoiceCity , @invoiceLand , @invoiceTelefone , @invoiceTelefax , @invoiceEmail , @invoiceComment, 1, @isCompany)", tmpConnection);
                    tmpCommand.Parameters.AddWithValue("@name", this.name);
                    tmpCommand.Parameters.AddWithValue("@lastName", this.lastName);
                    tmpCommand.Parameters.AddWithValue("@plz", this.plz);
                    tmpCommand.Parameters.AddWithValue("@street", this.street);
                    tmpCommand.Parameters.AddWithValue("@city", this.city);
                    tmpCommand.Parameters.AddWithValue("@land", this.land);
                    tmpCommand.Parameters.AddWithValue("@telefone", this.telefone);
                    tmpCommand.Parameters.AddWithValue("@telefax", this.telefax);
                    tmpCommand.Parameters.AddWithValue("@email", this.email);
                    tmpCommand.Parameters.AddWithValue("@comment", this.comment);
                    tmpCommand.Parameters.AddWithValue("@useOtherAdress", this.useOtherAdress);
                    tmpCommand.Parameters.AddWithValue("@invoiceName", this.invoiceName);
                    tmpCommand.Parameters.AddWithValue("@invoiceLastName", this.invoiceLastName);
                    tmpCommand.Parameters.AddWithValue("@invoicePlz", this.invoicePlz);
                    tmpCommand.Parameters.AddWithValue("@invoiceStreet", this.invoiceStreet);
                    tmpCommand.Parameters.AddWithValue("@invoiceCity", this.invoiceCity);
                    tmpCommand.Parameters.AddWithValue("@invoiceLand", this.invoiceLand);
                    tmpCommand.Parameters.AddWithValue("@invoiceTelefone", this.invoiceTelefone);
                    tmpCommand.Parameters.AddWithValue("@invoiceTelefax", this.invoiceTelefax);
                    tmpCommand.Parameters.AddWithValue("@invoiceEmail", this.invoiceEmail);
                    tmpCommand.Parameters.AddWithValue("@invoiceComment", this.invoiceComment);
                    tmpCommand.Parameters.AddWithValue("@isCompany", this.isCompany);
                    tmpCommand.Connection.Open();
                    if (tmpCommand.ExecuteNonQuery() > 0)
                        tmpResult = true;
                    tmpCommand.Connection.Close();
                }
            }
            return tmpResult;
        }


        public override void Load()
        {

        }
    }
}
