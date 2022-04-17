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
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            //万年历模式下的显示十二个月的日历
            monthCalendar1.CalendarDimensions = new System.Drawing.Size(4, 3);
        }
        //S：点击×退出
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        //S：点击常规模式时返回常规模式
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 normalForm = new Form1();
            normalForm.Show();
            this.Hide();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
           
        }
    }
}
