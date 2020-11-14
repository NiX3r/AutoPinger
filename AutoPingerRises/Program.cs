using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPingerRises
{
    static class Program
    {

        public static Boolean saveFile = false, isActive = false;
        public static string version = "4.0", pathToFile = "";
        public static string adress = "www.google.com";
        public static int waitMillis = 1000, minPingToSave = 0;

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI());
        }
    }
}
