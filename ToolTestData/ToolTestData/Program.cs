using ToolTestData.Models;
using ToolTestData.View.Menu;
using ToolTestData.View.NhapLieu.LuotSuIn;

namespace ToolTestData
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           

            Application.Run(new RibbonForm());
        }
    }
}