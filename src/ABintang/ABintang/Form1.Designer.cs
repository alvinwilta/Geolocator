
namespace ABintang
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.BtnInputDir = new System.Windows.Forms.Button();
            this.FileDir = new System.Windows.Forms.TextBox();
            this.FileDirectory = new System.Windows.Forms.Label();
            this.btnGetRouteInfo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLoadFile = new System.Windows.Forms.TabPage();
            this.tabManual = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.map2 = new GMap.NET.WindowsForms.GMapControl();
            this.labelError2 = new System.Windows.Forms.Label();
            this.buttonDefLocation = new System.Windows.Forms.Button();
            this.buttonAddPointManual = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLocate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.labelNavigate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelError1 = new System.Windows.Forms.Label();
            this.comboStart = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboFinish = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabLoadFile.SuspendLayout();
            this.tabManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.map);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboFinish);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.comboStart);
            this.splitContainer1.Panel2.Controls.Add(this.labelError1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.BtnInputDir);
            this.splitContainer1.Panel2.Controls.Add(this.FileDir);
            this.splitContainer1.Panel2.Controls.Add(this.FileDirectory);
            this.splitContainer1.Panel2.Controls.Add(this.btnGetRouteInfo);
            this.splitContainer1.Panel2.Controls.Add(this.btnClear);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddPoint);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.txtLong);
            this.splitContainer1.Panel2.Controls.Add(this.txtLat);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(837, 484);
            this.splitContainer1.SplitterDistance = 566;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // map
            // 
            this.map.AutoSize = true;
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Margin = new System.Windows.Forms.Padding(2);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(566, 484);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            // 
            // BtnInputDir
            // 
            this.BtnInputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInputDir.Location = new System.Drawing.Point(169, 35);
            this.BtnInputDir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInputDir.Name = "BtnInputDir";
            this.BtnInputDir.Size = new System.Drawing.Size(64, 19);
            this.BtnInputDir.TabIndex = 10;
            this.BtnInputDir.Text = "Browse";
            this.BtnInputDir.UseVisualStyleBackColor = true;
            this.BtnInputDir.Click += new System.EventHandler(this.BtnInputDir_Click);
            // 
            // FileDir
            // 
            this.FileDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileDir.Location = new System.Drawing.Point(15, 35);
            this.FileDir.Margin = new System.Windows.Forms.Padding(2);
            this.FileDir.Name = "FileDir";
            this.FileDir.Size = new System.Drawing.Size(145, 20);
            this.FileDir.TabIndex = 9;
            // 
            // FileDirectory
            // 
            this.FileDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileDirectory.AutoSize = true;
            this.FileDirectory.Location = new System.Drawing.Point(13, 19);
            this.FileDirectory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileDirectory.Name = "FileDirectory";
            this.FileDirectory.Size = new System.Drawing.Size(68, 13);
            this.FileDirectory.TabIndex = 8;
            this.FileDirectory.Text = "File Directory";
            // 
            // btnGetRouteInfo
            // 
            this.btnGetRouteInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetRouteInfo.Location = new System.Drawing.Point(15, 262);
            this.btnGetRouteInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetRouteInfo.Name = "btnGetRouteInfo";
            this.btnGetRouteInfo.Size = new System.Drawing.Size(110, 26);
            this.btnGetRouteInfo.TabIndex = 7;
            this.btnGetRouteInfo.Text = "Get Route";
            this.btnGetRouteInfo.UseVisualStyleBackColor = true;
            this.btnGetRouteInfo.Click += new System.EventHandler(this.btnGetRouteInfo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(169, 118);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 19);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPoint.Location = new System.Drawing.Point(169, 74);
            this.btnAddPoint.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(64, 19);
            this.btnAddPoint.TabIndex = 5;
            this.btnAddPoint.Text = "Add Point";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(15, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load Into Map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLong
            // 
            this.txtLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLong.Location = new System.Drawing.Point(15, 119);
            this.txtLong.Margin = new System.Windows.Forms.Padding(2);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(145, 20);
            this.txtLong.TabIndex = 3;
            this.txtLong.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtLat
            // 
            this.txtLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLat.Location = new System.Drawing.Point(15, 75);
            this.txtLat.Margin = new System.Windows.Forms.Padding(2);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(145, 20);
            this.txtLat.TabIndex = 2;
            this.txtLat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitude";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latitude";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            this.ofd.Filter = "txt files(*.txt)|*.txt|All files (*.*)|*.*";
            this.ofd.FilterIndex = 2;
            this.ofd.RestoreDirectory = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLoadFile);
            this.tabControl.Controls.Add(this.tabManual);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(851, 516);
            this.tabControl.TabIndex = 1;
            // 
            // tabLoadFile
            // 
            this.tabLoadFile.Controls.Add(this.splitContainer1);
            this.tabLoadFile.Location = new System.Drawing.Point(4, 22);
            this.tabLoadFile.Name = "tabLoadFile";
            this.tabLoadFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoadFile.Size = new System.Drawing.Size(843, 490);
            this.tabLoadFile.TabIndex = 0;
            this.tabLoadFile.Text = "Load File";
            this.tabLoadFile.UseVisualStyleBackColor = true;
            // 
            // tabManual
            // 
            this.tabManual.Controls.Add(this.splitContainer2);
            this.tabManual.Location = new System.Drawing.Point(4, 22);
            this.tabManual.Name = "tabManual";
            this.tabManual.Padding = new System.Windows.Forms.Padding(3);
            this.tabManual.Size = new System.Drawing.Size(843, 490);
            this.tabManual.TabIndex = 1;
            this.tabManual.Text = "Manual Point";
            this.tabManual.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.map2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Panel2.Controls.Add(this.labelError2);
            this.splitContainer2.Panel2.Controls.Add(this.buttonDefLocation);
            this.splitContainer2.Panel2.Controls.Add(this.buttonAddPointManual);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.buttonLocate);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.txtLongitude);
            this.splitContainer2.Panel2.Controls.Add(this.txtLatitude);
            this.splitContainer2.Panel2.Controls.Add(this.labelNavigate);
            this.splitContainer2.Size = new System.Drawing.Size(837, 484);
            this.splitContainer2.SplitterDistance = 566;
            this.splitContainer2.TabIndex = 0;
            // 
            // map2
            // 
            this.map2.AutoSize = true;
            this.map2.Bearing = 0F;
            this.map2.CanDragMap = true;
            this.map2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map2.EmptyTileColor = System.Drawing.Color.Navy;
            this.map2.GrayScaleMode = false;
            this.map2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map2.LevelsKeepInMemory = 5;
            this.map2.Location = new System.Drawing.Point(0, 0);
            this.map2.Margin = new System.Windows.Forms.Padding(2);
            this.map2.MarkersEnabled = true;
            this.map2.MaxZoom = 2;
            this.map2.MinZoom = 2;
            this.map2.MouseWheelZoomEnabled = true;
            this.map2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map2.Name = "map2";
            this.map2.NegativeMode = false;
            this.map2.PolygonsEnabled = true;
            this.map2.RetryLoadTile = 0;
            this.map2.RoutesEnabled = true;
            this.map2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map2.ShowTileGridLines = false;
            this.map2.Size = new System.Drawing.Size(566, 484);
            this.map2.TabIndex = 0;
            this.map2.Zoom = 0D;
            this.map2.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.ForeColor = System.Drawing.Color.Red;
            this.labelError2.Location = new System.Drawing.Point(16, 123);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(0, 13);
            this.labelError2.TabIndex = 11;
            // 
            // buttonDefLocation
            // 
            this.buttonDefLocation.Location = new System.Drawing.Point(110, 89);
            this.buttonDefLocation.Name = "buttonDefLocation";
            this.buttonDefLocation.Size = new System.Drawing.Size(135, 23);
            this.buttonDefLocation.TabIndex = 10;
            this.buttonDefLocation.Text = "Default Location";
            this.buttonDefLocation.UseVisualStyleBackColor = true;
            this.buttonDefLocation.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAddPointManual
            // 
            this.buttonAddPointManual.Location = new System.Drawing.Point(125, 187);
            this.buttonAddPointManual.Name = "buttonAddPointManual";
            this.buttonAddPointManual.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPointManual.TabIndex = 8;
            this.buttonAddPointManual.Text = "Add Point";
            this.buttonAddPointManual.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Graph Maker";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonLocate
            // 
            this.buttonLocate.Location = new System.Drawing.Point(18, 89);
            this.buttonLocate.Name = "buttonLocate";
            this.buttonLocate.Size = new System.Drawing.Size(75, 23);
            this.buttonLocate.TabIndex = 5;
            this.buttonLocate.Text = "Locate";
            this.buttonLocate.UseVisualStyleBackColor = true;
            this.buttonLocate.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Longitude";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Latitude";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(145, 59);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(100, 20);
            this.txtLongitude.TabIndex = 2;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(18, 59);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(100, 20);
            this.txtLatitude.TabIndex = 1;
            this.txtLatitude.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelNavigate
            // 
            this.labelNavigate.AutoSize = true;
            this.labelNavigate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNavigate.Location = new System.Drawing.Point(14, 12);
            this.labelNavigate.Name = "labelNavigate";
            this.labelNavigate.Size = new System.Drawing.Size(93, 20);
            this.labelNavigate.TabIndex = 0;
            this.labelNavigate.Text = "Locate Map";
            this.labelNavigate.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Default";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelError1
            // 
            this.labelError1.AutoSize = true;
            this.labelError1.ForeColor = System.Drawing.Color.Red;
            this.labelError1.Location = new System.Drawing.Point(15, 146);
            this.labelError1.Name = "labelError1";
            this.labelError1.Size = new System.Drawing.Size(0, 13);
            this.labelError1.TabIndex = 12;
            // 
            // comboStart
            // 
            this.comboStart.BackColor = System.Drawing.SystemColors.Window;
            this.comboStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboStart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboStart.FormattingEnabled = true;
            this.comboStart.Location = new System.Drawing.Point(15, 222);
            this.comboStart.Name = "comboStart";
            this.comboStart.Size = new System.Drawing.Size(109, 21);
            this.comboStart.TabIndex = 13;
            this.comboStart.SelectedIndexChanged += new System.EventHandler(this.comboStart_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Start Node";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Finish Node";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Point Name";
            // 
            // comboFinish
            // 
            this.comboFinish.BackColor = System.Drawing.SystemColors.Window;
            this.comboFinish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFinish.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboFinish.FormattingEnabled = true;
            this.comboFinish.Location = new System.Drawing.Point(133, 222);
            this.comboFinish.Name = "comboFinish";
            this.comboFinish.Size = new System.Drawing.Size(109, 21);
            this.comboFinish.TabIndex = 17;
            this.comboFinish.SelectedIndexChanged += new System.EventHandler(this.comboFinish_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 514);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabLoadFile.ResumeLayout(false);
            this.tabManual.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label2;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnGetRouteInfo;
        private System.Windows.Forms.TextBox FileDir;
        private System.Windows.Forms.Label FileDirectory;
        private System.Windows.Forms.Button BtnInputDir;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLoadFile;
        private System.Windows.Forms.TabPage tabManual;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private GMap.NET.WindowsForms.GMapControl map2;
        private System.Windows.Forms.Label labelNavigate;
        private System.Windows.Forms.Button buttonLocate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddPointManual;
        private System.Windows.Forms.Button buttonDefLocation;
        private System.Windows.Forms.Label labelError2;
        private System.Windows.Forms.Label labelError1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboFinish;
    }
}

