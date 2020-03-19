using Logbook.Model;
using Logbook.View;
using System;
using System.Windows.Forms;

namespace Logbook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new Form1();
            var presenter = new MainPresenter(view);
            Application.Run(view);
        }
    }
}
