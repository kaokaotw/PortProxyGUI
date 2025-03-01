using PortProxyGUI.Data;
using System;
using System.Windows.Forms;

namespace PortProxyGUI
{
    static class Program
    {
        public static readonly ApplicationDbScope SqliteDbScope = ApplicationDbScope.UseDefault();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqliteDbScope.Migrate();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PortProxyGUI());
        }
    }
}
