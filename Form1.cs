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
            label2.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            button2.BackColor = Color.FromArgb(100, 220, 220, 220);
            button2.Parent = pictureBox1;
            button1.BackColor = Color.FromArgb(100, 220, 220, 220);
            button1.Parent = pictureBox1;
            button3.BackColor = Color.FromArgb(100, 220, 220, 220);
            button3.Parent = pictureBox1;
            listBox1.BackColor = Color.FromArgb(100, 220, 220, 220);
            listBox1.Parent = pictureBox1;
            listBox2.BackColor = Color.FromArgb(100, 220, 220, 220);
            listBox2.Parent = pictureBox1;


            //【1】创建文件流
            FileStream fs = new FileStream(".\\myfile.txt", FileMode.Open); //FileMode.Open
            //【2】创建读取器
            StreamReader ssr = new StreamReader(fs,Encoding.UTF8);
            //【3】以流的方式读取数据
            string strstar = ssr.ReadLine();//晨：先读取星座
            TimeTable.star = strstar;
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
                else TimeTable.tim[TimeTable.conTim].warn = false;

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
            //晨：对应星座匹配
            if (TimeTable.star == "白羊座")
            {
                comboBox1.Text = "白羊座";
                textBox2.Text = "整体运势棒棒哒，你会感觉身心舒畅，看待问题也更加豁达。总是能以乐观的心态去面对周围的一切事物，能从中得到一些来自己的感悟想法。生活方面唯有美食不可辜负，可以奖励自己吃点好的，好好与美食的约会。";
            }
            else if (TimeTable.star == "金牛座")
            {
                comboBox1.Text = "金牛座";
                textBox2.Text = "运势中规中矩，行动自由的一天，就是带有个人的偏见。你可能不大乐意应对社交，乃至主动逃避一些需要打交道的事情。生活方面要多留意身边可以接受信息的地方，比如重要的群消息建议不要屏蔽，容易错过。";
            }
            else if (TimeTable.star == "双子座")
            {
                comboBox1.Text = "双子座";
                textBox2.Text = "整体运势一般般，收起过多的正义感，专注自我更重要。不宜掺和网络上的是是非非，碎片化时代随便站队很容易会被利用，也可能会因好心却干了坏事。生活方面建议放宽心，当心放大的时候，看事情看问题就“小”了。";
            }
            else if (TimeTable.star == "巨蟹座")
            {
                comboBox1.Text = "巨蟹座";
                textBox2.Text = "运势并不是一帆风顺的，建议打醒精神应对。周围对于你或许会有很多的诱惑因素，定力不足就容易掉入陷阱中，会让你得不偿失。生活方面容易因为物是人非而陷入感慨忧伤中，也可能会为了吃瓜而浪费时间。";
            }
            else if (TimeTable.star == "狮子座")
            {
                comboBox1.Text = "狮子座";
                textBox2.Text = "你的野心很大，然而运气较差，会容易让期待落空，受到骨感现实无情泼冷水。你总是眺望着更遥远的目标，却忘了经济基础决定上层建筑。生活方面人与人之间的相处要树立信任，总是互相猜测的话会很心累，建议远离损友。";
            }
            else if (TimeTable.star == "处女座")
            {
                comboBox1.Text = "处女座";
                textBox2.Text = "整体运势运势相对平稳，但过于随心所欲也会带来不稳定的因素。时间会比较紧凑，事情也比较多，建议制定合理的计划，不能想到什么就做什么。生活方面会享受与朋友分享各种优惠便宜，能够从中收获一些小小的成就感。";
            }
            else if (TimeTable.star == "天秤座")
            {
                comboBox1.Text = "天秤座";
                textBox2.Text = "运势还可以，基本上能顺着你的计划平平稳稳地推动，能在小事上积累成就感。你会畅游在思想的海洋中，享受各种有趣想法的酝酿，不过对外却比较沉默寡言。生活方面享受自己的小空间，非必要也没有出门的打算。";
            }
            else if (TimeTable.star == "天蝎座")
            {
                comboBox1.Text = "天蝎座";
                textBox2.Text = "比较不走运的一天，小心聪明反被聪明误。你可能会在不恰当的地方运用小聪明，不仅便宜没占到，反而会给自己留下烂摊子，甚至反被“将军”。生活方面交友须谨慎，建议主动远离损失，保持带眼识人。";
            }
            else if (TimeTable.star == "射手座")
            {
                comboBox1.Text = "射手座";
                textBox2.Text = "运气在线的一天，简直就是开挂的节奏，赢得更多的夸奖与掌声。你每一步都走得沉稳而踏实，而且对新环境适应能力很强，容易占到行动的优势。生活方面会迎来一些全新的改变，能够给你带来期待与惊喜。";
            }
            else if (TimeTable.star == "摩羯座")
            {
                comboBox1.Text = "摩羯座";
                textBox2.Text = "运气相当给力的一天，你也会保持积极上进心，努力成为更好的自己。你能越来越了解自己，并且懂得强化自己的优势，改正小缺点。你对于生活的热情很高，而且善于发现身边有趣的事物，有着广泛的兴趣与爱好。";
            }
            else if (TimeTable.star == "水瓶座")
            {
                comboBox1.Text = "水瓶座";
                textBox2.Text = "比较倒霉的一天，破罐子破摔不可取。你总是“吃着碗里瞧着锅里”，一来会导致幸福感下降，二来也会让你错失一些机会。生活方面容易伤春悲秋，会放大自己的玻璃心，总是渴望着别人的怜爱与关心。";
            }
            else if (TimeTable.star == "双鱼座")
            {
                comboBox1.Text = "双鱼座";
                textBox2.Text = "没能得到运气的助阵，你需要踏踏实实地前行。收起投机取巧的想法，否则很容易掉入陷阱中，做出每一步决定前都要自己三思而后行。生活方面将是开卷有益的一天，会有比较多可以翻翻书本的机会，不妨试着静下心来。";
            }

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

        //旭：初始化壁纸函数
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

        //旭：初始化铃声函数
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
            sw.Write(TimeTable.star + "\r");//晨：写的时候也先写星座
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
            TimeTable.chosetime = textBox1.Text;

            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("请先选择要修改的事件！");
            }
            else
            {
                string date, time, tag, name;
                string txt = listBox1.SelectedItem.ToString();
                for (int i = index; i < TimeTable.conTim; i++)
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
                listBox2.Items.Clear();
                for (int i = 0; i < TimeTable.conTim; i++)
                {
                    if ((DateTime.Now.ToShortDateString().ToString()).Substring(0, 7) == (TimeTable.tim[i].date).Substring(0, 7))//判定日期
                    {
                        listBox2.Items.Add(TimeTable.tim[i]);

                    }
                }
                sortlistbox2();
            }
        }

        private void 搜索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 forrm = new Form5();
            forrm.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("切换模式:" +
                "\n切换简洁模式：常规模式下，菜单栏选择模式→简洁模式。" +
                "\n切换常规模式：简洁模式下，单击常规模式。" +
                "\n\n查看指定日期事件：所有模式下均为单击指定日期，查看时间框。" +
                "\n编辑事件：" +
                "\n常规模式下，先在日历中单击指定日期→编辑时间→选择添加 / 修改 / 删除事件，完成后，再次单击该日期以查看当日事件。" +
                "\n\n个性化：\n更换壁纸：常规模式下，菜单栏选择个性化→个性化背景→选择壁纸。" +
                "\n更换字体：常规模式下，菜单栏选择个性化→个性化字体→选择字体。" +
                "\n设置铃声：常规模式下，菜单栏选择个性化→个性化铃声→选择铃声。" +
                "\n\n搜索事件：" +
                "\n常规模式下，菜单栏选择搜索事件→输入事件→点击搜索。", "使用指南：");
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
            button1.FlatStyle = FlatStyle.Flat; //样式
            button1.ForeColor = Color.Transparent;//前景
            button1.BackColor = Color.Transparent;//去背景
            button1.FlatAppearance.BorderSize = 0;//去边线
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 40, 60, 82);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 40, 60, 82);
            button3.FlatStyle = FlatStyle.Flat; //样式
            button3.ForeColor = Color.Transparent;//前景
            button3.BackColor = Color.Transparent;//去背景
            button3.FlatAppearance.BorderSize = 0;//去边线
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 40, 60, 82);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 40, 60, 82);
        }


        //旭：打开简洁模式窗口，关闭（隐藏）常规模式窗口
        private void 简介模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //先保存文件再切换模式
            save_file();
            Form6 simpleForm = new Form6();
            this.Hide();
            simpleForm.Show();

        }
        

        //旭：关闭主窗口时退出程序
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭窗口前保存文件
            save_file();
            Application.Exit();
        }

        //旭：选择壁纸
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
                        save_file();//即时更新事件是否已提醒的标记
                        if (MessageBox.Show(TimeTable.tim[i].name + "  时间到了！", "温馨提示") == DialogResult.OK)
                        {
                            notice.Ctlcontrols.stop();
                        }
                    }
                }
            }
        }

        //旭：选择铃声
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

        //旭：定时器，自选系统铃声
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
            button1.Font = new Font("宋体", label1.Font.Size, label1.Font.Style);
            button3.Font = new Font("宋体", label1.Font.Size, label1.Font.Style);
            textBox2.Font = new Font("宋体", label1.Font.Size, label1.Font.Style);
            listBox2.Font = new Font("宋体", label1.Font.Size, label1.Font.Style);
            label2.Font = new Font("宋体", label1.Font.Size, label1.Font.Style);
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
            button1.Font = new Font("微软雅黑", label1.Font.Size, label1.Font.Style);
            button3.Font = new Font("微软雅黑", label1.Font.Size, label1.Font.Style);
            textBox2.Font = new Font("微软雅黑", label1.Font.Size, label1.Font.Style);
            listBox2.Font = new Font("微软雅黑", label1.Font.Size, label1.Font.Style);
            label2.Font = new Font("微软雅黑", label1.Font.Size, label1.Font.Style);
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
            button1.Font = new Font("华文琥珀", label1.Font.Size, label1.Font.Style);
            button3.Font = new Font("华文琥珀", label1.Font.Size, label1.Font.Style);
            textBox2.Font = new Font("华文琥珀", label1.Font.Size, label1.Font.Style);
            listBox2.Font = new Font("华文琥珀", label1.Font.Size, label1.Font.Style);
            label2.Font = new Font("华文琥珀", label1.Font.Size, label1.Font.Style);
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
            button1.Font = new Font("楷体", label1.Font.Size, label1.Font.Style);
            button3.Font = new Font("楷体", label1.Font.Size, label1.Font.Style);
            textBox2.Font = new Font("楷体", label1.Font.Size, label1.Font.Style);
            listBox2.Font = new Font("楷体", label1.Font.Size, label1.Font.Style);
            label2.Font = new Font("楷体", label1.Font.Size, label1.Font.Style);
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
            button1.Font = new Font("幼圆", label1.Font.Size, label1.Font.Style);
            button3.Font = new Font("幼圆", label1.Font.Size, label1.Font.Style);
            textBox2.Font = new Font("幼圆", label1.Font.Size, label1.Font.Style);
            listBox2.Font = new Font("幼圆", label1.Font.Size, label1.Font.Style);
            label2.Font = new Font("幼圆", label1.Font.Size, label1.Font.Style);
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
            button1.Font = new Font("华文彩云", label1.Font.Size, label1.Font.Style);
            button3.Font = new Font("华文彩云", label1.Font.Size, label1.Font.Style);
            textBox2.Font = new Font("华文彩云", label1.Font.Size, label1.Font.Style);
            listBox2.Font = new Font("华文彩云", label1.Font.Size, label1.Font.Style);
            label2.Font = new Font("华文彩云", label1.Font.Size, label1.Font.Style);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请选择日期！");
                return;
            }
            TimeTable.chosetime = textBox1.Text;
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
            listBox2.Items.Clear();
            for (int i = 0; i < TimeTable.conTim; i++)
            {
                if ((DateTime.Now.ToShortDateString().ToString()).Substring(0, 7) == (TimeTable.tim[i].date).Substring(0, 7))//判定日期
                {
                    listBox2.Items.Add(TimeTable.tim[i]);

                }
            }
            sortlistbox2();

        }

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
                listBox2.Items.Clear();
                for (int i = 0; i < TimeTable.conTim; i++)
                {
                    if ((DateTime.Now.ToShortDateString().ToString()).Substring(0, 7) == (TimeTable.tim[i].date).Substring(0, 7))//判定日期
                    {
                        listBox2.Items.Add(TimeTable.tim[i]);

                    }
                }
                sortlistbox2();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "白羊座")
            {
                textBox2.Text = "整体运势棒棒哒，你会感觉身心舒畅，看待问题也更加豁达。总是能以乐观的心态去面对周围的一切事物，能从中得到一些来自己的感悟想法。生活方面唯有美食不可辜负，可以奖励自己吃点好的，好好与美食的约会。";
            }
            else if (comboBox1.SelectedItem == "金牛座")
            {
                textBox2.Text = "运势中规中矩，行动自由的一天，就是带有个人的偏见。你可能不大乐意应对社交，乃至主动逃避一些需要打交道的事情。生活方面要多留意身边可以接受信息的地方，比如重要的群消息建议不要屏蔽，容易错过。";
            }
            else if (comboBox1.SelectedItem == "双子座")
            {
                textBox2.Text = "整体运势一般般，收起过多的正义感，专注自我更重要。不宜掺和网络上的是是非非，碎片化时代随便站队很容易会被利用，也可能会因好心却干了坏事。生活方面建议放宽心，当心放大的时候，看事情看问题就“小”了。";
            }
            else if (comboBox1.SelectedItem == "巨蟹座")
            {
                textBox2.Text = "运势并不是一帆风顺的，建议打醒精神应对。周围对于你或许会有很多的诱惑因素，定力不足就容易掉入陷阱中，会让你得不偿失。生活方面容易因为物是人非而陷入感慨忧伤中，也可能会为了吃瓜而浪费时间。";
            }
            else if (comboBox1.SelectedItem == "狮子座")
            {
                textBox2.Text = "你的野心很大，然而运气较差，会容易让期待落空，受到骨感现实无情泼冷水。你总是眺望着更遥远的目标，却忘了经济基础决定上层建筑。生活方面人与人之间的相处要树立信任，总是互相猜测的话会很心累，建议远离损友。";
            }
            else if (comboBox1.SelectedItem == "处女座")
            {
                textBox2.Text = "整体运势运势相对平稳，但过于随心所欲也会带来不稳定的因素。时间会比较紧凑，事情也比较多，建议制定合理的计划，不能想到什么就做什么。生活方面会享受与朋友分享各种优惠便宜，能够从中收获一些小小的成就感。";
            }
            else if (comboBox1.SelectedItem == "天秤座")
            {
                textBox2.Text = "运势还可以，基本上能顺着你的计划平平稳稳地推动，能在小事上积累成就感。你会畅游在思想的海洋中，享受各种有趣想法的酝酿，不过对外却比较沉默寡言。生活方面享受自己的小空间，非必要也没有出门的打算。";
            }
            else if (comboBox1.SelectedItem == "天蝎座")
            {
                textBox2.Text = "比较不走运的一天，小心聪明反被聪明误。你可能会在不恰当的地方运用小聪明，不仅便宜没占到，反而会给自己留下烂摊子，甚至反被“将军”。生活方面交友须谨慎，建议主动远离损失，保持带眼识人。";
            }
            else if (comboBox1.SelectedItem == "射手座")
            {
                textBox2.Text = "运气在线的一天，简直就是开挂的节奏，赢得更多的夸奖与掌声。你每一步都走得沉稳而踏实，而且对新环境适应能力很强，容易占到行动的优势。生活方面会迎来一些全新的改变，能够给你带来期待与惊喜。";
            }
            else if (comboBox1.SelectedItem == "摩羯座")
            {
                textBox2.Text = "运气相当给力的一天，你也会保持积极上进心，努力成为更好的自己。你能越来越了解自己，并且懂得强化自己的优势，改正小缺点。你对于生活的热情很高，而且善于发现身边有趣的事物，有着广泛的兴趣与爱好。";
            }
            else if (comboBox1.SelectedItem == "水瓶座")
            {
                textBox2.Text = "比较倒霉的一天，破罐子破摔不可取。你总是“吃着碗里瞧着锅里”，一来会导致幸福感下降，二来也会让你错失一些机会。生活方面容易伤春悲秋，会放大自己的玻璃心，总是渴望着别人的怜爱与关心。";
            }
            else if (comboBox1.SelectedItem == "双鱼座")
            {
                textBox2.Text = "没能得到运气的助阵，你需要踏踏实实地前行。收起投机取巧的想法，否则很容易掉入陷阱中，做出每一步决定前都要自己三思而后行。生活方面将是开卷有益的一天，会有比较多可以翻翻书本的机会，不妨试着静下心来。";
            }
            else
            {
                textBox2.Text = "暂无相应星座数据！";
            }
            TimeTable.star = comboBox1.SelectedItem.ToString();

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }

}





