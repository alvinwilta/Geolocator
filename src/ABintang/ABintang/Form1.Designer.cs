﻿namespace ABintang
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
            this.labelErrorRoute = new System.Windows.Forms.Label();
            this.comboFinish = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboStart = new System.Windows.Forms.ComboBox();
            this.labelError1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnInputDir = new System.Windows.Forms.Button();
            this.FileDir = new System.Windows.Forms.TextBox();
            this.FileDirectory = new System.Windows.Forms.Label();
            this.btnGetRouteInfo = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLoadFile = new System.Windows.Forms.TabPage();
            this.tabManual = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.map2 = new GMap.NET.WindowsForms.GMapControl();
            this.labelErrorPoint = new System.Windows.Forms.Label();
            this.labelErrorSisi = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonAddSisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboNode2 = new System.Windows.Forms.ComboBox();
            this.comboNode1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textboxPointName = new System.Windows.Forms.TextBox();
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
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelErrorFilename = new System.Windows.Forms.Label();
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
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.map);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelErrorRoute);
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
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1119, 598);
            this.splitContainer1.SplitterDistance = 756;
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
            this.map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.map.Size = new System.Drawing.Size(756, 598);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            // 
            // labelErrorRoute
            // 
            this.labelErrorRoute.AutoSize = true;
            this.labelErrorRoute.ForeColor = System.Drawing.Color.Red;
            this.labelErrorRoute.Location = new System.Drawing.Point(20, 229);
            this.labelErrorRoute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorRoute.Name = "labelErrorRoute";
            this.labelErrorRoute.Size = new System.Drawing.Size(0, 17);
            this.labelErrorRoute.TabIndex = 18;
            // 
            // comboFinish
            // 
            this.comboFinish.BackColor = System.Drawing.SystemColors.Window;
            this.comboFinish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFinish.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboFinish.FormattingEnabled = true;
            this.comboFinish.Location = new System.Drawing.Point(179, 199);
            this.comboFinish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboFinish.Name = "comboFinish";
            this.comboFinish.Size = new System.Drawing.Size(144, 24);
            this.comboFinish.TabIndex = 17;
            this.comboFinish.SelectedIndexChanged += new System.EventHandler(this.comboFinish_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Finish Node";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Start Node";
            // 
            // comboStart
            // 
            this.comboStart.BackColor = System.Drawing.SystemColors.Window;
            this.comboStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboStart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboStart.FormattingEnabled = true;
            this.comboStart.Location = new System.Drawing.Point(21, 199);
            this.comboStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboStart.Name = "comboStart";
            this.comboStart.Size = new System.Drawing.Size(144, 24);
            this.comboStart.TabIndex = 13;
            this.comboStart.SelectedIndexChanged += new System.EventHandler(this.comboStart_SelectedIndexChanged);
            // 
            // labelError1
            // 
            this.labelError1.AutoSize = true;
            this.labelError1.ForeColor = System.Drawing.Color.Red;
            this.labelError1.Location = new System.Drawing.Point(20, 159);
            this.labelError1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError1.Name = "labelError1";
            this.labelError1.Size = new System.Drawing.Size(0, 17);
            this.labelError1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 11;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnInputDir
            // 
            this.BtnInputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInputDir.Location = new System.Drawing.Point(237, 123);
            this.BtnInputDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInputDir.Name = "BtnInputDir";
            this.BtnInputDir.Size = new System.Drawing.Size(85, 23);
            this.BtnInputDir.TabIndex = 10;
            this.BtnInputDir.Text = "Browse";
            this.BtnInputDir.UseVisualStyleBackColor = true;
            this.BtnInputDir.Click += new System.EventHandler(this.BtnInputDir_Click);
            // 
            // FileDir
            // 
            this.FileDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileDir.Location = new System.Drawing.Point(31, 123);
            this.FileDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileDir.Name = "FileDir";
            this.FileDir.Size = new System.Drawing.Size(192, 22);
            this.FileDir.TabIndex = 9;
            // 
            // FileDirectory
            // 
            this.FileDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileDirectory.AutoSize = true;
            this.FileDirectory.Location = new System.Drawing.Point(29, 103);
            this.FileDirectory.Name = "FileDirectory";
            this.FileDirectory.Size = new System.Drawing.Size(91, 17);
            this.FileDirectory.TabIndex = 8;
            this.FileDirectory.Text = "File Directory";
            // 
            // btnGetRouteInfo
            // 
            this.btnGetRouteInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetRouteInfo.Location = new System.Drawing.Point(31, 260);
            this.btnGetRouteInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetRouteInfo.Name = "btnGetRouteInfo";
            this.btnGetRouteInfo.Size = new System.Drawing.Size(147, 32);
            this.btnGetRouteInfo.TabIndex = 7;
            this.btnGetRouteInfo.Text = "Get Route";
            this.btnGetRouteInfo.UseVisualStyleBackColor = true;
            this.btnGetRouteInfo.Click += new System.EventHandler(this.btnGetRouteInfo_Click);
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
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1135, 635);
            this.tabControl.TabIndex = 1;
            // 
            // tabLoadFile
            // 
            this.tabLoadFile.Controls.Add(this.splitContainer1);
            this.tabLoadFile.Location = new System.Drawing.Point(4, 25);
            this.tabLoadFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLoadFile.Name = "tabLoadFile";
            this.tabLoadFile.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLoadFile.Size = new System.Drawing.Size(1127, 606);
            this.tabLoadFile.TabIndex = 0;
            this.tabLoadFile.Text = "Load File";
            this.tabLoadFile.UseVisualStyleBackColor = true;
            // 
            // tabManual
            // 
            this.tabManual.Controls.Add(this.splitContainer2);
            this.tabManual.Location = new System.Drawing.Point(4, 25);
            this.tabManual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabManual.Name = "tabManual";
            this.tabManual.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabManual.Size = new System.Drawing.Size(1127, 606);
            this.tabManual.TabIndex = 1;
            this.tabManual.Text = "Manual Point";
            this.tabManual.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(4, 4);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.map2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.labelErrorPoint);
            this.splitContainer2.Panel2.Controls.Add(this.labelErrorSisi);
            this.splitContainer2.Panel2.Controls.Add(this.labelErrorFilename);
            this.splitContainer2.Panel2.Controls.Add(this.label13);
            this.splitContainer2.Panel2.Controls.Add(this.label12);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.buttonExport);
            this.splitContainer2.Panel2.Controls.Add(this.buttonAddSisi);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.comboNode2);
            this.splitContainer2.Panel2.Controls.Add(this.comboNode1);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.textboxPointName);
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
            this.splitContainer2.Size = new System.Drawing.Size(1119, 598);
            this.splitContainer2.SplitterDistance = 756;
            this.splitContainer2.SplitterWidth = 5;
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
            this.map2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.map2.Size = new System.Drawing.Size(756, 598);
            this.map2.TabIndex = 0;
            this.map2.Zoom = 0D;
            this.map2.Load += new System.EventHandler(this.gMapControl1_Load);
            this.map2.Click += new System.EventHandler(this.map2_Click);
            this.map2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.map2_MouseDoubleClick);
            // 
            // labelErrorPoint
            // 
            this.labelErrorPoint.AutoSize = true;
            this.labelErrorPoint.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPoint.Location = new System.Drawing.Point(21, 265);
            this.labelErrorPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorPoint.Name = "labelErrorPoint";
            this.labelErrorPoint.Size = new System.Drawing.Size(99, 17);
            this.labelErrorPoint.TabIndex = 27;
            this.labelErrorPoint.Text = "labelException";
            // 
            // labelErrorSisi
            // 
            this.labelErrorSisi.AutoSize = true;
            this.labelErrorSisi.ForeColor = System.Drawing.Color.Red;
            this.labelErrorSisi.Location = new System.Drawing.Point(21, 383);
            this.labelErrorSisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorSisi.Name = "labelErrorSisi";
            this.labelErrorSisi.Size = new System.Drawing.Size(99, 17);
            this.labelErrorSisi.TabIndex = 26;
            this.labelErrorSisi.Text = "labelException";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 442);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Export to txt File";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 326);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Node 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 326);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Node 1";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(24, 533);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(100, 28);
            this.buttonExport.TabIndex = 19;
            this.buttonExport.Text = "Export to txt";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonAddSisi
            // 
            this.buttonAddSisi.Location = new System.Drawing.Point(211, 383);
            this.buttonAddSisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddSisi.Name = "buttonAddSisi";
            this.buttonAddSisi.Size = new System.Drawing.Size(100, 28);
            this.buttonAddSisi.TabIndex = 18;
            this.buttonAddSisi.Text = "Add Sisi";
            this.buttonAddSisi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 17;
            // 
            // comboNode2
            // 
            this.comboNode2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNode2.FormattingEnabled = true;
            this.comboNode2.Location = new System.Drawing.Point(180, 346);
            this.comboNode2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboNode2.Name = "comboNode2";
            this.comboNode2.Size = new System.Drawing.Size(129, 24);
            this.comboNode2.TabIndex = 16;
            // 
            // comboNode1
            // 
            this.comboNode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNode1.FormattingEnabled = true;
            this.comboNode1.Location = new System.Drawing.Point(24, 346);
            this.comboNode1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboNode1.Name = "comboNode1";
            this.comboNode1.Size = new System.Drawing.Size(129, 24);
            this.comboNode1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add Sisi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 210);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Point Name";
            // 
            // textboxPointName
            // 
            this.textboxPointName.Location = new System.Drawing.Point(25, 233);
            this.textboxPointName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxPointName.Name = "textboxPointName";
            this.textboxPointName.Size = new System.Drawing.Size(132, 22);
            this.textboxPointName.TabIndex = 12;
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.ForeColor = System.Drawing.Color.Red;
            this.labelError2.Location = new System.Drawing.Point(21, 151);
            this.labelError2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(0, 17);
            this.labelError2.TabIndex = 11;
            // 
            // buttonDefLocation
            // 
            this.buttonDefLocation.Location = new System.Drawing.Point(147, 110);
            this.buttonDefLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDefLocation.Name = "buttonDefLocation";
            this.buttonDefLocation.Size = new System.Drawing.Size(180, 28);
            this.buttonDefLocation.TabIndex = 10;
            this.buttonDefLocation.Text = "Default Location";
            this.buttonDefLocation.UseVisualStyleBackColor = true;
            this.buttonDefLocation.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAddPointManual
            // 
            this.buttonAddPointManual.Location = new System.Drawing.Point(167, 230);
            this.buttonAddPointManual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddPointManual.Name = "buttonAddPointManual";
            this.buttonAddPointManual.Size = new System.Drawing.Size(100, 28);
            this.buttonAddPointManual.TabIndex = 8;
            this.buttonAddPointManual.Text = "Add Point";
            this.buttonAddPointManual.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Graph Maker";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonLocate
            // 
            this.buttonLocate.Location = new System.Drawing.Point(24, 110);
            this.buttonLocate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLocate.Name = "buttonLocate";
            this.buttonLocate.Size = new System.Drawing.Size(100, 28);
            this.buttonLocate.TabIndex = 5;
            this.buttonLocate.Text = "Locate";
            this.buttonLocate.UseVisualStyleBackColor = true;
            this.buttonLocate.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Longitude";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Latitude";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(193, 73);
            this.txtLongitude.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(132, 22);
            this.txtLongitude.TabIndex = 2;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(24, 73);
            this.txtLatitude.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(132, 22);
            this.txtLatitude.TabIndex = 1;
            this.txtLatitude.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelNavigate
            // 
            this.labelNavigate.AutoSize = true;
            this.labelNavigate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNavigate.Location = new System.Drawing.Point(19, 15);
            this.labelNavigate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNavigate.Name = "labelNavigate";
            this.labelNavigate.Size = new System.Drawing.Size(115, 25);
            this.labelNavigate.TabIndex = 0;
            this.labelNavigate.Text = "Locate Map";
            this.labelNavigate.Click += new System.EventHandler(this.label4_Click);
            // 
            // sfd
            // 
            this.sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 478);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Filename";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 497);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 22;
            // 
            // labelErrorFilename
            // 
            this.labelErrorFilename.AutoSize = true;
            this.labelErrorFilename.ForeColor = System.Drawing.Color.Red;
            this.labelErrorFilename.Location = new System.Drawing.Point(167, 501);
            this.labelErrorFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorFilename.Name = "labelErrorFilename";
            this.labelErrorFilename.Size = new System.Drawing.Size(99, 17);
            this.labelErrorFilename.TabIndex = 25;
            this.labelErrorFilename.Text = "labelException";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 633);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private GMap.NET.WindowsForms.GMapControl map;
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
        private System.Windows.Forms.TextBox textboxPointName;
        private System.Windows.Forms.ComboBox comboFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboNode2;
        private System.Windows.Forms.ComboBox comboNode1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonAddSisi;
        private System.Windows.Forms.Label labelErrorRoute;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelErrorPoint;
        private System.Windows.Forms.Label labelErrorSisi;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label labelErrorFilename;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
    }
}