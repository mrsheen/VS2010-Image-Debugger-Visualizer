using System.Drawing;
using System.Windows.Forms;
using System;

namespace DebuggerVisualizers.ImageVisualizer
{
    public partial class FrmImage : Form
    {
        public FrmImage()
        {
            InitializeComponent();



            // Shift-Ctrl-Alt Escape will exit the play loop
            WIN32.RegisterHotKey(Handle, 100, WIN32.KeyModifiers.None, Keys.Escape);

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


        // Set up hotkeys: we need one to be able to quit the loop because 
        // while the bot is running the mouse is hijacked
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;

            switch (m.Msg)
            {
                case WM_HOTKEY:
                    Close();
                    break;
            }

            base.WndProc(ref m);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Bitmap files(*.BMP)|*.BMP";
            //dialog.InitialDirectory = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Picture.Save(dialog.FileName);
                }
                catch (Exception)
                {
                }
            }
        }


    }
}
