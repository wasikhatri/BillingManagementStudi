using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingManagementStudi
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.GetInstance().Close();
        }

        private void menu_Create_Click(object sender, EventArgs e)
        {
            CreateBill createbill = new CreateBill();
            createbill.ShowDialog();
        }
    }
}
