using OsuStreamHealthMeter.Classes;
using OsuStreamHealthMeter.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuStreamHealthMeter
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            using (var Monitor = new Monitor())
            {
                Monitor.Run();
            }
        }
    }
}
