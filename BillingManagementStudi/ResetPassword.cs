using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingManagementStudi
{
    public partial class ResetPassword : Form
    {
        public string userName { get; set; }
        public ResetPassword(string username)
        {
            userName = username;
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            string password = txt_password.Text;
            string confirm = txt_confirm.Text;

            if(password.Equals(confirm))
            {
                string query = "update users set password = '" + password + "', flag = 1 where userName = '" + userName + "'";
                SqlConnection connection = new SqlConnection(Program.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Password updated successfully");
                connection.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Password not Matched..");
                MessageBox.Show("Commit Checking");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
