using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

            CurrencyForm mainView = new CurrencyForm();
            mainView.Visible = false;

            CurrencyConverterController controller = CurrencyConverterController.Create(mainView);
            controller.LoadView();
            Application.Run(mainView);
        }
    }
}
