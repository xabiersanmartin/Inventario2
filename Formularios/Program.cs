using GestionDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    
    static class Program
    {
        public static Datos gestor;
        public static Form frmPrincipal;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string msg = "";
            gestor = new Datos(out msg);
            if (msg != "")
            {
                MessageBox.Show(msg);
                return;
            }
            frmPrincipal = new FrmPrincipal();
            Application.Run(frmPrincipal);
        }
    }
}
