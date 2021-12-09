using System;
using System.Windows.Forms;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;

namespace RiotAPI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
