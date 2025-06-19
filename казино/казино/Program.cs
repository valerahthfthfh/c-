using System;
using System.Windows.Forms;

namespace SlotMachineMVC
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Controllers.SlotMachineController();
        }
    }
}