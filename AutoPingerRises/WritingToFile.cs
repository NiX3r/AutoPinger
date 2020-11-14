using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPingerRises
{
    public class WritingToFile
    {

        public static void writeToFile(string sText)
        {

            StreamWriter sw = new StreamWriter(Program.pathToFile, true);

            sw.WriteLine($"{DateTime.Now}{sText}");
            sw.Flush();

            sw.Close();

        }

    }
}
