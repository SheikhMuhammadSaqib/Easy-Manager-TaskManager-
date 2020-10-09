using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASY_Manager
{
    public partial class Browser : MetroFramework.Forms.MetroForm
    {
        public Browser()
        {
            InitializeComponent();
        }

        
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(listView.FocusedItem != null)
            {
                Process.Start(listFIle[listView.FocusedItem.Index]);
                this.Hide();
                
            }

            
            
        }
        List<string> listFIle = new List<string>();
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            listFIle.Clear();
            listView.Items.Clear();
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your Path." })
            {
                if(fbd.ShowDialog() ==DialogResult.OK)
                {
                    mTxtOpen.Text = fbd.SelectedPath;
                    foreach(string item in Directory.GetFiles(fbd.SelectedPath))
                    {
                        imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                        FileInfo fi = new FileInfo(item);
                        listFIle.Add(fi.FullName);
                        listView.Items.Add(fi.Name,imageList.Images.Count - 1);

                    }
                }
            }

        }
    }
}
