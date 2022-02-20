namespace DocumentManagementSystem
{
    using System;
    using System.Reflection;
    using System.Windows.Forms;
    using Utilities;
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
            new IocContainerBootstrap().Setup(Assembly.GetExecutingAssembly());
            new LoggerBootstrap().Setup();
            Application.Run(DocumentManagementForm.GetInstance());
        }
    }
}
