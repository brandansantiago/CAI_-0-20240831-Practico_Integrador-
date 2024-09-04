using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            MessageBox.Show("Hola Tomi");

            MessageBox.Show("Hola Santi 2024/09/04");

            MessageBox.Show("Nuevo commit de prueba 04/09 19:32");
        }
    }
}

