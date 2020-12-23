using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymulator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GameBrowserWindow window = new GameBrowserWindow();

            try
            {
                Application.Run(window);
            }
            catch
            {
                //window.SaveRomInfo();
                throw;
            }
        }
    }
}
