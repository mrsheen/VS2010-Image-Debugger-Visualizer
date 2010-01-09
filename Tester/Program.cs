using System;
using System.Diagnostics;
using System.Xml;
using Tester.Properties;

namespace Tester
{
    class Program
    {
        static void Main()
        {
            var xmlDoc = new XmlDocument();
            var textReader = new XmlTextReader(new System.IO.StringReader(Resources.Example));

            xmlDoc.Load(textReader);
            Debugger.Break();   //look at the xmlDoc and use the visualizer (magnifying glass)


            var img = Resources.logo_baseline;
            Debugger.Break();   //look at the img variable and use the visualizer (magnifying glass)

            Console.WriteLine("Image with resolution '" + img.Width + "x" + img.Height + "' loaded...");
            Console.ReadLine();
        }
    }
}
