using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.VisualBasic;

namespace FingerPrintAttandanceSystem
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdAdminLogin_Click(object sender, EventArgs e)
        {
            if (TxtAdminUserName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtAdminUserName.Focus();
                return;
            }
            if (TxtAdminPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtAdminPassword.Focus();
                return;
            }

            // create a new database connection:
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;");

            // open the connection:
            //SQLiteCommand 
            sqlite_conn.Open();

            string sql = "SELECT * FROM users WHERE username='"+TxtAdminUserName.Text.Trim()+ "' AND password='"+ TxtAdminPassword.Text + "'";
            SQLiteCommand command = new SQLiteCommand(sql, sqlite_conn);
            SQLiteDataReader reader = command.ExecuteReader();
            var count = 0;
            var name = "";
            while (reader.Read())
            {
                count = count + 1;
                name = (string)reader["name"];
                Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["email"]);
            }
            if (count == 1)
            {
                MessageBox.Show("Sukses Login Name: " + name, "Sukses Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else if (count == 0)
            {
                MessageBox.Show("GAGAL Login", "GAGAL Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            sqlite_conn.Close();
            
        }
    }
}
