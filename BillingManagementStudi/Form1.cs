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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(Program.ConnectionString);
        SqlCommand command = null;
        SqlDataReader reader = null;
        ResetPassword reset = null;
        private void btn_login_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select password, flag from users where userName = '" + txt_username.Text + "'";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            bool flag = false;
            string password= null;
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    password = reader["password"].ToString();
                    flag = Convert.ToBoolean(reader["flag"]);
                }
                if (password.Equals(txt_password.Text))
                {
                    if (flag == false)
                    {
                        reset = new ResetPassword(txt_username.Text);
                        reset.Show();
                        txt_username.Text="";
                        txt_password.Text="";
                        txt_username.Text = "";
                        txt_password.Text = "";
                        txt_username.Text = "";
                        txt_password.Text = "";
                    }
                    else
                    {
                        Main main = new Main();
                        this.Hide();
                        main.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Password!!");
                }
            }
            else
            {
                MessageBox.Show("Incorrect User Name");
            }
            connection.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }
    }
}
