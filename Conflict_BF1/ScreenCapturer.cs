using AForge.Video;
using Conflict_BF1.Models;
using FireAnt.Windows.Forms.Util;
using MorseCodeDecoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conflict_BF1
{
    public partial class ScreenCapturer : Form
    {
        Results results;
        Help help;

        public ScreenCapturer() {
            InitializeComponent();

            CheckInformation();

            //SandBagIndexes.IndexesRefreshed += SandBagIndexes_IndexesRefreshed;
        }

        private void ShowResults() {
            if (results == null || results.IsDisposed) {
                results = new Results();
            }

            results.Show();
        }

        private void ShowHelp() {
            if (help == null || help.IsDisposed) {
                help = new Help();
            }

            help.Show();
        }

        private void SandBagIndexes_IndexesRefreshed() {
            Console.WriteLine($"Current index = {_currentIndex}");
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
        int _currentIndex = 0;
        string[] _stages = new string[] { "First", "Second", "Third", "Fourth", "Finished" };

        /// <summary>
        /// The overlay image
        /// </summary>
        /// <param name="image"></param>
        private void DrawLine(ref Bitmap image) {
            Drawer.DrawOverlay(ref image, X, Y, TopWidth, BottomWidth, Height);
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
                    captureStart.Text = "Start Capturing";
                    _capturing = false;
                }
            }
        }
        #endregion

        #region Events
        private void btn_help_Click(object sender, EventArgs e) {
            ShowHelp();
        }

        private void btn_results_Click(object sender, EventArgs e) {
            ShowResults();
        }

        private void captureStart_Click(object sender, EventArgs e) {
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
                captureStart.Text = "Stop Capturing";
                _capturing = true;
            }
        }

        private void btn_screenshot_Click(object sender, EventArgs e) {
            if (pBox_preview?.Image == null) {
                return;
            }
            pBox_preview.Image.Save($"Screenshot_{DateTime.Now.ToFileTime()}.png", ImageFormat.Png);
        }

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

        private void layoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {
            var panel = sender as TableLayoutPanel;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            var rectangle = e.CellBounds;
            using (var pen = new Pen(Color.Black, 2)) {
                pen.Alignment = PenAlignment.Center;
                pen.DashStyle = DashStyle.Solid;

                if (e.Row == (panel.RowCount - 1)) {
                    rectangle.Height -= 1;
                }

                if (e.Column == (panel.ColumnCount - 1)) {
                    rectangle.Width -= 1;
                }

                e.Graphics.DrawRectangle(pen, rectangle);
            }
        }

        private void previousBtn_Click(object sender, EventArgs e) {
            CheckButtons(false);
            _currentIndex -= 1;
            CheckButtons(true);
            CheckInformation();
        }

        private void nextBtn_Click(object sender, EventArgs e) {
            CheckButtons(false);
            _currentIndex += 1;
            CheckButtons(true);
            CheckInformation();
        }
        #endregion

        private void CheckInformation() {
            // Enable/Disable buttons
            previousBtn.Enabled = (_currentIndex <= 0) ? false : true;
            nextBtn.Enabled = (_currentIndex >= 4) ? false : true;
            layoutPanel_red.Visible = (_currentIndex >= 4) ? false : true;
            layoutPanel_orange.Visible = (_currentIndex >= 4) ? false : true;
            layoutPanel_yellow.Visible = (_currentIndex >= 4) ? false : true;
            layoutPanel_green.Visible = (_currentIndex >= 4) ? false : true;

            // Set correct title
            stage.Text = _stages[_currentIndex];
        }

        private void CheckButtons(bool set) {
            if (_currentIndex <= 3) {
                foreach (var pb in this.layoutPanel_red.Controls.OfType<CheckBox>()) {
                    var index = int.Parse(pb.Text.Substring(1)) - 1;
                    if (!set) {
                        //SandBagIndexes.Indexes[_currentIndex].Red[index] = pb.Checked;
                        SandBagIndexes.SetIndex(0, index, _currentIndex, pb.Checked);
                    }
                    else {
                        //pb.Checked = SandBagIndexes.Indexes[_currentIndex].Red[index];
                        pb.Checked = SandBagIndexes.GetIndex(0, index, _currentIndex);
                    }
                }
                foreach (var pb in this.layoutPanel_orange.Controls.OfType<CheckBox>()) {
                    var index = int.Parse(pb.Text.Substring(1)) - 1;
                    if (!set) {
                        //SandBagIndexes.Indexes[_currentIndex].Orange[index] = pb.Checked;
                        SandBagIndexes.SetIndex(1, index, _currentIndex, pb.Checked);
                    }
                    else {
                        //pb.Checked = SandBagIndexes.Indexes[_currentIndex].Orange[index];
                        pb.Checked = SandBagIndexes.GetIndex(1, index, _currentIndex);
                    }
                }
                foreach (var pb in this.layoutPanel_yellow.Controls.OfType<CheckBox>()) {
                    var index = int.Parse(pb.Text.Substring(1)) - 1;
                    if (!set) {
                        //SandBagIndexes.Indexes[_currentIndex].Yellow[index] = pb.Checked;
                        SandBagIndexes.SetIndex(2, index, _currentIndex, pb.Checked);
                    }
                    else {
                        //pb.Checked = SandBagIndexes.Indexes[_currentIndex].Yellow[index];
                        pb.Checked = SandBagIndexes.GetIndex(2, index, _currentIndex);
                    }
                }
                foreach (var pb in this.layoutPanel_green.Controls.OfType<CheckBox>()) {
                    var index = int.Parse(pb.Text.Substring(1)) - 1;
                    if (!set) {
                        //SandBagIndexes.Indexes[_currentIndex].Green[index] = pb.Checked;
                        SandBagIndexes.SetIndex(3, index, _currentIndex, pb.Checked);
                    }
                    else {
                        //pb.Checked = SandBagIndexes.Indexes[_currentIndex].Green[index];
                        pb.Checked = SandBagIndexes.GetIndex(3, index, _currentIndex);
                    }
                }
            }

            // Call the refreshed event
            if (!set) {
                SandBagIndexes.RefreshIndexes();
            }
            else {
                var sandBags = SandBagIndexes.SandBagCount();
                if (sandBags > 12) {
                    MessageBox.Show("You seem to have more than 12 sandbags chosen even though you should have only 12.", "Warning: Too many sandbags chosen.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (sandBags < 12 && _currentIndex == 4) {
                    MessageBox.Show("You seem to have less than 12 sandbags chosen even though you should have 12.", "Warning: Too few sandbags chosen.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
