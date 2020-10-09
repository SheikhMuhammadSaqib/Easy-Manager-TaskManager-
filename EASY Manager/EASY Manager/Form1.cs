using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.IO;


namespace EASY_Manager
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {

        public Form1()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;

            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }



        Process[] proc;
        int a;
        public void GetAllProcess()
        {
            listView1.Items.Clear();
            proc = Process.GetProcesses();
            a = 0;
            foreach (Process P in proc)
            {
                ListViewItem item = new ListViewItem(P.ProcessName);
                item.SubItems.Add(P.Id.ToString());
                item.SubItems.Add(P.Threads.Count.ToString());
                listView1.Items.Add(item);
                a++;
            }

            materialLabel3.Text = "Total Processors : " + a;
        }

        


        Process pr = new Process();
        private void Form1_Load(object sender, EventArgs e)
        {


            listView1.Visible = true;
            materialRaisedButton1.Visible = true;
            materialRaisedButton2.Visible = false;
            opntxtfield1.Visible = false;
            metroLabel1.Visible = false;
            chart1.Visible = false;
            richTextBox1.Visible = false;
            materialLabel4.Visible = false;
            materialLabel3.Visible = true;
            listView2.Visible = false;
            materialRaisedButton3.Visible = false;

            GetAllProcess();
            timer.Start();

            richTextBox1.AppendText("Machine Name :   "+Environment.MachineName);
            richTextBox1.AppendText(Environment.NewLine + "User Name :   " + Environment.UserName);
            richTextBox1.AppendText(Environment.NewLine + "Processor Count :   " + Environment.ProcessorCount.ToString());
            richTextBox1.AppendText(Environment.NewLine + "64 Bit OS :   "  + Environment.Is64BitOperatingSystem.ToString());
            richTextBox1.AppendText(Environment.NewLine + "64 Bit Procss :   "  + Environment.Is64BitProcess.ToString());
            richTextBox1.AppendText(Environment.NewLine + "OS Version :   " + Environment.OSVersion.ToString());
            richTextBox1.AppendText(Environment.NewLine + "OS Version Platform :   " + Environment.OSVersion.Platform.ToString());
            

        }

        private void minventory_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            materialRaisedButton1.Visible = true;
            materialRaisedButton2.Visible = false;
            opntxtfield1.Visible = false;
            metroLabel1.Visible = false;
            chart1.Visible = false;
            GetAllProcess();
            richTextBox1.Visible = false;
            materialLabel4.Visible = false;
            materialLabel3.Visible = true;
            listView2.Visible = false;
            materialRaisedButton3.Visible = false;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            materialRaisedButton1.Visible = false;
            materialRaisedButton2.Visible = true;
            opntxtfield1.Visible = true;
            metroLabel1.Visible = true;
            chart1.Visible = false;
            GetAllProcess();
            richTextBox1.Visible = false;
            materialLabel4.Visible = false;
            materialLabel3.Visible = true;
            listView2.Visible = false;
            materialRaisedButton3.Visible = false;
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            materialRaisedButton1.Visible = false;
            materialRaisedButton2.Visible = false;
            opntxtfield1.Visible = false;
            metroLabel1.Visible = false;
            chart1.Visible = true;
            GetAllProcess();
            richTextBox1.Visible = false;
            materialLabel4.Visible = false;
            materialLabel3.Visible = true;
            listView2.Visible = false;
            materialRaisedButton3.Visible = false;
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        History h = new History();
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                string ab= proc[index].ProcessName;
                h.add("History.txt", ab);
                proc[index].Kill();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GetAllProcess();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(opntxtfield1.Text))
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = opntxtfield1.Text;
                    proc.Start();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            GetAllProcess();
            opntxtfield1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = PCpu.NextValue();
            float fram = PRam.NextValue();
            metroProgressBarCpu.Value = (int)fcpu;
            metroProgressBarRam.Value = (int)fram;
            LblCPU.Text = string.Format("{0:0.00}%", fcpu);
            LblRam.Text = string.Format("{0:0.00}%", fram);


            //chart
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            materialRaisedButton1.Visible = false;
            materialRaisedButton2.Visible = false;
            opntxtfield1.Visible = false;
            metroLabel1.Visible = false;
            chart1.Visible = false;
            richTextBox1.Visible = true;
            materialLabel4.Visible = true;
            materialLabel3.Visible = false;
            listView2.Visible = false;
            materialRaisedButton3.Visible = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (alwaysOnTopToolStripMenuItem.Checked == false)
            {
                alwaysOnTopToolStripMenuItem.Checked = true;
                this.TopMost = true;
            }
            else
            {
                alwaysOnTopToolStripMenuItem.Checked = false;
                this.TopMost = false;
            }
        }

        private void hideWhenMinimizedToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (hideWhenMinimizedToolStripMenuItem.Checked == false)
            {
                hideWhenMinimizedToolStripMenuItem.Checked = true;
                this.ShowInTaskbar = false;
            }
            else
            {
                hideWhenMinimizedToolStripMenuItem.Checked = false;
                this.ShowInTaskbar = true;
            }
        }

        private void runNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browser b = new Browser();
            b.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            h.show_records("History.txt", listView2);
            listView1.Visible = false;
            materialRaisedButton1.Visible = false;
            materialRaisedButton2.Visible = false;
            opntxtfield1.Visible = false;
            metroLabel1.Visible = false;
            chart1.Visible = false;
            richTextBox1.Visible = false;
            materialLabel4.Visible = true;
            materialLabel3.Visible = false;
            listView2.Visible = true;
            materialRaisedButton3.Visible = true;
            
        }

        private void materialRaisedButton3_Click_1(object sender, EventArgs e)
        {
            h.clearhistory("History.txt");
            listView2.Items.Clear();
        }
    }
}
