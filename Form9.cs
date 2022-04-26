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
            //晨：根据读的模式进行个性化；
            if (TimeTable.star == "白羊座")
            {
                pictureBox1.Image = Image.FromFile(".\\白羊座.jpg");
                textBox2.Text = "爱情运势:单身的清楚自己的心意，也敢于积极行动。恋爱中的或有关于未来的计划进行中。\r\n\r\n事业学业:有来自正向的压力让你转化为动力，你也会保持步履不止的姿态往前冲。\r\n\r\n财富运势: 收益丰厚，无论正财还是偏财，都会给你带来惊喜，也能存到一笔不错的存款。\r\n\r\n健康运势: 建议远离戾气过重的互联网，容易影响你的好心情，不小心吵起来更是暴躁。";
            }
            else if (TimeTable.star == "金牛座")
            {
                pictureBox1.Image = Image.FromFile(".\\金牛座.jpg");
                textBox2.Text = "爱情运势:单身的抓住相亲机会，或能遇到有心人。恋爱中的保持沟通，相处也能平平稳稳。\r\n\r\n事业学业: 要学着对事不对人，感情用事很容易会出现失误的判断，还是以工作 / 学习考虑为主。\r\n\r\n财富运势: 警惕理财的陷阱以及电信网络诈骗，贪小便宜的心思很容易反过来被利用。\r\n\r\n健康运势: 在玩极限运动或是带有危险系数的运动项目时，务必要做好防范措施，避免受伤。";
            }
            else if (TimeTable.star == "双子座")
            {
                pictureBox1.Image = Image.FromFile(".\\双子座.jpg");
                textBox2.Text = "爱情运势:单身的与某个人相处过程中或会有心动的瞬间。恋爱中的占有欲比较强，容易吃干醋。\r\n\r\n事业学业:需要忙碌的事情很多，也可能会因为心软而揽下麻烦事，会给自己添乱。\r\n\r\n财富运势: 财运平平，想要赢得更多的进账不容易，你会感受到钱财来之不易，懂得守财。\r\n\r\n健康运势: 用脑过度的时候务必要给自己适度休息的空隙，也要给眼睛休息，闭目养养神。";
            }
            else if (TimeTable.star == "巨蟹座")
            {
                pictureBox1.Image = Image.FromFile(".\\巨蟹座.jpg");
                textBox2.Text = "爱情运势:单身的唯有告别过去，才能迎来新开始。恋爱中的与前度纠缠，会让现任恋人感到不安。\r\n\r\n事业学业:不要眷恋过去的荣耀，需要把心态放平，立足脚下，全力以赴地努力。\r\n\r\n财富运势:冲动投资容易面临破财的风险，遇到状况时要及时止损，避免让问题变得严峻。\r\n\r\n健康运势:建议出门之前做好个人的防晒，涂抹防晒霜，也可以带上伞，更重要的是多喝水。";
            }
            else if (TimeTable.star == "狮子座")
            {
                pictureBox1.Image = Image.FromFile(".\\狮子座.jpg");
                textBox2.Text = "爱情运势:单身的眼高手低，更应该提高自身条件。恋爱中的警惕旁人挑拨离间，有误会及时解开。\r\n\r\n事业学业:在能力不及之前，你需要调整目标计划，不然频频受挫会严重打击你的自信心。\r\n\r\n财富运势:求财不能冒进，很容易会掉入陷阱中，建议涉及钱财问题时务必谨慎应对。\r\n\r\n健康运势:容易烦躁不安的一天，你需要让自己的心静下来，比如听音乐、做运动或是看看书。";
            }
            else if (TimeTable.star == "处女座")
            {
                pictureBox1.Image = Image.FromFile(".\\处女座.jpg");
                textBox2.Text = "爱情运势:单身的比较享受自由的状态，悠然自得。恋爱中的感情稳定，保持面对面的陪伴。\r\n\r\n事业学业:比较原地踏步的感觉，对于别人的建议也容易左耳进右耳出，不愿意进行改变。\r\n\r\n财富运势:付出与收获划上等号，意味着你想要赢得收益就要付出更多努力，提高理财意识。\r\n\r\n健康运势:建议保持适度的运动锻炼，可以是瑜伽、跳舞或是其他的健身项目，做好健康把关。";
            }
            else if (TimeTable.star == "天秤座")
            {
                pictureBox1.Image = Image.FromFile(".\\天秤座.jpg");
                textBox2.Text = "爱情运势:单身的身边有桃花运，但你却比较迟钝。恋爱中的不妨热情回应恋人花心思的互动。\r\n\r\n事业学业: 偶尔也会遇到一些小挫折，不过你能再接再厉，态度上比较积极和乐观。\r\n\r\n财富运势: 能够保持平稳地进账，维持日常花销没有压力，但也没有存钱和理财的意识。\r\n\r\n健康运势: 胃口比较不错，但大鱼大肉也会引起消化不良的问题，建议饮食以清淡为主。";
            }
            else if (TimeTable.star == "天蝎座")
            {
                pictureBox1.Image = Image.FromFile(".\\天蝎座.jpg");
                textBox2.Text = "爱情运势:单身的别盲目陷入一段感情，容易看走眼。恋爱中的远离暧昧关系，三心二意会成竹篮打水。\r\n\r\n事业学业: 比较粗心大意的一天，总是有一些理所当然的想法，建议养成检查的习惯。\r\n\r\n财富运势: 可能会与亲朋戚友有钱财借贷的来往，人情归人情数目要分明，凡事以立字据为证。\r\n\r\n健康运势: 要注意安全用电的问题，比如手机充完电要及时拔下插头数据线，减少小状况出现。";
            }
            else if (TimeTable.star == "射手座")
            {
                pictureBox1.Image = Image.FromFile(".\\射手座.jpg");
                textBox2.Text = "爱情运势:单身的感情事顺其自然地发展就好。恋爱中的能水到渠成地迎来下一个阶段，感情升温。\r\n\r\n事业学业: 表现比较稳定，能够按照计划一步一脚印踏踏实实地走着，行事方面更加沉稳。\r\n\r\n财富运势: 容易迎来奖金的进账，而且抽奖的手气很好，可以小试牛刀容易赢得惊喜。\r\n\r\n健康运势: 建议不要吃饱睡睡饱就吃，这会带来体重上升的压力，而且对健康也不利，应多动起来。";
            }
            else if (TimeTable.star == "摩羯座")
            {
                pictureBox1.Image = Image.FromFile(".\\摩羯座.jpg");
                textBox2.Text = "爱情运势:单身的保持对爱情的向往，但也不将就。恋爱中的能保持两人的节奏，携手共进着。\r\n\r\n事业学业: 能够在与高手切磋过招中得到进步，而且懂得扬长避短，有利于展示真正的实力。\r\n\r\n财富运势: 得到财神的眷顾，容易以小钱赢得大回报，会给你很大的惊喜，有望实现经济自由。\r\n\r\n健康运势: 生活中要减少磕磕碰碰受皮外伤的情况，尤其是对关节的损伤更容易留下隐患。";
            }
            else if (TimeTable.star == "水瓶座")
            {
                pictureBox1.Image = Image.FromFile(".\\水瓶座.jpg");
                textBox2.Text = "爱情运势:单身的还需要多刷刷正面的存在感。恋爱中的在对方需要的时候要给Ta适度陪伴。\r\n\r\n事业学业: 虽然不大走运，但俗话说“勤能补拙”，保持勤勤恳恳姿态总是好的。\r\n\r\n财富运势: 求财需谨慎，君子爱财应取之有道，建议暂时以守财为主，不宜冲动冒险。\r\n\r\n健康运势: 无论是因为玩手机还是自卑的关系，都不建议养成低头走路的坏习惯，多留意身边路况。";
            }
            else if (TimeTable.star == "双鱼座")
            {
                pictureBox1.Image = Image.FromFile(".\\双鱼座.jpg");
                textBox2.Text = "爱情运势:单身的能自然地与喜欢的人相处，宜培养感情。恋爱中的能与恋人一起成长与磨合。\r\n\r\n事业学业: 容易陷入瓶颈期，可能会触及知识的尽头，需要不断学习进步，不然会落后于人。\r\n\r\n财富运势: 能维持平衡的收支，你对求财也相对佛系，没有经济压力相对自由的状态。\r\n\r\n健康运势: 建议做好情绪的管理，尤其是当负能量即将溢出来的时候，学着转移注意力。";
            }
            else
            {
                pictureBox1.Refresh();
                textBox2.Text = "暂无相应星座数据！";
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
