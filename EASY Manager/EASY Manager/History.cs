using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EASY_Manager
{
    class History
    {
        StreamWriter sw;
        public void add(string txtname , string proname)
        {

            sw = new StreamWriter(txtname, true);
            
            sw.WriteLine(proname.ToLower());
               
            sw.Close();
            
            
        }



        public void show_records(string txtname, ListView l_records)
        {
            try
            {
                string[] arr = File.ReadAllLines(txtname);
            //int c = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                l_records.Items.Add(arr[i]);
                //l_records.Items[c].SubItems.Add(arr[i + 1]);
                //c++;
            }
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public void clearhistory(string txtname)
        {
            try
            {
                File.Delete(txtname);
                MessageBox.Show("History Cleared");
            }
            catch (Exception)
            {

                MessageBox.Show("History Cleared");
            }

        }

    }
}
