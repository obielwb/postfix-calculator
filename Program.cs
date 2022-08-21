using System;
using System.Windows.Forms;

namespace CalculadoraPosfixa
{
    class Program
    {
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCalculadora());
        }
    }
}
