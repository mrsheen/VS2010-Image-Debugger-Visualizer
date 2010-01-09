using System;
using Debugger.Properties;
using DebuggerVisualizers.ImageVisualizer;

namespace Debugger
{
    class Program
    {
        static void Main()
        {
            var img = Resources.logo_baseline;
            var frm = new FrmImage {Picture = img};
            frm.Show();
            Console.WriteLine("form loaded...");
            Console.ReadLine();
        }
    }
}
