using System;
using System.Windows.Forms;

namespace serverSocket
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Run program
            //Run styles
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Run Application
            Application.Run(new Server());
            #endregion
        }
    }
}
