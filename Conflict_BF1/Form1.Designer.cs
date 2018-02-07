namespace Conflict_BF1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nUD_scale = new System.Windows.Forms.NumericUpDown();
            this.nUD_xPos = new System.Windows.Forms.NumericUpDown();
            this.nUD_yPos = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_xPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_yPos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1066, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nUD_yPos);
            this.groupBox1.Controls.Add(this.nUD_xPos);
            this.groupBox1.Controls.Add(this.nUD_scale);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1066, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // nUD_scale
            // 
            this.nUD_scale.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD_scale.Location = new System.Drawing.Point(12, 19);
            this.nUD_scale.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUD_scale.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nUD_scale.Name = "nUD_scale";
            this.nUD_scale.Size = new System.Drawing.Size(120, 20);
            this.nUD_scale.TabIndex = 0;
            this.nUD_scale.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nUD_xPos
            // 
            this.nUD_xPos.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD_xPos.Location = new System.Drawing.Point(209, 19);
            this.nUD_xPos.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUD_xPos.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nUD_xPos.Name = "nUD_xPos";
            this.nUD_xPos.Size = new System.Drawing.Size(120, 20);
            this.nUD_xPos.TabIndex = 1;
            this.nUD_xPos.ValueChanged += new System.EventHandler(this.nUD_xPos_ValueChanged);
            // 
            // nUD_yPos
            // 
            this.nUD_yPos.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD_yPos.Location = new System.Drawing.Point(431, 19);
            this.nUD_yPos.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUD_yPos.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nUD_yPos.Name = "nUD_yPos";
            this.nUD_yPos.Size = new System.Drawing.Size(120, 20);
            this.nUD_yPos.TabIndex = 2;
            this.nUD_yPos.ValueChanged += new System.EventHandler(this.nUD_yPos_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_xPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_yPos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nUD_scale;
        private System.Windows.Forms.NumericUpDown nUD_yPos;
        private System.Windows.Forms.NumericUpDown nUD_xPos;
    }
}

