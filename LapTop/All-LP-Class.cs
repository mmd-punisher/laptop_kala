using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTop
{
    internal class All_LP_Class
    {
        public All_LPForm frm11 = null;
        public void SearchLaptop()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Parto\Desktop\files final\All-LP.txt");
            string ALLlp = sr.ReadToEnd();
            sr.Close();
            string[] xz = ALLlp.Split('\n');
            string xm = frm11.textBoxSearch.Text;
            DataTable dt = new DataTable();
            dt.Columns.Add("Brand");
            dt.Columns.Add("Model");
            dt.Columns.Add("CPU");
            dt.Columns.Add("GPU");
            dt.Columns.Add("Display");
            dt.Columns.Add("Memory");
            dt.Columns.Add("Storage C");

            for (int i = 0; i < 8; i++)//tedad laptop ya khat ha
            {
                for (int j = 0; j < 7; j++)
                {
                    string[] info = xz[i].Split('-');
                    if (xm == info[j])
                    {
                        dt.Rows.Add(info[0], info[1], info[2], info[3], info[4], info[5], info[6]);
                        frm11.dataGridView1.DataSource = dt;//sabt shodan dar dgv
                        break;
                    }
                }
            }
        }
        public void LaptopShow()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Parto\Desktop\files final\All-LP.txt");
            string ALLlp = sr.ReadToEnd();
            sr.Close();
            string[] xz = ALLlp.Split('\n');
            DataTable dt = new DataTable();
            dt.Columns.Add("Brand");
            dt.Columns.Add("Model");
            dt.Columns.Add("CPU");
            dt.Columns.Add("GPU");
            dt.Columns.Add("Display");
            dt.Columns.Add("Memory");
            dt.Columns.Add("Storage C");

            for (int i = 0; i < xz.Length - 1; i++)
            {
                string[] info = xz[i].Split('-');
                dt.Rows.Add(info[0], info[1], info[2], info[3], info[4], info[5], info[6]);
            }
            frm11.dataGridView1.DataSource = dt;
        }
        public void DeleteLaptop()
        {
            for (int i = frm11.dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                if ((bool)frm11.dataGridView1.Rows[i].Cells[0].FormattedValue == true)
                {
                    frm11.dataGridView1.Rows.RemoveAt(i);
                }
            }
        }
        public void SaveLaptop()
        {
            StreamWriter re = new StreamWriter(@"C:\Users\Parto\Desktop\files final\All-LP.txt");
            re.Write("");
            re.Close();
            for (int i = 0; i < frm11.dataGridView1.Rows.Count - 1; i++)
            {
                string saveData = Convert.ToString(frm11.dataGridView1.Rows[i].Cells[1].ToolTipText) + "-" +
                                  Convert.ToString(frm11.dataGridView1.Rows[i].Cells[2].ToolTipText) + "-" +
                                  Convert.ToString(frm11.dataGridView1.Rows[i].Cells[3].ToolTipText) + "-" +
                                  Convert.ToString(frm11.dataGridView1.Rows[i].Cells[4].ToolTipText) + "-" +
                                  Convert.ToString(frm11.dataGridView1.Rows[i].Cells[5].ToolTipText) + "-" +
                                  Convert.ToString(frm11.dataGridView1.Rows[i].Cells[6].ToolTipText) + "-" +
                                  Convert.ToString(frm11.dataGridView1.Rows[i].Cells[7].ToolTipText) + "\n";
                File.AppendAllText(@"C:\Users\Parto\Desktop\files final\All-LP.txt", saveData);
            }
        }
    }
}
