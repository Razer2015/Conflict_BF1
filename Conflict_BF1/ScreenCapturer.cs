using AForge.Video;
using FireAnt.Windows.Forms.Util;
using MorseCodeDecoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conflict_BF1
{
    public partial class ScreenCapturer : Form
    {
        public ScreenCapturer() {
            InitializeComponent();
        }

        private float X = 0;
        private float Y = 0;
        private float TopWidth = 0;
        private float BottomWidth = 0;
        private float Height = 0;

        /// <summary>
        /// Variables
        /// </summary>
        private Processing processes;
        private Stopwatch sw = new Stopwatch();
        ScreenCaptureStream ScreenStream = null;
        public delegate void Processing(ref Bitmap image);
        bool _capturing = false;

        private void btn_screenshot_Click(object sender, EventArgs e) {
            if (pBox_preview?.Image == null) {
                return;
            }
            pBox_preview.Image.Save($"Screenshot_{DateTime.Now.ToFileTime()}.png", ImageFormat.Png);
        }

        /// <summary>
        /// The crosshair which points to the point where the morse is taken from
        /// </summary>
        /// <param name="image"></param>
        private void DrawLine(ref Bitmap image) {
            Drawer.DrawOverlay(ref image, X, Y, TopWidth, BottomWidth, Height);
        }

        private void button1_Click(object sender, EventArgs e) {
            if (_capturing) {
                closeScreenSource();
                return;
            }

            processes += DrawLine;

            Rectangle screenArea = Rectangle.Empty;
            ScreenCapStart sc = new ScreenCapStart(false);
            if (sc.ShowDialog() == DialogResult.OK) {
                screenArea = sc.toreturn;

                // create screen capture video source
                ScreenStream = new ScreenCaptureStream(screenArea, 60);
                // set NewFrame event handler
                ScreenStream.NewFrame += new NewFrameEventHandler(Screen_NewFrame);
                // start the video source
                ScreenStream.Start();
                pBox_preview.SizeMode = PictureBoxSizeMode.StretchImage;
                button1.Text = "Stop Capturing";
                _capturing = true;
            }
        }

        #region Screen
        private void Screen_NewFrame(object sender, NewFrameEventArgs eventArgs) {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            processes?.Invoke(ref image);
            pBox_preview.Image = image;
            GC.Collect();
        }

        private void PC_S_FrameInterval(int frameinterval) {
            if (ScreenStream != null)
                ScreenStream.FrameInterval = frameinterval;
        }

        private void closeScreenSource() {
            if (ScreenStream != null) {
                if (ScreenStream.IsRunning) {
                    pBox_preview.SizeMode = PictureBoxSizeMode.Normal;
                    //this.pBox_preview.Image = global::MorseCodeDecoder.Properties.Resources.startup;
                    ScreenStream.SignalToStop();
                    ScreenStream = null;
                    processes = null;
                    button1.Text = "Start Capturing";
                    _capturing = false;
                }
            }
        }
        #endregion

        private void ScreenCapturer_FormClosed(object sender, FormClosedEventArgs e) {
            closeScreenSource();
        }

        private void nUD_x_ValueChanged(object sender, EventArgs e) {
            X = (float)nUD_x.Value;
        }

        private void nUD_y_ValueChanged(object sender, EventArgs e) {
            Y = (float)nUD_y.Value;
        }

        private void nUD_width_ValueChanged(object sender, EventArgs e) {
            TopWidth = (float)nUD_tWidth.Value;
        }

        private void nUD_bWidth_ValueChanged(object sender, EventArgs e) {
            BottomWidth = (float)nUD_bWidth.Value;
        }

        private void nUD_height_ValueChanged(object sender, EventArgs e) {
            Height = (float)nUD_height.Value;
        }

        private void uxHotKey_HotKeyPressed(object sender, EventArgs e) {
            // get the hotkey reference
            HotKey hotKey = sender as HotKey;
            if (hotKey != null) {

                // force our window to the foreground
                //hotKey.ActivateWindow(Handle);
                btn_screenshot_Click(null, null);
            }
        }

        private void ScreenCapturer_Load(object sender, EventArgs e) {
            /* 
            * activate our hotkey.  in real life, this should be in a try/catch - since
            * it can (and will) throw an exception if the hotkey is already registred...
            * you can also not make this call - and set it in the ide, but I prefere to do it in code so that
            * i can catch the exception easier.  You can also change the hotkey of the component instance, by calling
            * recalling registerhotkey 
            * 
            */
            this.uxHotKey.RegisterHotkey(Modifiers.Control, Keys.F9);
        }
    }
}
