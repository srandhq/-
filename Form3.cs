using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //添加事件功能实现
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text==""|| comboBox1.Text=="" || textBox2.Text == "")
            {
                MessageBox.Show("请输入正确事件！");
                return;
            }
            TimeTable.tim[TimeTable.conTim++]=new TimeTable(comboBox2.Text, comboBox1.Text, textBox2.Text, TimeTable.chosetime, false);
            this.Close();
        }


        private void PressKeyEnter(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(ch=='\r')
            {
                button1_Click(sender, e);
            }
        }
    }
}
