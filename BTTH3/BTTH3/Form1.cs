using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH3
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        StreamReader sr;
        int RightAns, WrongAns;
        public Form1()
        {
            InitializeComponent();
            dt.Columns.Add("Question", typeof(string));
            dt.Columns.Add("Answer", typeof(string));
            dt.Columns.Add("Result", typeof(string));
            GirdTbl.DataSource = dt;
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            //string a = (string)GirdTbl.Rows[1].Cells[1].Value;
            //MessageBox.Show(a);

            //chức năng đọc file Đề
            string path = txtDuongDanFileDe.Text + txtTenFileDe.Text;
            FileInfo fif = new FileInfo(path);
            StreamReader sw = fif.OpenText();
            rtxtBangGhi.Text = sw.ReadToEnd();
            sw.Close();


          
        }

        private void btnDocFileDA_Click(object sender, EventArgs e)
        {
            //chức năng đọc file Đề
            string path = txtDuongDanFileDA.Text + txtTenFileDA.Text;
            FileInfo fif = new FileInfo(path);
            sr  = fif.OpenText();
            string[] lines = File.ReadAllLines(path);
            for(int i = 0; i < lines.Length;i++)
            {
                string quesnumber = "Question " + (i + 1).ToString();
                dt.Rows.Add(quesnumber);
                
            }
            GirdTbl.DataSource = dt;
        }

        private void btnXemDapAn_Click(object sender, EventArgs e)
        {
            //  chức năng check đáp án
            RightAns = WrongAns = 0;
          string path = txtDuongDanFileDA.Text + txtTenFileDA.Text;
          string[] lines = File.ReadAllLines(path);
          int i = 0;
          foreach (string line in lines)
          {
              string a = GirdTbl.Rows[i].Cells[1].Value.ToString();

              if(line.Equals(a.ToUpper()))
              {
                    RightAns++;
              }
              else
              {
                    WrongAns++;
              }
                GirdTbl.Rows[i].Cells[2].Value = line;
              i++;
          }

            txtSoCauDung.Text = RightAns.ToString();
            txtSoCauSai.Text = WrongAns.ToString();
        }
    }
}
