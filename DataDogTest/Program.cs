using System;
using System.Windows.Forms;
using Datadog.Trace;

namespace DataDogTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            Tracer tracer = Tracer.Create(isDebugEnabled: true);

            // optional: set the new tracer as the new default/global tracer
            Tracer.Instance = tracer;
            */
            if (Utilidades.Configuracion.CadenaConexion == "Set here your DB connection string")
            {
                MessageBox.Show("Before start the program you should put your DB connection string in 'Configuracion' class of the 'Utilidades' project. And next you should creat de table View_ClientesCombo with Codigo and Nombre string columns");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
