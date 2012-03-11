using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace DebuggerVisualizers.ImageVisualizer
{
    [DebuggerVisualizer(typeof(ImageVisualizer), typeof(VisualizerObjectSource),Target = typeof(Image),Description = "Image Visualizer")]
    public class ImageVisualizer : DialogDebuggerVisualizer
    {

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            var frm = new FrmImage();
            var img = objectProvider.GetObject() as Image;
            if (img == null) return;
            frm.Picture = img;
            windowService.ShowDialog(frm);
        }

        public static void TestShowVisualizer(object objectToVisualize)
        {
            VisualizerDevelopmentHost myHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(ImageVisualizer));
            myHost.ShowVisualizer();
        }

    }
}
