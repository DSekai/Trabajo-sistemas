using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_DiseñoSistemas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            //Application.Run(new Form_principal());

            // Realizo esto para que ningún form sea el principal 
            Login l = new Login();
            l.Show();
            Application.Run(); //Aqui borre lo que esta entre parentesis.




        }
    }
}
