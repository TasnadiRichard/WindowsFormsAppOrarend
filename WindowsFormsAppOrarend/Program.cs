using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsAppLogin;

namespace WindowsFormsAppOrarend
{
    internal static class Program
    {
        public static FormModositas formModositas = null;
        public static FormOrak formOrak = null;
        public static FormRegisztracio formRegisztracio = null;
        public static FormTanarbelepes formTanarbelepes = null;
        public static int UserID;
        public static Database db = new Database();
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formModositas = new FormModositas();
            formOrak = new FormOrak();
            formRegisztracio = new FormRegisztracio();
            formTanarbelepes = new FormTanarbelepes();
            Application.Run(formOrak);
        }
       
    }
}
