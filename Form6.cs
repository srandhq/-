using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {
        public static string musicstr;
        public Form6()
        {
            InitializeComponent();
            init_Form6();
        }


        private void save_file()
        {
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

        private void init_Form6()
        {
            //【1】创建文件流
            FileStream fs = new FileStream(".\\myfile.txt", FileMode.Open); //FileMode.Open
            //【2】创建读取器
            StreamReader ssr = new StreamReader(fs, Encoding.UTF8);
            //【3】以流的方式读取数据

            string str = ssr.ReadLine();
            string str2 = ssr.ReadLine();
            string str3 = ssr.ReadLine();
            string str4 = ssr.ReadLine();
            string str5 = ssr.ReadLine();

            TimeTable.conTim = 0;//旭：避免切换模式保存重复数据，每次进入该模式必须初始化行数
            while (str != null)
            {
                TimeTable.tim[TimeTable.conTim] = new TimeTable("15:00", "学习", "写上机报告", "2022/3/19", false);
                TimeTable.tim[TimeTable.conTim].date = str;
                TimeTable.tim[TimeTable.conTim].name = str3;
                TimeTable.tim[TimeTable.conTim].time = str2;

                TimeTable.tim[TimeTable.conTim].tag = str4;
                if (str5 == "True")
                {
                    TimeTable.tim[TimeTable.conTim].warn = true;
                }
                else
                    TimeTable.tim[TimeTable.conTim].warn = false;
                TimeTable.conTim++;
                str = ssr.ReadLine();
                str2 = ssr.ReadLine();
                str3 = ssr.ReadLine();
                str4 = ssr.ReadLine();
                str5 = ssr.ReadLine();
            }
            //【4】关闭读取器
            ssr.Close();
            //【5】关闭文件流
            fs.Close();
            save_file();

            //if (listBox1.Items.Count > 0) listBox1.Items.Clear();
            //林：打开软件即进行文件读取，如果读取时间表的日期与当日符合，在ListBox1中添加该事件
            for (int i = 0; i < TimeTable.conTim; i++)
            {
                if (DateTime.Now.ToShortDateString().ToString() == TimeTable.tim[i].date)//判定日期
                {
                    string ret = TimeTable.tim[i].ToString();
                    listBox1.Items.Add(ret.Substring(10));
                    //listBox1.Items.Add(TimeTable.tim[i]);
                    //晨：字体扩大后只读取时间-label-备注，不额外读取日期
                }
            }

            //timer1.Start();


            //初始时读取文件
            //后面每次修改都存入文件
        }


        //旭：关闭主窗口，则退出程序
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_file();
            Application.Exit();
        }

        //旭：打开常规模式，隐藏简洁模式
          
        private void 模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 normalForm = new Form1();
            normalForm.Show();
            this.Hide();
            save_file();
        }

        /*
        //旭：右键菜单
        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(listBox1, e.Location);
                int index = listBox1.IndexFromPoint(e.Location);
                if (index >= 0)
                {
                    listBox1.SetSelected(index, true);
                    menuItem_add.Enabled = true;
                    menuItem_alter.Enabled = true;
                    menuItem_del.Enabled = true;
                    menuItem_alter.Visible = true;
                    menuItem_del.Visible = true;
                }
                else
                {
                    menuItem_alter.Visible = false;
                    menuItem_del.Visible = false;
                }
            }
        }
        */


        //旭：添加按钮
        private void menuItem_add_Click(object sender, EventArgs e)
        {
            Form3 add_item_dlg = new Form3();
            add_item_dlg.ShowDialog();
            //save_file();
            listBox1.Items.Clear();
            for (int i = 0; i < TimeTable.conTim; i++)
            {
                if (TimeTable.tim[i].date == TimeTable.chosetime)
                {
                    listBox1.Items.Add(TimeTable.tim[i]);
                }
            }
        }

        //旭：修改按钮
        private void menuItem_alter_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("请先选择要修改的事件！");
            }
            else
            {
                string txt = listBox1.SelectedItem.ToString();
                string date, time, tag, name;
                for (int i = index; i < TimeTable.conTim; i++)
                {
                    date = TimeTable.tim[i].date;
                    time = TimeTable.tim[i].time;
                    tag = TimeTable.tim[i].tag;
                    name = TimeTable.tim[i].name;
                    if (txt == date + "\t" + time + "\t" + tag + "\t" + name)
                    {
                        TimeTable.temp[0] = TimeTable.tim[i];//将选中的修改事件赋给暂存数组
                        Form4 alter_item_dlg = new Form4();
                        alter_item_dlg.ShowDialog();
                        TimeTable.tim[i] = TimeTable.temp[0];//暂存数组赋给tim[i]
                        break;
                    }
                }
                save_file();
                //刷新listbox
                listBox1.Items.Clear();
                for (int i = 0; i < TimeTable.conTim; i++)
                {
                    if (TimeTable.tim[i].date == TimeTable.chosetime)
                    {
                        string ret = TimeTable.tim[i].ToString();
                        char[] arr = new char[ret.Length - 10];                    
                        for(int j = 0; j < ret.Length-10; j++)
                        {
                            arr[j] = ret[j + 10];
                        }
                        listBox1.Items.Add(arr);
                    }
                }
            }
        }

        //旭：删除按钮
        private void menuItem_del_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("请先选择要删除的事件！");
            }
            else
            {
                string txt = this.listBox1.SelectedItem.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string date, time, tag, name;
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    for (int i = index; i < TimeTable.conTim - 1; i++)
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
                    save_file();
                }
            }
        }

        //旭：选择日期，copy过来的
        /*private void choose_date(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo hitInfo = monthCalendar1.HitTest(e.Location);
            if (hitInfo.HitArea == MonthCalendar.HitArea.Date)//当选择了日期后
            {
                string date = monthCalendar1.SelectionStart.ToString("yyyy/M/d");
                listBox1.Items.Clear();
                for (int i = 0; i < TimeTable.conTim; i++)
                {
                    if (date == TimeTable.tim[i].date)
                    {
                        listBox1.Items.Add(TimeTable.tim[i]);
                    }
                }
            }

        }*/

        //旭:copy过来的
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 10;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
