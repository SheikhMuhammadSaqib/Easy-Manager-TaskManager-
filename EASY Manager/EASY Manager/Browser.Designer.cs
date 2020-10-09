namespace EASY_Manager
{
    partial class Browser
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
            this.mBtnOpen = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listView = new System.Windows.Forms.ListView();
            this.mTxtOpen = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // mBtnOpen
            // 
            this.mBtnOpen.Depth = 0;
            this.mBtnOpen.Location = new System.Drawing.Point(326, 294);
            this.mBtnOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnOpen.Name = "mBtnOpen";
            this.mBtnOpen.Primary = true;
            this.mBtnOpen.Size = new System.Drawing.Size(75, 23);
            this.mBtnOpen.TabIndex = 0;
            this.mBtnOpen.Text = "OPEN";
            this.mBtnOpen.UseVisualStyleBackColor = true;
            this.mBtnOpen.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // listView
            // 
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(389, 263);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // mTxtOpen
            // 
            this.mTxtOpen.Location = new System.Drawing.Point(59, 292);
            this.mTxtOpen.Name = "mTxtOpen";
            this.mTxtOpen.ReadOnly = true;
            this.mTxtOpen.Size = new System.Drawing.Size(246, 23);
            this.mTxtOpen.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 294);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Path:";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 329);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mTxtOpen);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.mBtnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Browser";
            this.Text = "Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton mBtnOpen;
        private System.Windows.Forms.ListView listView;
        private MetroFramework.Controls.MetroTextBox mTxtOpen;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ImageList imageList;
    }
}