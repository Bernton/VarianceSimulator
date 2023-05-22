using System;
using System.Windows.Forms;

namespace VarianceSimulator
{
    internal static class EntryPoint
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
