using System.Drawing;
using System.Windows.Forms;

namespace DebuggerVisualizers.ImageVisualizer
{
    public partial class FrmImage : Form
    {
        public FrmImage()
        {
            InitializeComponent();
        }

        public Image Picture 
        {
            get { return PicViewer.Image; }
            set
            {
                PicViewer.Image = value;
                PicViewer.SizeMode = PictureBoxSizeMode.Zoom;
                LoadImageInformation(value);
            }
        }

        private void LoadImageInformation(Image image)
        {
            if (image == null) return;

            //get native resolution information
            lblNativeResolutionInfo.Text = string.Format("{0}x{1}", image.Width, image.Height);
            //get image type
            lblImageTypeInfo.Text = image.GetType().Name;
        }

    }
}
