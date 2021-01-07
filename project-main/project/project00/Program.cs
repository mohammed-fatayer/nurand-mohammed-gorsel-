using System;
using System.Windows.Forms;

namespace project00
{
    static class Program
    {



        [STAThread]

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new messageform());


        }

    }


}


