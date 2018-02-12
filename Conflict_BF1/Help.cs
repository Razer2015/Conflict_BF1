using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conflict_BF1
{
    public partial class Help : Form
    {
        public Help() {
            InitializeComponent();
        }

        #region Links
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }

        private void Help_Load(object sender, EventArgs e) {
            // Add a link to the LinkLabel.
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://bfee.co/index.php?title=Battlefield_1/A_Conflict";
            linkLabel_bfee_co.Links.Add(link);

            link = new LinkLabel.Link();
            link.LinkData = "http://candles.herokuapp.com";
            linkLabel_candles.Links.Add(link);
        } 
        #endregion

        #region Panels
        private void btn_step1_Click(object sender, EventArgs e) {
            panel_step1.Visible = true;
            panel_step2.Visible = false;
            panel_step3.Visible = false;
        }

        private void btn_step2_sandbags_Click(object sender, EventArgs e) {
            panel_step1.Visible = false;
            panel_step2.Visible = true;
            panel_step3.Visible = false;
        }

        private void btn_step3_tiles_Click(object sender, EventArgs e) {
            panel_step1.Visible = false;
            panel_step2.Visible = false;
            panel_step3.Visible = true;
        }
        #endregion

        #region Sandbag indexes
        private void btn_all_indexes_Click(object sender, EventArgs e) {
            pictureBox_sbag.Image = Properties.Resources.BF1_sandbags;
        }

        private void btn_first_Click(object sender, EventArgs e) {
            pictureBox_sbag.Image = Properties.Resources.BF1_sbags_1;
        }

        private void button2_Click(object sender, EventArgs e) {
            pictureBox_sbag.Image = Properties.Resources.BF1_sbags_2;
        }

        private void button3_Click(object sender, EventArgs e) {
            pictureBox_sbag.Image = Properties.Resources.BF1_sbags_3;
        }

        private void button4_Click(object sender, EventArgs e) {
            pictureBox_sbag.Image = Properties.Resources.BF1_sbags_4;
        }
        #endregion

        #region Tiles
        private void btn_numbers_Click(object sender, EventArgs e) {
            pictureBox_tiles.Image = Properties.Resources.ChateauTopView;
        }

        private void btn_tiles_Click(object sender, EventArgs e) {
            pictureBox_tiles.Image = Properties.Resources.BF1_tiles;
        } 
        #endregion
    }
}
