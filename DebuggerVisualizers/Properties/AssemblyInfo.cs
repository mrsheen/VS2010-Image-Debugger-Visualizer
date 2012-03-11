using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using DebuggerVisualizers.ImageVisualizer;

[assembly: AssemblyTitle("DebuggerVisualizers")]
[assembly: AssemblyDescription("Contains a custom image debugger visualizer for Visual Studio 2010.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Xavier Decoster")]
[assembly: AssemblyProduct("DebuggerVisualizers")]
[assembly: AssemblyCopyright("Copyright © Xavier Decoster 2010")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: Guid("82a53cde-ae84-4722-96e2-1973f6abcc56")]
[assembly: AssemblyVersion("1.0.1.0")]
[assembly: AssemblyFileVersion("1.0.1.0")]
[assembly: DebuggerVisualizer(typeof(ImageVisualizer), Target = typeof(Image), Description = "Image Debugger Visualizer")]