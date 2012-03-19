using System;
using System.Diagnostics;
using System.Xml;
using Tester.Properties;
using DebuggerVisualizers.ImageVisualizer;

namespace Tester
{

    class Program
    {
        [STAThread]
        static void Main()
        {
            var img = Resources.logo_baseline;
            ImageVisualizer.TestShowVisualizer(img);
            //Debugger.Break();   //look at the img variable and use the visualizer (magnifying glass)

            //Console.WriteLine("Image with resolution '" + img.Width + "x" + img.Height + "' loaded...");
            //Console.ReadLine();
        }
    }
}
