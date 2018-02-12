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
            this.captureStart = new System.Windows.Forms.Button();
            this.pBox_preview = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_results = new System.Windows.Forms.Button();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.layoutPanel_green = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.layoutPanel_yellow = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.layoutPanel_orange = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.layoutPanel_red = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stage = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.uxHotKey = new FireAnt.Windows.Forms.Util.HotKey(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_preview)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_bWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_tWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_y)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.layoutPanel_green.SuspendLayout();
            this.layoutPanel_yellow.SuspendLayout();
            this.layoutPanel_orange.SuspendLayout();
            this.layoutPanel_red.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // captureStart
            // 
            this.captureStart.Location = new System.Drawing.Point(12, 19);
            this.captureStart.Name = "captureStart";
            this.captureStart.Size = new System.Drawing.Size(134, 23);
            this.captureStart.TabIndex = 0;
            this.captureStart.Text = "Start Capture";
            this.captureStart.UseVisualStyleBackColor = true;
            this.captureStart.Click += new System.EventHandler(this.captureStart_Click);
            // 
            // pBox_preview
            // 
            this.pBox_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox_preview.Location = new System.Drawing.Point(0, 80);
            this.pBox_preview.Name = "pBox_preview";
            this.pBox_preview.Size = new System.Drawing.Size(860, 213);
            this.pBox_preview.TabIndex = 1;
            this.pBox_preview.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_help);
            this.groupBox1.Controls.Add(this.btn_results);
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
            this.groupBox1.Controls.Add(this.captureStart);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(748, 19);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(100, 55);
            this.btn_help.TabIndex = 13;
            this.btn_help.Text = "How to?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_results
            // 
            this.btn_results.Location = new System.Drawing.Point(574, 48);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(161, 26);
            this.btn_results.TabIndex = 12;
            this.btn_results.Text = "Show Tiles";
            this.btn_results.UseVisualStyleBackColor = true;
            this.btn_results.Click += new System.EventHandler(this.btn_results_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.layoutPanel_green);
            this.groupBox2.Controls.Add(this.layoutPanel_yellow);
            this.groupBox2.Controls.Add(this.layoutPanel_orange);
            this.groupBox2.Controls.Add(this.layoutPanel_red);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 169);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // layoutPanel_green
            // 
            this.layoutPanel_green.BackColor = System.Drawing.Color.Green;
            this.layoutPanel_green.ColumnCount = 2;
            this.layoutPanel_green.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_green.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_green.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_green.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_green.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_green.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_green.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_green.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_green.Controls.Add(this.checkBox21, 1, 0);
            this.layoutPanel_green.Controls.Add(this.checkBox22, 0, 0);
            this.layoutPanel_green.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutPanel_green.Location = new System.Drawing.Point(3, 139);
            this.layoutPanel_green.Name = "layoutPanel_green";
            this.layoutPanel_green.RowCount = 1;
            this.layoutPanel_green.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_green.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel_green.Size = new System.Drawing.Size(854, 30);
            this.layoutPanel_green.TabIndex = 5;
            this.layoutPanel_green.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.layoutPanel_CellPaint);
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox21.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox21.Location = new System.Drawing.Point(430, 3);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(421, 24);
            this.checkBox21.TabIndex = 1;
            this.checkBox21.Text = "G2";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox22.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox22.Location = new System.Drawing.Point(3, 3);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(421, 24);
            this.checkBox22.TabIndex = 0;
            this.checkBox22.Text = "G1";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // layoutPanel_yellow
            // 
            this.layoutPanel_yellow.BackColor = System.Drawing.Color.Yellow;
            this.layoutPanel_yellow.ColumnCount = 4;
            this.layoutPanel_yellow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel_yellow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel_yellow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00001F));
            this.layoutPanel_yellow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel_yellow.Controls.Add(this.checkBox17, 3, 0);
            this.layoutPanel_yellow.Controls.Add(this.checkBox18, 2, 0);
            this.layoutPanel_yellow.Controls.Add(this.checkBox19, 1, 0);
            this.layoutPanel_yellow.Controls.Add(this.checkBox20, 0, 0);
            this.layoutPanel_yellow.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutPanel_yellow.Location = new System.Drawing.Point(3, 109);
            this.layoutPanel_yellow.Name = "layoutPanel_yellow";
            this.layoutPanel_yellow.RowCount = 1;
            this.layoutPanel_yellow.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_yellow.Size = new System.Drawing.Size(854, 30);
            this.layoutPanel_yellow.TabIndex = 4;
            this.layoutPanel_yellow.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.layoutPanel_CellPaint);
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox17.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox17.Location = new System.Drawing.Point(642, 3);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(209, 24);
            this.checkBox17.TabIndex = 3;
            this.checkBox17.Text = "Y4";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox18.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox18.Location = new System.Drawing.Point(429, 3);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(207, 24);
            this.checkBox18.TabIndex = 2;
            this.checkBox18.Text = "Y3";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox19.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox19.Location = new System.Drawing.Point(216, 3);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(207, 24);
            this.checkBox19.TabIndex = 1;
            this.checkBox19.Text = "Y2";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox20.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox20.Location = new System.Drawing.Point(3, 3);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(207, 24);
            this.checkBox20.TabIndex = 0;
            this.checkBox20.Text = "Y1";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // layoutPanel_orange
            // 
            this.layoutPanel_orange.BackColor = System.Drawing.Color.Orange;
            this.layoutPanel_orange.ColumnCount = 6;
            this.layoutPanel_orange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_orange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_orange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_orange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_orange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_orange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_orange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_orange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_orange.Controls.Add(this.checkBox11, 5, 0);
            this.layoutPanel_orange.Controls.Add(this.checkBox12, 4, 0);
            this.layoutPanel_orange.Controls.Add(this.checkBox13, 3, 0);
            this.layoutPanel_orange.Controls.Add(this.checkBox14, 2, 0);
            this.layoutPanel_orange.Controls.Add(this.checkBox15, 1, 0);
            this.layoutPanel_orange.Controls.Add(this.checkBox16, 0, 0);
            this.layoutPanel_orange.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutPanel_orange.Location = new System.Drawing.Point(3, 79);
            this.layoutPanel_orange.Name = "layoutPanel_orange";
            this.layoutPanel_orange.RowCount = 1;
            this.layoutPanel_orange.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_orange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanel_orange.Size = new System.Drawing.Size(854, 30);
            this.layoutPanel_orange.TabIndex = 3;
            this.layoutPanel_orange.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.layoutPanel_CellPaint);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(713, 3);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(138, 24);
            this.checkBox11.TabIndex = 5;
            this.checkBox11.Text = "O6";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.Location = new System.Drawing.Point(571, 3);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(136, 24);
            this.checkBox12.TabIndex = 4;
            this.checkBox12.Text = "O5";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox13.Location = new System.Drawing.Point(429, 3);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(136, 24);
            this.checkBox13.TabIndex = 3;
            this.checkBox13.Text = "O4";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox14.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox14.Location = new System.Drawing.Point(287, 3);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(136, 24);
            this.checkBox14.TabIndex = 2;
            this.checkBox14.Text = "O3";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox15.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox15.Location = new System.Drawing.Point(145, 3);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(136, 24);
            this.checkBox15.TabIndex = 1;
            this.checkBox15.Text = "O2";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox16.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox16.Location = new System.Drawing.Point(3, 3);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(136, 24);
            this.checkBox16.TabIndex = 0;
            this.checkBox16.Text = "O1";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // layoutPanel_red
            // 
            this.layoutPanel_red.BackColor = System.Drawing.Color.Red;
            this.layoutPanel_red.ColumnCount = 8;
            this.layoutPanel_red.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_red.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_red.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_red.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_red.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_red.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_red.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_red.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel_red.Controls.Add(this.checkBox8, 7, 0);
            this.layoutPanel_red.Controls.Add(this.checkBox7, 6, 0);
            this.layoutPanel_red.Controls.Add(this.checkBox6, 5, 0);
            this.layoutPanel_red.Controls.Add(this.checkBox5, 4, 0);
            this.layoutPanel_red.Controls.Add(this.checkBox4, 3, 0);
            this.layoutPanel_red.Controls.Add(this.checkBox3, 2, 0);
            this.layoutPanel_red.Controls.Add(this.checkBox2, 1, 0);
            this.layoutPanel_red.Controls.Add(this.checkBox1, 0, 0);
            this.layoutPanel_red.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutPanel_red.Location = new System.Drawing.Point(3, 49);
            this.layoutPanel_red.Name = "layoutPanel_red";
            this.layoutPanel_red.RowCount = 1;
            this.layoutPanel_red.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_red.Size = new System.Drawing.Size(854, 30);
            this.layoutPanel_red.TabIndex = 2;
            this.layoutPanel_red.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.layoutPanel_CellPaint);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox8.Location = new System.Drawing.Point(745, 3);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(106, 24);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "R8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox7.Location = new System.Drawing.Point(639, 3);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(100, 24);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "R7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox6.Location = new System.Drawing.Point(533, 3);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(100, 24);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "R6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox5.Location = new System.Drawing.Point(427, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(100, 24);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "R5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox4.Location = new System.Drawing.Point(321, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 24);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "R4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox3.Location = new System.Drawing.Point(215, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(100, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "R3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox2.Location = new System.Drawing.Point(109, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(100, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "R2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "R1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stage);
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.previousBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 33);
            this.panel1.TabIndex = 6;
            // 
            // stage
            // 
            this.stage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.stage.Location = new System.Drawing.Point(210, 0);
            this.stage.Margin = new System.Windows.Forms.Padding(0);
            this.stage.Name = "stage";
            this.stage.Size = new System.Drawing.Size(432, 33);
            this.stage.TabIndex = 0;
            this.stage.Text = "First";
            this.stage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextBtn
            // 
            this.nextBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextBtn.Location = new System.Drawing.Point(642, 0);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(212, 33);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.previousBtn.Location = new System.Drawing.Point(0, 0);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(210, 33);
            this.previousBtn.TabIndex = 1;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // uxHotKey
            // 
            this.uxHotKey.Key = System.Windows.Forms.Keys.None;
            this.uxHotKey.Modifiers = FireAnt.Windows.Forms.Util.Modifiers.None;
            this.uxHotKey.HotKeyPressed += new System.EventHandler(this.uxHotKey_HotKeyPressed);
            // 
            // ScreenCapturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 462);
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
            this.groupBox2.ResumeLayout(false);
            this.layoutPanel_green.ResumeLayout(false);
            this.layoutPanel_green.PerformLayout();
            this.layoutPanel_yellow.ResumeLayout(false);
            this.layoutPanel_yellow.PerformLayout();
            this.layoutPanel_orange.ResumeLayout(false);
            this.layoutPanel_orange.PerformLayout();
            this.layoutPanel_red.ResumeLayout(false);
            this.layoutPanel_red.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button captureStart;
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
        private System.Windows.Forms.TableLayoutPanel layoutPanel_red;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label stage;
        private System.Windows.Forms.TableLayoutPanel layoutPanel_orange;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.TableLayoutPanel layoutPanel_green;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.TableLayoutPanel layoutPanel_yellow;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button btn_results;
        private System.Windows.Forms.Button btn_help;
    }
}