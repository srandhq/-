using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        //晨：原搜索的基础上增加限定日期功能
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            bool find = false;
            //没限定日期
            if ((textBox2.Text=="")&&(textBox3.Text=="")) {
                string str = textBox1.Text.ToString();
                int sum = TimeTable.conTim;
                for (int i = 0; i < sum; i++)
                {
                    if (TimeTable.tim[i].name.Contains(str) || TimeTable.tim[i].tag.Contains(str))
                    {
                        listBox1.Items.Add(TimeTable.tim[i]);
                        find = true;
                    }
                }
            }
            //某日期之后......
            else if((textBox2.Text != "") && (textBox3.Text == ""))
            {
                DateTime t1 = DateTime.Parse(textBox2.Text);
                string str = textBox1.Text.ToString();
                int sum = TimeTable.conTim;
                for (int i = 0; i < sum; i++)
                {
                    DateTime t3 = DateTime.Parse(TimeTable.tim[i].date);
                    if ((TimeTable.tim[i].name.Contains(str) || TimeTable.tim[i].tag.Contains(str)) && (t3 >= t1))
                    {
                        listBox1.Items.Add(TimeTable.tim[i]);
                        find = true;
                    }
                }
            }
            //某日期之前......
            else if((textBox2.Text == "") && (textBox3.Text != ""))
            {
                DateTime t2 = DateTime.Parse(textBox3.Text);
                string str = textBox1.Text.ToString();
                int sum = TimeTable.conTim;
                for (int i = 0; i < sum; i++)
                {
                    DateTime t3 = DateTime.Parse(TimeTable.tim[i].date);
                    if ((TimeTable.tim[i].name.Contains(str) || TimeTable.tim[i].tag.Contains(str))&& (t3 <= t2))
                    {
                        listBox1.Items.Add(TimeTable.tim[i]);
                        find = true;
                    }
                }
            }
            //两日期之间
            else
            {               
                DateTime t1 = DateTime.Parse(textBox2.Text);
                DateTime t2 = DateTime.Parse(textBox3.Text);
                string str = textBox1.Text.ToString();
                int sum = TimeTable.conTim;
                for (int i = 0; i < sum; i++)
                {
                    DateTime t3 = DateTime.Parse(TimeTable.tim[i].date);
                    if ((TimeTable.tim[i].name.Contains(str) || TimeTable.tim[i].tag.Contains(str))&&(t3>=t1)&&(t3<=t2))
                    {
                        listBox1.Items.Add(TimeTable.tim[i]);
                        find = true;
                    }
                }
            }
            if (!find)
            {
                MessageBox.Show("未查询到相应事件！");
            }
        }

        //搜索事件回车响应
        private void Form5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '\r')
            {
                button1_Click(sender, e);
            }
        }

        //晨：限定范围的高级搜索
        private void button2_Click(object sender, EventArgs e)
        {
            Form7 forrm7 = new Form7();
            forrm7.ShowDialog();
        }
    }
}
