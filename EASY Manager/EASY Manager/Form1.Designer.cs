namespace EASY_Manager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.btnkill = new MetroFramework.Controls.MetroTile();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.opntxtfield1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PCpu = new System.Diagnostics.PerformanceCounter();
            this.PRam = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.metroProgressBarCpu = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBarRam = new MetroFramework.Controls.MetroProgressBar();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.LblCPU = new MaterialSkin.Controls.MaterialLabel();
            this.LblRam = new MaterialSkin.Controls.MaterialLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideWhenMinimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.PCpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile8
            // 
            this.metroTile8.Location = new System.Drawing.Point(226, 64);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(113, 32);
            this.metroTile8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile8.TabIndex = 12;
            this.metroTile8.Text = "Performance";
            this.metroTile8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTile2.Location = new System.Drawing.Point(113, 64);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(113, 32);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile2.TabIndex = 11;
            this.metroTile2.Text = "Run a Task";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // btnkill
            // 
            this.btnkill.Location = new System.Drawing.Point(0, 64);
            this.btnkill.Name = "btnkill";
            this.btnkill.Size = new System.Drawing.Size(113, 32);
            this.btnkill.TabIndex = 10;
            this.btnkill.Text = "Kill a Process";
            this.btnkill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnkill.Click += new System.EventHandler(this.minventory_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(313, 549);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(132, 28);
            this.materialRaisedButton1.TabIndex = 14;
            this.materialRaisedButton1.Text = "End Task";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // opntxtfield1
            // 
            this.opntxtfield1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.opntxtfield1.Depth = 0;
            this.opntxtfield1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.opntxtfield1.Hint = "      ex : NotePad";
            this.opntxtfield1.Location = new System.Drawing.Point(144, 179);
            this.opntxtfield1.MouseState = MaterialSkin.MouseState.HOVER;
            this.opntxtfield1.Name = "opntxtfield1";
            this.opntxtfield1.PasswordChar = '\0';
            this.opntxtfield1.SelectedText = "";
            this.opntxtfield1.SelectionLength = 0;
            this.opntxtfield1.SelectionStart = 0;
            this.opntxtfield1.Size = new System.Drawing.Size(242, 23);
            this.opntxtfield1.TabIndex = 17;
            this.opntxtfield1.UseSystemPasswordChar = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(89, 179);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Open :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(313, 549);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(132, 28);
            this.materialRaisedButton2.TabIndex = 15;
            this.materialRaisedButton2.Text = "Add Process";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // PCpu
            // 
            this.PCpu.CategoryName = "Processor";
            this.PCpu.CounterName = "% Processor Time";
            this.PCpu.InstanceName = "_Total";
            // 
            // PRam
            // 
            this.PRam.CategoryName = "Memory";
            this.PRam.CounterName = "% Committed Bytes In Use";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 112);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 23);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "CPU :";
            // 
            // metroProgressBarCpu
            // 
            this.metroProgressBarCpu.Location = new System.Drawing.Point(67, 112);
            this.metroProgressBarCpu.Name = "metroProgressBarCpu";
            this.metroProgressBarCpu.Size = new System.Drawing.Size(319, 23);
            this.metroProgressBarCpu.TabIndex = 19;
            // 
            // metroProgressBarRam
            // 
            this.metroProgressBarRam.Location = new System.Drawing.Point(67, 141);
            this.metroProgressBarRam.Name = "metroProgressBarRam";
            this.metroProgressBarRam.Size = new System.Drawing.Size(319, 23);
            this.metroProgressBarRam.TabIndex = 21;
            // 
            // materialLabel2
            // 
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 141);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(54, 23);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "RAM :";
            // 
            // LblCPU
            // 
            this.LblCPU.BackColor = System.Drawing.Color.Transparent;
            this.LblCPU.Depth = 0;
            this.LblCPU.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCPU.Location = new System.Drawing.Point(392, 112);
            this.LblCPU.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCPU.Name = "LblCPU";
            this.LblCPU.Size = new System.Drawing.Size(65, 23);
            this.LblCPU.TabIndex = 22;
            this.LblCPU.Text = "10 %";
            // 
            // LblRam
            // 
            this.LblRam.BackColor = System.Drawing.Color.Transparent;
            this.LblRam.Depth = 0;
            this.LblRam.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblRam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblRam.Location = new System.Drawing.Point(392, 141);
            this.LblRam.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblRam.Name = "LblRam";
            this.LblRam.Size = new System.Drawing.Size(65, 23);
            this.LblRam.TabIndex = 23;
            this.LblRam.Text = "10 %";
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(2, 214);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Legend = "Legend1";
            series11.Name = "CPU";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series12.Legend = "Legend1";
            series12.Name = "RAM";
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(458, 329);
            this.chart1.TabIndex = 24;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(339, 64);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(121, 32);
            this.metroTile1.TabIndex = 26;
            this.metroTile1.Text = "System Info";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(-3, 214);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(460, 329);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Process Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 293;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Process ID";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thread";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 59;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(139, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runNewTaskToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // runNewTaskToolStripMenuItem
            // 
            this.runNewTaskToolStripMenuItem.Name = "runNewTaskToolStripMenuItem";
            this.runNewTaskToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.runNewTaskToolStripMenuItem.Text = "File Browser";
            this.runNewTaskToolStripMenuItem.Click += new System.EventHandler(this.runNewTaskToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.AutoSize = false;
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.hideWhenMinimizedToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // hideWhenMinimizedToolStripMenuItem
            // 
            this.hideWhenMinimizedToolStripMenuItem.Name = "hideWhenMinimizedToolStripMenuItem";
            this.hideWhenMinimizedToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.hideWhenMinimizedToolStripMenuItem.Text = "Hide When Minimized";
            this.hideWhenMinimizedToolStripMenuItem.Click += new System.EventHandler(this.hideWhenMinimizedToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EASY_Manager.Properties.Resources.if_Task_Manager_52636;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 557);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(0, 19);
            this.materialLabel3.TabIndex = 28;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(27, 254);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(401, 156);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(193, 562);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(266, 19);
            this.materialLabel4.TabIndex = 30;
            this.materialLabel4.Text = "Software Developed By @ SoftTech.co";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(47, 233);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(351, 258);
            this.listView2.TabIndex = 31;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "History";
            this.columnHeader1.Width = 344;
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(266, 515);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(132, 28);
            this.materialRaisedButton3.TabIndex = 32;
            this.materialRaisedButton3.Text = "Clear History";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 585);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.LblRam);
            this.Controls.Add(this.LblCPU);
            this.Controls.Add(this.metroProgressBarRam);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.metroProgressBarCpu);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.opntxtfield1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.metroTile8);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.btnkill);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "            Easy Task Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile btnkill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField opntxtfield1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Diagnostics.PerformanceCounter PCpu;
        private System.Diagnostics.PerformanceCounter PRam;
        private System.Windows.Forms.Timer timer;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCpu;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRam;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel LblCPU;
        private MaterialSkin.Controls.MaterialLabel LblRam;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runNewTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideWhenMinimizedToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
    }
}

