﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrbanInvoicing.Classes
{
    public class clsCustomer
    {

        public int id { get; set; }
        public String name { get; set; }
        public String lastName { get; set; }
        public String plz { get; set; }
        public String street { get; set; }
        public String city { get; set; }
        public String land { get; set; }
        public String telefone { get; set; }
        public String telefax { get; set; }
        public String email { get; set; }
        public String comment { get; set; }
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
        private bool isCompany { get; set; }

        public clsCustomer()
        { }

        public static List<clsCustomer> GetCustomerFromDB()
        {
            List<clsCustomer> tmpResult = new List<clsCustomer>();
            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("SELECT * FROM tbCustomer WHERE systemstatus_id = 1 AND isCompany = 1");
                    tmpCommand.Connection = tmpConnection;
                    tmpCommand.Connection.Open();
                    using (MySqlDataReader tmpReader = tmpCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (tmpReader.Read())
                        {
                            clsCustomer customer = new clsCustomer();
                            customer.id = Convert.ToInt32(tmpReader["id"]);
                            customer.name = tmpReader["name"].ToString();
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
    }
}
