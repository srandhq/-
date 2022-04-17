using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            init_Form4();
        }


        //旭：初始化修改事件框
        private void init_Form4() {
            comboBox2.Text = TimeTable.temp[0].time;//time赋值
            comboBox1.Text = TimeTable.temp[0].tag;//tag赋值
            textBox2.Text = TimeTable.temp[0].name;//name赋值
        } 
        //旭：删改
        private void button1_Click(object sender, EventArgs e)
        {
            string date = TimeTable.temp[0].date;
            string time = TimeTable.temp[0].time;
            string tag = TimeTable.temp[0].tag;
            string name = TimeTable.temp[0].name;
            if (comboBox1.Text == "" || comboBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("请输入正确事件！");
                return;
            }
            else if (comboBox2.Text == time && comboBox1.Text == tag && textBox2.Text == name)
            {
                MessageBox.Show("新旧事件不能相同！");
                return;
            }
            else
            {
                TimeTable.temp[0] = new TimeTable(comboBox2.Text, comboBox1.Text, textBox2.Text, date, false);
                this.Close();
            }

        }


        //旭：修改按钮添加回车响应
        private void Form4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '\r')
            {
                button1_Click(sender, e);
            }
        }
    }
}
