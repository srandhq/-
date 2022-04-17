using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            for (int i=0;i<TimeTable.conTim;i++) {
                if (TimeTable.chosetime== TimeTable.tim[i].date)//判定日期
                {
                    listBox1.Items.Add(TimeTable.tim[i]);
                }
            }
            //}

        }
        public void Table()
        {
            
        }

        //添加按钮
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 formm = new Form3();
            formm.ShowDialog();
            listBox1.Items.Clear();
            for (int i = 0; i < TimeTable.conTim; i++)
            {
                if (TimeTable.tim[i].date == TimeTable.chosetime)
                {
                    listBox1.Items.Add(TimeTable.tim[i]);
                }
            }
        }

        //旭：删改
        //删除按钮
        private void button3_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            int count = this.listBox1.SelectedIndices.Count;
            if (index == -1)
            {
                MessageBox.Show("请先选择要删除的事件！");
            }
            else
            {
                //晨：多项删除已解决
                DialogResult dr = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string date, time, tag, name;

                    for (int j = 0; j < count; j++)
                    {
                        int indexx = count - 1 - j;
                        int deleteIndexx = this.listBox1.SelectedIndices[indexx];
                        string txt = this.listBox1.Items[listBox1.SelectedIndices[indexx]].ToString();
                        this.listBox1.Items.RemoveAt(deleteIndexx);
                        for (int i = 0; i < TimeTable.conTim - 1; i++)
                        {
                            date = TimeTable.tim[i].date;
                            time = TimeTable.tim[i].time;
                            tag = TimeTable.tim[i].tag;
                            name = TimeTable.tim[i].name;
                            if (txt == date + "\t" + time + "\t" + tag + "\t" + name)//找到在数组中的下标
                            {
                                for (int k = i; k < TimeTable.conTim - 1; k++)
                                {
                                    TimeTable.tim[k] = TimeTable.tim[k + 1];
                                }
                                break;
                            }
                        }
                        TimeTable.conTim--;
                    }

                    //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                   
                }
            }
        }

        //旭：删改
        //修改按钮
        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("请先选择要修改的事件！");
            }
            else
            {
                string date, time, tag, name;
                string txt = listBox1.SelectedItem.ToString();
                for (int i=index;i<TimeTable.conTim;i++)
                {
                    date = TimeTable.tim[i].date;
                    time = TimeTable.tim[i].time;
                    tag = TimeTable.tim[i].tag;
                    name = TimeTable.tim[i].name;
                    if (txt == date + "\t" + time + "\t" + tag + "\t" + name) 
                    {
                        TimeTable.temp[0] = TimeTable.tim[i];//将选中的修改事件赋给暂存数组
                        Form4 formmm = new Form4();
                        formmm.ShowDialog();
                        TimeTable.tim[i] = TimeTable.temp[0];//暂存数组赋给tim[i]
                        break;
                    }
                }
                //刷新listbox
                listBox1.Items.Clear();
                for (int i = 0; i < TimeTable.conTim; i++)
                {
                    if (TimeTable.tim[i].date == TimeTable.chosetime)
                    {
                        listBox1.Items.Add(TimeTable.tim[i]);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();

        }

        //旭：关闭窗口时自动保存
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭窗口则保存文件
            //【1】创建文件流（文件模式为：重写）
            FileStream fs = new FileStream(".\\myfile.txt", FileMode.Create);
            //【2】创建写入器
            StreamWriter sw = new StreamWriter(fs);
            //【3】以流的方式“逐行”写入数据
            for (int i = 0; i < TimeTable.conTim; i++)
            {
                sw.Write(TimeTable.tim[i].date + "\r");
                //sw.Write("\n");
                sw.Write(TimeTable.tim[i].time + "\r");
                //sw.Write("\n");
                sw.Write(TimeTable.tim[i].name + "\r");
                //sw.Write("\n");
                sw.Write(TimeTable.tim[i].tag + "\r");
                //sw.Write("\n");
                sw.Write(TimeTable.tim[i].warn + "\r");
                //sw.Write("\n");


            }
            //【4】关闭写入器
            sw.Close();
            //【5】关闭文件流
            fs.Close();
        }
    }
}
