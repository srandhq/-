using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{  /// <summary>
/// S：休闲模式
/// </summary>
    public partial class Form9 : Form
    {
        private Image picture1;
        private Image picture2;
        private Image picture3;
        private Image picture4;
        private Image picture5;
        private Image picture6;
        public Form9()
        {
            InitializeComponent();
            string str=null;
            DateTime dt = Convert.ToDateTime("23:59");
            DateTime dt2 = Convert.ToDateTime(System.DateTime.Now.ToString("HH:mm"));
            for (int i = 0; i < TimeTable.conTim; i++)
            {
                if (DateTime.Now.ToShortDateString().ToString() == TimeTable.tim[i].date)//判定日期
                {                  
                    DateTime dt1 = Convert.ToDateTime(TimeTable.tim[i].time);
                 if(dt>dt1)
                    {
                        if (dt1 > dt2)
                        {
                            dt = Convert.ToDateTime(TimeTable.tim[i].time);
                             str = TimeTable.tim[i].ToString();                         
                        }
                    }
                }

            }
            if (str!=null){ 
            listBox1.Items.Add(str.Substring(10));
            // Init_wallpapers();
            }
            else
            {
                listBox1.Items.Add("今天无事件待办");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 normalForm = new Form1();
            normalForm.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        //S:休闲模式下返回到常规模式
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 normalForm = new Form1();
            normalForm.Show();
            this.Hide();
        }
        //S：休闲模式的退出
        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
