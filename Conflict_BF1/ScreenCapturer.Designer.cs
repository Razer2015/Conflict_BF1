namespace Conflict_BF1
{
    partial class ScreenCapturer
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.pBox_preview = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nUD_bWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nUD_tWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nUD_height = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nUD_x = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nUD_y = new System.Windows.Forms.NumericUpDown();
            this.btn_screenshot = new System.Windows.Forms.Button();
            this.uxHotKey = new FireAnt.Windows.Forms.Util.HotKey(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_preview)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_bWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_tWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_y)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Capture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pBox_preview
            // 
            this.pBox_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox_preview.Location = new System.Drawing.Point(0, 80);
            this.pBox_preview.Name = "pBox_preview";
            this.pBox_preview.Size = new System.Drawing.Size(860, 293);
            this.pBox_preview.TabIndex = 1;
            this.pBox_preview.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nUD_bWidth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nUD_tWidth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nUD_height);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nUD_x);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nUD_y);
            this.groupBox1.Controls.Add(this.btn_screenshot);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bottom Width";
            // 
            // nUD_bWidth
            // 
            this.nUD_bWidth.DecimalPlaces = 2;
            this.nUD_bWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_bWidth.Location = new System.Drawing.Point(445, 56);
            this.nUD_bWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_bWidth.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.nUD_bWidth.Name = "nUD_bWidth";
            this.nUD_bWidth.Size = new System.Drawing.Size(120, 20);
            this.nUD_bWidth.TabIndex = 10;
            this.nUD_bWidth.ValueChanged += new System.EventHandler(this.nUD_bWidth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Top Width";
            // 
            // nUD_tWidth
            // 
            this.nUD_tWidth.DecimalPlaces = 2;
            this.nUD_tWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_tWidth.Location = new System.Drawing.Point(445, 22);
            this.nUD_tWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_tWidth.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.nUD_tWidth.Name = "nUD_tWidth";
            this.nUD_tWidth.Size = new System.Drawing.Size(120, 20);
            this.nUD_tWidth.TabIndex = 8;
            this.nUD_tWidth.ValueChanged += new System.EventHandler(this.nUD_width_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Height";
            // 
            // nUD_height
            // 
            this.nUD_height.DecimalPlaces = 2;
            this.nUD_height.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_height.Location = new System.Drawing.Point(615, 22);
            this.nUD_height.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_height.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.nUD_height.Name = "nUD_height";
            this.nUD_height.Size = new System.Drawing.Size(120, 20);
            this.nUD_height.TabIndex = 6;
            this.nUD_height.ValueChanged += new System.EventHandler(this.nUD_height_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X Position";
            // 
            // nUD_x
            // 
            this.nUD_x.DecimalPlaces = 2;
            this.nUD_x.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_x.Location = new System.Drawing.Point(232, 22);
            this.nUD_x.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_x.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.nUD_x.Name = "nUD_x";
            this.nUD_x.Size = new System.Drawing.Size(120, 20);
            this.nUD_x.TabIndex = 4;
            this.nUD_x.ValueChanged += new System.EventHandler(this.nUD_x_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Y Position";
            // 
            // nUD_y
            // 
            this.nUD_y.DecimalPlaces = 2;
            this.nUD_y.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_y.Location = new System.Drawing.Point(232, 51);
            this.nUD_y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_y.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.nUD_y.Name = "nUD_y";
            this.nUD_y.Size = new System.Drawing.Size(120, 20);
            this.nUD_y.TabIndex = 2;
            this.nUD_y.ValueChanged += new System.EventHandler(this.nUD_y_ValueChanged);
            // 
            // btn_screenshot
            // 
            this.btn_screenshot.Location = new System.Drawing.Point(12, 48);
            this.btn_screenshot.Name = "btn_screenshot";
            this.btn_screenshot.Size = new System.Drawing.Size(134, 23);
            this.btn_screenshot.TabIndex = 1;
            this.btn_screenshot.Text = "Take Screenshot";
            this.btn_screenshot.UseVisualStyleBackColor = true;
            this.btn_screenshot.Click += new System.EventHandler(this.btn_screenshot_Click);
            // 
            // uxHotKey
            // 
            this.uxHotKey.Key = System.Windows.Forms.Keys.None;
            this.uxHotKey.Modifiers = FireAnt.Windows.Forms.Util.Modifiers.None;
            this.uxHotKey.HotKeyPressed += new System.EventHandler(this.uxHotKey_HotKeyPressed);
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 126);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // ScreenCapturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 499);
            this.Controls.Add(this.pBox_preview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ScreenCapturer";
            this.Text = "ScreenCapturer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScreenCapturer_FormClosed);
            this.Load += new System.EventHandler(this.ScreenCapturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_preview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_bWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_tWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_y)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pBox_preview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_screenshot;
        private System.Windows.Forms.NumericUpDown nUD_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUD_x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUD_tWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUD_height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUD_bWidth;
        private FireAnt.Windows.Forms.Util.HotKey uxHotKey;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}