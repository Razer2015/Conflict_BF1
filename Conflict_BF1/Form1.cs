using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conflict_BF1
{
    public partial class Form1 : Form
    {
        Bitmap BaseImage { get; set; }
        Bitmap OverlayImage { get; set; }

        public Form1() {
            InitializeComponent();

            GenerateOverlay();
        }

        private void GenerateOverlay() {
            BaseImage = new Bitmap("3_manual.PNG");
            OverlayImage = Drawer.DrawOverlay();
            //overlayImage = Drawer.ResizeImage(overlayImage, overlayImage.Width - 50, overlayImage.Height - 50);
            pictureBox1.Image = Drawer.OverlapTwoImages(BaseImage, OverlayImage);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            ResetImage();
        }

        private void nUD_xPos_ValueChanged(object sender, EventArgs e) {
            ResetImage();
        }

        private void nUD_yPos_ValueChanged(object sender, EventArgs e) {
            ResetImage();
        }

        private void ResetImage() {
            var overlayImage = Drawer.ResizeImage(OverlayImage, OverlayImage.Width - (int)nUD_scale.Value, OverlayImage.Height - (int)nUD_scale.Value, (int)nUD_xPos.Value, (int)nUD_yPos.Value);
            pictureBox1.Image = Drawer.OverlapTwoImages(BaseImage, overlayImage);
        }
    }
}
