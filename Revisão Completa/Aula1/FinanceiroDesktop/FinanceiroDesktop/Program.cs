using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FinanceiroDesktop
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin login = new frmLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
            }
            
        }
    }
}
