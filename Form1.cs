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


//using System.Timers;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Image picture1;
        private Image picture2;
        private Image picture3;
        private Image picture4;
        private Image picture5;
        private Image picture6;
        public static string musicstr;
 

        public Form1()
        {
            InitializeComponent();
            Init_wallpapers();
            Init_songs();
            //S：控件透明化
            label3.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            button2.BackColor = Color.FromArgb(100, 220, 220, 220);
            button2.Parent = pictureBox1;

            //【1】创建文件流
            FileStream fs = new FileStream(".\\myfile.txt", FileMode.Open); //FileMode.Open
            //【2】创建读取器
            StreamReader ssr = new StreamReader(fs,Encoding.UTF8);
            //【3】以流的方式读取数据

            string str = ssr.ReadLine();
            string str2 = ssr.ReadLine();
            string str3 = ssr.ReadLine();
            string str4 = ssr.ReadLine();
            string str5 = ssr.ReadLine();

            TimeTable.conTim = 0;//旭：避免切换模式保存重复数据，每次进入该模式必须初始化行数
            while (str!=null)
            {
                TimeTable.tim[TimeTable.conTim] = new TimeTable("15:00", "学习", "写上机报告", "2022/3/19", false);
                TimeTable.tim[TimeTable.conTim].date= str;
                TimeTable.tim[TimeTable.conTim].name = str3;
                TimeTable.tim[TimeTable.conTim].time =str2;
                
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

            //listBox1.BackColor = Color.Transparent;
            //晨：设置背景色为透明


            //if (listBox1.Items.Count > 0) listBox1.Items.Clear();
            //林：打开软件即进行文件读取，如果读取时间表的日期与当日符合，在ListBox1中添加该事件
            for (int i = 0; i < TimeTable.conTim; i++)
            {
                if (DateTime.Now.ToShortDateString().ToString() == TimeTable.tim[i].date)//判定日期
                {
                    listBox1.Items.Add(TimeTable.tim[i]);
                }
            }

            //晨：添加了显示当月待办事项的列表
            for (int i = 0; i < TimeTable.conTim; i++)
            {
                if ((DateTime.Now.ToShortDateString().ToString()).Substring(0,7) == (TimeTable.tim[i].date).Substring(0, 7))//判定日期
                {
                    listBox2.Items.Add(TimeTable.tim[i]);
                    
                }
            }
            sortlistbox2();

            timer.Start();
             
             
             //初始时读取文件
             //后面每次修改都存入文件
        }

        //晨：月待办窗口的排序函数
        private void sortlistbox2()
        {
            int sum = listBox2.Items.Count;
            int []value=new int[sum];
            for (int i = 0; i < sum; i++)
            {
                if((listBox2.Items[i].ToString()).Substring(8, 1)=="\t")
                {
                    value[i] = int.Parse((listBox2.Items[i].ToString()).Substring(7, 1));
                }
                else
                {
                    value[i]= int.Parse((listBox2.Items[i].ToString()).Substring(7, 2));
                }
            }
            for (int i = 1; i < sum; i++)
            {
                for (int j = sum - 1; j >= i; j--)
                {
                    if (value[j - 1] > value[j])
                    {
                        string str = (listBox2.Items[j - 1]).ToString();
                        listBox2.Items[j - 1] = listBox2.Items[j];
                        listBox2.Items[j] = str;
                        int k = value[j - 1];
                        value[j - 1] = value[j];
                        value[j] = k;
                    }
                }
            }
            
        }

        private void Init_wallpapers()
        {
            picture1 = Properties.Resources.老年壁纸1;
            picture2 = Properties.Resources.老年壁纸2;
            picture3 = Properties.Resources.老年壁纸3;
            picture4 = Properties.Resources.老年壁纸4;
            picture5 = Properties.Resources.老年壁纸5;
            picture6 = Properties.Resources.老年壁纸6;
            老年壁纸1ToolStripMenuItem.Checked = true;
            老年壁纸2ToolStripMenuItem.Checked = false;
            老年壁纸3ToolStripMenuItem.Checked = false;
            老年壁纸4ToolStripMenuItem.Checked = false;
            老年壁纸5ToolStripMenuItem.Checked = false;
            老年壁纸6ToolStripMenuItem.Checked = false;
            自定义壁纸ToolStripMenuItem.Checked = false;

            默认字体ToolStripMenuItem.Checked = true;
            宋体ToolStripMenuItem.Checked = false;
            粗体ToolStripMenuItem.Checked = false;
            楷体ToolStripMenuItem.Checked = false;
        }

        private void Init_songs()
        {
            默认铃声ToolStripMenuItem.Checked = false;
            稻香ToolStripMenuItem.Checked= true;
            狼给的诱惑ToolStripMenuItem.Checked = false;
            爱情买卖ToolStripMenuItem.Checked = false;
            酒醉的蝴蝶ToolStripMenuItem.Checked = false;
        }

        //旭：把保存文件函数提取出来
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


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 10;
        }

        

        //查看当日事件按钮
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") 
            {
                MessageBox.Show("请选择日期！");
                return;
            }
            //林：该行代码已在日历中点击某一天后实现
            //textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            TimeTable.chosetime = textBox1.Text;
            //form2 f = new form2();
            //f.ShowDialog();
            //MessageBox.Show( "我TM莱纳！！！","社会你虎哥");

            Form2 form = new Form2();
            form.ShowDialog();

        }

        private void 搜索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 forrm = new Form5();
            forrm.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("切换模式:\n切换简洁模式：常规模式下，菜单栏选择模式→简洁模式。\n切换常规模式：简洁模式下，单击常规模式。\n\n查看指定日期事件：所有模式下均为单击指定日期，查看时间框。\n编辑事件：\n常规模式下，先在日历中单击指定日期→编辑时间→选择添加 / 修改 / 删除事件，完成后，再次单击该日期以查看当日事件。\n\n个性化：\n更换壁纸：常规模式下，菜单栏选择个性化→个性化背景→选择壁纸。\n更换字体：常规模式下，菜单栏选择个性化→个性化字体→选择字体。\n设置铃声：常规模式下，菜单栏选择个性化→个性化铃声→选择铃声。\n\n搜索事件：\n常规模式下，菜单栏选择搜索事件→输入事件→点击搜索。", "使用指南：");
        }



        private void ChooseDate(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo hitInfo = monthCalendar1.HitTest(e.Location);
            if (hitInfo.HitArea == MonthCalendar.HitArea.Date)//当选择了日期后
            {
                textBox1.Text = monthCalendar1.SelectionStart.ToString("yyyy/M/d");
                listBox1.Items.Clear();
                for (int i = 0; i < TimeTable.conTim; i++)
                 {
                     if (monthCalendar1.SelectionStart.ToString("yyyy/M/d") == TimeTable.tim[i].date)
                     {
                         listBox1.Items.Add(TimeTable.tim[i]);
                     }
                 }
            }
        }

        //S：鼠标碰到时button按钮颜色加深
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button2.FlatStyle = FlatStyle.Flat; //样式
            button2.ForeColor = Color.Transparent;//前景
            button2.BackColor = Color.Transparent;//去背景
            button2.FlatAppearance.BorderSize = 0;//去边线
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 40, 60, 82);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 40, 60, 82);
        }
        //旭：打开简洁模式窗口，关闭（隐藏）常规模式窗口
        private void 简介模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //先保存文件再切换模式
            save_file();
            
            Form6 simpleForm = new Form6();
            simpleForm.Show();
            this.Hide();

        }
        

        //旭：关闭主窗口时退出程序
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭窗口前保存文件
            save_file();

            Application.Exit();
        }

        private void 老年壁纸1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picture1;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            老年壁纸1ToolStripMenuItem.Checked = true;
            老年壁纸2ToolStripMenuItem.Checked = false;
            老年壁纸3ToolStripMenuItem.Checked = false;
            老年壁纸4ToolStripMenuItem.Checked = false;
            老年壁纸5ToolStripMenuItem.Checked = false;
            老年壁纸6ToolStripMenuItem.Checked = false;
            自定义壁纸ToolStripMenuItem.Checked = false;
        }

        private void 老年壁纸2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picture2;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            老年壁纸1ToolStripMenuItem.Checked = false;
            老年壁纸2ToolStripMenuItem.Checked = true;
            老年壁纸3ToolStripMenuItem.Checked = false;
            老年壁纸4ToolStripMenuItem.Checked = false;
            老年壁纸5ToolStripMenuItem.Checked = false;
            老年壁纸6ToolStripMenuItem.Checked = false;
            自定义壁纸ToolStripMenuItem.Checked = false;
        }

        private void 老年壁纸3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picture3;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            老年壁纸1ToolStripMenuItem.Checked = false;
            老年壁纸2ToolStripMenuItem.Checked = false;
            老年壁纸3ToolStripMenuItem.Checked = true;
            老年壁纸4ToolStripMenuItem.Checked = false;
            老年壁纸5ToolStripMenuItem.Checked = false;
            老年壁纸6ToolStripMenuItem.Checked = false;
            自定义壁纸ToolStripMenuItem.Checked = false;
        }

        private void 老年壁纸4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picture4;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            老年壁纸1ToolStripMenuItem.Checked = false;
            老年壁纸2ToolStripMenuItem.Checked = false;
            老年壁纸3ToolStripMenuItem.Checked = false;
            老年壁纸4ToolStripMenuItem.Checked = true;
            老年壁纸5ToolStripMenuItem.Checked = false;
            老年壁纸6ToolStripMenuItem.Checked = false;
            自定义壁纸ToolStripMenuItem.Checked = false;
        }

        private void 老年壁纸5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picture5;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            老年壁纸1ToolStripMenuItem.Checked = false;
            老年壁纸2ToolStripMenuItem.Checked = false;
            老年壁纸3ToolStripMenuItem.Checked = false;
            老年壁纸4ToolStripMenuItem.Checked = false;
            老年壁纸5ToolStripMenuItem.Checked = true;
            老年壁纸6ToolStripMenuItem.Checked = false;
            自定义壁纸ToolStripMenuItem.Checked = false;
        }

        private void 老年壁纸6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picture6;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            老年壁纸1ToolStripMenuItem.Checked = false;
            老年壁纸2ToolStripMenuItem.Checked = false;
            老年壁纸3ToolStripMenuItem.Checked = false;
            老年壁纸4ToolStripMenuItem.Checked = false;
            老年壁纸5ToolStripMenuItem.Checked = false;
            老年壁纸6ToolStripMenuItem.Checked = true;
            自定义壁纸ToolStripMenuItem.Checked = false;
        }

        //旭：播放铃声函数
        private void Play(string str)
        {
            label1.Text = "当前时间：" + System.DateTime.Now.ToString("HH:mm:ss");
            for (int i = 0; i < TimeTable.conTim; i++)
            {
                if (TimeTable.tim[i].date == DateTime.Now.ToShortDateString().ToString())
                {
                    DateTime dt1 = Convert.ToDateTime(TimeTable.tim[i].time);
                    DateTime dt2 = Convert.ToDateTime(System.DateTime.Now.ToString("HH:mm"));
                    if (DateTime.Compare(dt2, dt1) >= 0 && TimeTable.tim[i].warn == false)
                    {
                        //林：创建WMP对象来播放mp3
                        notice.URL = str;
                        TimeTable.tim[i].warn = true;
                        if (MessageBox.Show(TimeTable.tim[i].name + "  时间到了！", "温馨提示") == DialogResult.OK)
                        {
                            notice.Ctlcontrols.stop();
                        }
                    }
                }
            }
        }

        private void 默认铃声ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认铃声ToolStripMenuItem.Checked = true;
            稻香ToolStripMenuItem.Checked = false;
            爱情买卖ToolStripMenuItem.Checked = false;
            酒醉的蝴蝶ToolStripMenuItem.Checked = false;
            狼给的诱惑ToolStripMenuItem.Checked = false;
        }


        private void 酒醉的蝴蝶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认铃声ToolStripMenuItem.Checked = false;
            稻香ToolStripMenuItem.Checked = false;
            爱情买卖ToolStripMenuItem.Checked = false;
            酒醉的蝴蝶ToolStripMenuItem.Checked = true;
            狼给的诱惑ToolStripMenuItem.Checked = false;
        }

        private void 狼给的诱惑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认铃声ToolStripMenuItem.Checked = false;
            稻香ToolStripMenuItem.Checked = false;
            爱情买卖ToolStripMenuItem.Checked = false;
            酒醉的蝴蝶ToolStripMenuItem.Checked = false;
            狼给的诱惑ToolStripMenuItem.Checked = true;
        }

        private void 爱情买卖ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认铃声ToolStripMenuItem.Checked = false;
            稻香ToolStripMenuItem.Checked = false;
            爱情买卖ToolStripMenuItem.Checked = true;
            酒醉的蝴蝶ToolStripMenuItem.Checked = false;
            狼给的诱惑ToolStripMenuItem.Checked = false;
        }

        private void 稻香ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认铃声ToolStripMenuItem.Checked = false;
            稻香ToolStripMenuItem.Checked = true;
            爱情买卖ToolStripMenuItem.Checked = false;
            酒醉的蝴蝶ToolStripMenuItem.Checked = false;
            狼给的诱惑ToolStripMenuItem.Checked = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (稻香ToolStripMenuItem.Checked)
                Play("稻香.mp3");
            if (默认铃声ToolStripMenuItem.Checked)
                Play("ring.mp3");
            if (爱情买卖ToolStripMenuItem.Checked)
                Play("爱情买卖.mp3");
            if (酒醉的蝴蝶ToolStripMenuItem.Checked)
                Play("酒醉的蝴蝶.mp3");
            if (狼给的诱惑ToolStripMenuItem.Checked)
                Play("郎的诱惑.mp3");
            if (!(稻香ToolStripMenuItem.Checked|| 默认铃声ToolStripMenuItem.Checked|| 爱情买卖ToolStripMenuItem.Checked|| 酒醉的蝴蝶ToolStripMenuItem.Checked|| 狼给的诱惑ToolStripMenuItem.Checked))
                Play(musicstr);
            //晨：当选择自定义铃声时，关掉所有其他铃声并通过自定义路径播放选中mp3文件；
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //晨：自定义壁纸
        private void 自定义壁纸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  //显示选择文件对话框
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "(*.jpg)|*.jpg"; //所有的文件格式
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            老年壁纸1ToolStripMenuItem.Checked = false;
            老年壁纸2ToolStripMenuItem.Checked = false;
            老年壁纸3ToolStripMenuItem.Checked = false;
            老年壁纸4ToolStripMenuItem.Checked = false;
            老年壁纸5ToolStripMenuItem.Checked = false;
            老年壁纸6ToolStripMenuItem.Checked = false;
            自定义壁纸ToolStripMenuItem.Checked = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fname = openFileDialog1.FileName;   //显示文件路径
                
                pictureBox1.Image = Image.FromFile(fname);
                //pictureBox1.Image = fname;
                //BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            }

        }


        //晨：自定义铃声
        private void 自定义铃声ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认铃声ToolStripMenuItem.Checked = false;
            稻香ToolStripMenuItem.Checked = false;
            爱情买卖ToolStripMenuItem.Checked = false;
            酒醉的蝴蝶ToolStripMenuItem.Checked = false;
            狼给的诱惑ToolStripMenuItem.Checked = false;
            自定义铃声ToolStripMenuItem.Checked = true;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  //显示选择文件对话框
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "(*.mp3)|*.mp3"; //所有的文件格式
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                默认铃声ToolStripMenuItem.Checked = false;
                稻香ToolStripMenuItem.Checked = false;
                爱情买卖ToolStripMenuItem.Checked = false;
                酒醉的蝴蝶ToolStripMenuItem.Checked = false;
                狼给的诱惑ToolStripMenuItem.Checked = false;
                string fname = openFileDialog1.FileName;   //显示文件路径
                musicstr = fname;
                
            }
        }

        

        private void 宋体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认字体ToolStripMenuItem.Checked = false;
            宋体ToolStripMenuItem.Checked = true;
            粗体ToolStripMenuItem.Checked = false;
            楷体ToolStripMenuItem.Checked = false;
            幼圆ToolStripMenuItem.Checked = false;
            彩云ToolStripMenuItem.Checked = false;
            menuStrip1.Font = new Font("宋体", label1.Font.Size, label1.Font.Style);
            label1.Font = new Font("宋体", label1.Font.Size, label1.Font.Style);
            label3.Font = new Font("宋体", label1.Font.Size, label1.Font.Style);
            button2.Font = new Font("宋体", label1.Font.Size, label1.Font.Style);
            textBox1.Font = new Font("宋体", label1.Font.Size, label1.Font.Style);
            listBox1.Font = new Font("宋体", label1.Font.Size, label1.Font.Style);
            monthCalendar1.Font = new Font("宋体", label1.Font.Size, label1.Font.Style);
        }

        private void 默认字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认字体ToolStripMenuItem.Checked = true;
            宋体ToolStripMenuItem.Checked = false;
            粗体ToolStripMenuItem.Checked = false;
            楷体ToolStripMenuItem.Checked = false;
            幼圆ToolStripMenuItem.Checked = false;
            彩云ToolStripMenuItem.Checked = false;
            menuStrip1.Font = new Font("微软雅黑", label1.Font.Size, label1.Font.Style);
            label1.Font = new Font("微软雅黑", label1.Font.Size, label1.Font.Style);
            label3.Font = new Font("微软雅黑", label1.Font.Size, label1.Font.Style);
            button2.Font = new Font("微软雅黑", label1.Font.Size, label1.Font.Style);
            textBox1.Font = new Font("微软雅黑", label1.Font.Size, label1.Font.Style);
            listBox1.Font = new Font("微软雅黑", label1.Font.Size, label1.Font.Style);
            monthCalendar1.Font = new Font("微软雅黑", label1.Font.Size, label1.Font.Style);
        }

        private void 粗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认字体ToolStripMenuItem.Checked = false;
            宋体ToolStripMenuItem.Checked = false;
            粗体ToolStripMenuItem.Checked = true;
            楷体ToolStripMenuItem.Checked = false;
            幼圆ToolStripMenuItem.Checked = false;
            彩云ToolStripMenuItem.Checked = false;
            menuStrip1.Font = new Font("华文琥珀", label1.Font.Size, label1.Font.Style);
            label1.Font = new Font("华文琥珀", label1.Font.Size, label1.Font.Style);
            label3.Font = new Font("华文琥珀", label1.Font.Size, label1.Font.Style);
            button2.Font = new Font("华文琥珀", label1.Font.Size, label1.Font.Style);
            textBox1.Font = new Font("华文琥珀", label1.Font.Size, label1.Font.Style);
            listBox1.Font = new Font("华文琥珀", label1.Font.Size, label1.Font.Style);
            monthCalendar1.Font = new Font("华文琥珀", label1.Font.Size, label1.Font.Style);
        }

        private void 楷体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认字体ToolStripMenuItem.Checked = false;
            宋体ToolStripMenuItem.Checked = false;
            粗体ToolStripMenuItem.Checked = false;
            楷体ToolStripMenuItem.Checked = true;
            幼圆ToolStripMenuItem.Checked = false;
            彩云ToolStripMenuItem.Checked = false;
            menuStrip1.Font = new Font("楷体", label1.Font.Size, label1.Font.Style);
            label1.Font = new Font("楷体", label1.Font.Size, label1.Font.Style);
            label3.Font = new Font("楷体", label1.Font.Size, label1.Font.Style);
            button2.Font = new Font("楷体", label1.Font.Size, label1.Font.Style);
            textBox1.Font = new Font("楷体", label1.Font.Size, label1.Font.Style);
            listBox1.Font = new Font("楷体", label1.Font.Size, label1.Font.Style);
            monthCalendar1.Font = new Font("楷体", label1.Font.Size, label1.Font.Style);
        }

        private void 幼圆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认字体ToolStripMenuItem.Checked = false;
            宋体ToolStripMenuItem.Checked = false;
            粗体ToolStripMenuItem.Checked = false;
            楷体ToolStripMenuItem.Checked = false;
            幼圆ToolStripMenuItem.Checked = true;
            彩云ToolStripMenuItem.Checked = false;
            menuStrip1.Font = new Font("幼圆", label1.Font.Size, label1.Font.Style);
            label1.Font = new Font("幼圆", label1.Font.Size, label1.Font.Style);
            label3.Font = new Font("幼圆", label1.Font.Size, label1.Font.Style);
            button2.Font = new Font("幼圆", label1.Font.Size, label1.Font.Style);
            textBox1.Font = new Font("幼圆", label1.Font.Size, label1.Font.Style);
            listBox1.Font = new Font("幼圆", label1.Font.Size, label1.Font.Style);
            monthCalendar1.Font = new Font("幼圆", label1.Font.Size, label1.Font.Style);
        }

        private void 彩云ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            默认字体ToolStripMenuItem.Checked = false;
            宋体ToolStripMenuItem.Checked = false;
            粗体ToolStripMenuItem.Checked = false;
            楷体ToolStripMenuItem.Checked = false;
            幼圆ToolStripMenuItem.Checked = false;
            彩云ToolStripMenuItem.Checked = true;
            menuStrip1.Font = new Font("华文彩云", label1.Font.Size, label1.Font.Style);
            label1.Font = new Font("华文彩云", label1.Font.Size, label1.Font.Style);
            label3.Font = new Font("华文彩云", label1.Font.Size, label1.Font.Style);
            button2.Font = new Font("华文彩云", label1.Font.Size, label1.Font.Style);
            textBox1.Font = new Font("华文彩云", label1.Font.Size, label1.Font.Style);
            listBox1.Font = new Font("华文彩云", label1.Font.Size, label1.Font.Style);
            monthCalendar1.Font = new Font("华文彩云", label1.Font.Size, label1.Font.Style);
        }
        //S:其他模式的函数窗口
        private void 其他模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_file();

            Form8 simpleForm = new Form8();
            simpleForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {

        }
        //S:星座模式的函数窗口
        private void 星座模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_file();
            Form9 simpleForm = new Form9();
            simpleForm.Show();
            this.Hide();

        }
    }

}





