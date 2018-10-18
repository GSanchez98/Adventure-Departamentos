using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Departamentos
{
    static class Program
    {
        //  YOSSENY GIMENA SANCHEZ CABRERA   03181998-01690
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmOperacionesCRUD());
        }
    }
}
