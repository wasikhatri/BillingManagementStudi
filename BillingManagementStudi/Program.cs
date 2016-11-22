using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingManagementStudi
{
    static class Program
    {
        public static string ConnectionString { get;set; }
        private static LoginForm _login;

        public static LoginForm GetInstance()
        {
            if (_login == null)
                _login = new LoginForm();
            return _login;
        }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectionString = "Data Source=DESKTOP-IOJSOFF;Initial Catalog=BMS;Integrated Security=True";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(GetInstance());
        }
    }
}
