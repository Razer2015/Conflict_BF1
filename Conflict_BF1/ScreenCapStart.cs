using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;

namespace MorseCodeDecoder
{
    public partial class ScreenCapStart : Form
    {
        private Screen[] screens;
        private Process[] localAll;
        public Rectangle toreturn;
        public String process_name;
        private Boolean processes = true;
        public ScreenCapStart()
        {
            InitializeComponent();
        }
        public ScreenCapStart(Boolean processes)
        {
            this.processes = processes;
            InitializeComponent();
        }

        private void ScreenCapStart_Load(object sender, EventArgs e)
        {
            if (processes)
            {
                // Get all processes running on the local computer.
                localAll = Process.GetProcesses();
                if (localAll != null)
                {
                    foreach (Process process in localAll)
                    {
                        comboBox1.Items.Add(process.ProcessName);
                    }
                }
                else
                {
                    comboBox1.Items.Add("No Processes Available");
                }
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                screens = System.Windows.Forms.Screen.AllScreens;
                if (screens != null)
                {
                    foreach (Screen screen in screens)
                    {
                        comboBox1.Items.Add(screen.DeviceName);
                    }
                }
                else
                {
                    comboBox1.Items.Add("No Device Available");
                }
                comboBox1.SelectedIndex = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (processes)
            {
                if (localAll.Length != 0)
                {
                    process_name = localAll[comboBox1.SelectedIndex].ProcessName;
                    toreturn = Process_Location.ProcessLocation(localAll[comboBox1.SelectedIndex].ProcessName);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (screens.Length != 0)
                {
                    Rectangle screenArea = Rectangle.Empty;
                    toreturn = Rectangle.Union(screenArea, screens[comboBox1.SelectedIndex].Bounds);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
