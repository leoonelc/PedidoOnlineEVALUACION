using System;
using System.Windows.Forms;
using PedidoOnline.Views;

namespace PedidoOnline
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicaci�n.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Puedes cambiar esto para que inicie con otro formulario si deseas.
            Application.Run(new FrmMenu());
        }
    }
}
