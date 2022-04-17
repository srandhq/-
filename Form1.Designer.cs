
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notice = new AxWMPLib.AxWindowsMediaPlayer();
            this.模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简介模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.星座模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.万年历ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个性化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个性化背景ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.老年壁纸1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.老年壁纸2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.老年壁纸3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.老年壁纸4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.老年壁纸5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.老年壁纸6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义壁纸ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个性化字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.默认字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宋体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.楷体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.幼圆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.彩云ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个性化铃声ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.稻香ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.酒醉的蝴蝶ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.狼给的诱惑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.爱情买卖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.默认铃声ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义铃声ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.常规模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.notice)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(535, 26);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            this.monthCalendar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChooseDate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "选中的日期是：";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(128, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 27);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(128, 85);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "编辑事件";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(18, 154);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(344, 144);
            this.listBox1.TabIndex = 24;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notice
            // 
            this.notice.Enabled = true;
            this.notice.Location = new System.Drawing.Point(445, 342);
            this.notice.Name = "notice";
            this.notice.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("notice.OcxState")));
            this.notice.Size = new System.Drawing.Size(75, 23);
            this.notice.TabIndex = 27;
            this.notice.Visible = false;
            // 
            // 模式ToolStripMenuItem
            // 
            this.模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.常规模式ToolStripMenuItem,
            this.简介模式ToolStripMenuItem,
            this.星座模式ToolStripMenuItem,
            this.万年历ToolStripMenuItem});
            this.模式ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("模式ToolStripMenuItem.Image")));
            this.模式ToolStripMenuItem.Name = "模式ToolStripMenuItem";
            this.模式ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.模式ToolStripMenuItem.Text = "模式";
            // 
            // 简介模式ToolStripMenuItem
            // 
            this.简介模式ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("简介模式ToolStripMenuItem.Image")));
            this.简介模式ToolStripMenuItem.Name = "简介模式ToolStripMenuItem";
            this.简介模式ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.简介模式ToolStripMenuItem.Text = "简洁模式";
            this.简介模式ToolStripMenuItem.Click += new System.EventHandler(this.简介模式ToolStripMenuItem_Click);
            // 
            // 星座模式ToolStripMenuItem
            // 
            this.星座模式ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("星座模式ToolStripMenuItem.Image")));
            this.星座模式ToolStripMenuItem.Name = "星座模式ToolStripMenuItem";
            this.星座模式ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.星座模式ToolStripMenuItem.Text = "休闲模式";
            this.星座模式ToolStripMenuItem.Click += new System.EventHandler(this.星座模式ToolStripMenuItem_Click);
            // 
            // 万年历ToolStripMenuItem
            // 
            this.万年历ToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.万年历ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("万年历ToolStripMenuItem.Image")));
            this.万年历ToolStripMenuItem.Name = "万年历ToolStripMenuItem";
            this.万年历ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.万年历ToolStripMenuItem.Text = "万年历";
            this.万年历ToolStripMenuItem.Click += new System.EventHandler(this.其他模式ToolStripMenuItem_Click);
            // 
            // 个性化ToolStripMenuItem
            // 
            this.个性化ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个性化背景ToolStripMenuItem,
            this.个性化字体ToolStripMenuItem,
            this.个性化铃声ToolStripMenuItem});
            this.个性化ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("个性化ToolStripMenuItem.Image")));
            this.个性化ToolStripMenuItem.Name = "个性化ToolStripMenuItem";
            this.个性化ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.个性化ToolStripMenuItem.Text = "个性化";
            // 
            // 个性化背景ToolStripMenuItem
            // 
            this.个性化背景ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.老年壁纸1ToolStripMenuItem,
            this.老年壁纸2ToolStripMenuItem,
            this.老年壁纸3ToolStripMenuItem,
            this.老年壁纸4ToolStripMenuItem,
            this.老年壁纸5ToolStripMenuItem,
            this.老年壁纸6ToolStripMenuItem,
            this.自定义壁纸ToolStripMenuItem});
            this.个性化背景ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("个性化背景ToolStripMenuItem.Image")));
            this.个性化背景ToolStripMenuItem.Name = "个性化背景ToolStripMenuItem";
            this.个性化背景ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.个性化背景ToolStripMenuItem.Text = "个性化背景";
            // 
            // 老年壁纸1ToolStripMenuItem
            // 
            this.老年壁纸1ToolStripMenuItem.Name = "老年壁纸1ToolStripMenuItem";
            this.老年壁纸1ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.老年壁纸1ToolStripMenuItem.Text = "老年壁纸1";
            this.老年壁纸1ToolStripMenuItem.Click += new System.EventHandler(this.老年壁纸1ToolStripMenuItem_Click);
            // 
            // 老年壁纸2ToolStripMenuItem
            // 
            this.老年壁纸2ToolStripMenuItem.Name = "老年壁纸2ToolStripMenuItem";
            this.老年壁纸2ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.老年壁纸2ToolStripMenuItem.Text = "老年壁纸2";
            this.老年壁纸2ToolStripMenuItem.Click += new System.EventHandler(this.老年壁纸2ToolStripMenuItem_Click);
            // 
            // 老年壁纸3ToolStripMenuItem
            // 
            this.老年壁纸3ToolStripMenuItem.Name = "老年壁纸3ToolStripMenuItem";
            this.老年壁纸3ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.老年壁纸3ToolStripMenuItem.Text = "老年壁纸3";
            this.老年壁纸3ToolStripMenuItem.Click += new System.EventHandler(this.老年壁纸3ToolStripMenuItem_Click);
            // 
            // 老年壁纸4ToolStripMenuItem
            // 
            this.老年壁纸4ToolStripMenuItem.Name = "老年壁纸4ToolStripMenuItem";
            this.老年壁纸4ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.老年壁纸4ToolStripMenuItem.Text = "老年壁纸4";
            this.老年壁纸4ToolStripMenuItem.Click += new System.EventHandler(this.老年壁纸4ToolStripMenuItem_Click);
            // 
            // 老年壁纸5ToolStripMenuItem
            // 
            this.老年壁纸5ToolStripMenuItem.Name = "老年壁纸5ToolStripMenuItem";
            this.老年壁纸5ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.老年壁纸5ToolStripMenuItem.Text = "老年壁纸5";
            this.老年壁纸5ToolStripMenuItem.Click += new System.EventHandler(this.老年壁纸5ToolStripMenuItem_Click);
            // 
            // 老年壁纸6ToolStripMenuItem
            // 
            this.老年壁纸6ToolStripMenuItem.Name = "老年壁纸6ToolStripMenuItem";
            this.老年壁纸6ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.老年壁纸6ToolStripMenuItem.Text = "老年壁纸6";
            this.老年壁纸6ToolStripMenuItem.Click += new System.EventHandler(this.老年壁纸6ToolStripMenuItem_Click);
            // 
            // 自定义壁纸ToolStripMenuItem
            // 
            this.自定义壁纸ToolStripMenuItem.Name = "自定义壁纸ToolStripMenuItem";
            this.自定义壁纸ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.自定义壁纸ToolStripMenuItem.Text = "自定义壁纸";
            this.自定义壁纸ToolStripMenuItem.Click += new System.EventHandler(this.自定义壁纸ToolStripMenuItem_Click);
            // 
            // 个性化字体ToolStripMenuItem
            // 
            this.个性化字体ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.默认字体ToolStripMenuItem,
            this.宋体ToolStripMenuItem,
            this.粗体ToolStripMenuItem,
            this.楷体ToolStripMenuItem,
            this.幼圆ToolStripMenuItem,
            this.彩云ToolStripMenuItem});
            this.个性化字体ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("个性化字体ToolStripMenuItem.Image")));
            this.个性化字体ToolStripMenuItem.Name = "个性化字体ToolStripMenuItem";
            this.个性化字体ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.个性化字体ToolStripMenuItem.Text = "个性化字体";
            // 
            // 默认字体ToolStripMenuItem
            // 
            this.默认字体ToolStripMenuItem.Name = "默认字体ToolStripMenuItem";
            this.默认字体ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.默认字体ToolStripMenuItem.Text = "雅黑";
            this.默认字体ToolStripMenuItem.Click += new System.EventHandler(this.默认字体ToolStripMenuItem_Click);
            // 
            // 宋体ToolStripMenuItem
            // 
            this.宋体ToolStripMenuItem.Name = "宋体ToolStripMenuItem";
            this.宋体ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.宋体ToolStripMenuItem.Text = "宋体";
            this.宋体ToolStripMenuItem.Click += new System.EventHandler(this.宋体ToolStripMenuItem_Click);
            // 
            // 粗体ToolStripMenuItem
            // 
            this.粗体ToolStripMenuItem.Name = "粗体ToolStripMenuItem";
            this.粗体ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.粗体ToolStripMenuItem.Text = "粗体";
            this.粗体ToolStripMenuItem.Click += new System.EventHandler(this.粗体ToolStripMenuItem_Click);
            // 
            // 楷体ToolStripMenuItem
            // 
            this.楷体ToolStripMenuItem.Name = "楷体ToolStripMenuItem";
            this.楷体ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.楷体ToolStripMenuItem.Text = "楷体";
            this.楷体ToolStripMenuItem.Click += new System.EventHandler(this.楷体ToolStripMenuItem_Click);
            // 
            // 幼圆ToolStripMenuItem
            // 
            this.幼圆ToolStripMenuItem.Name = "幼圆ToolStripMenuItem";
            this.幼圆ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.幼圆ToolStripMenuItem.Text = "幼圆";
            this.幼圆ToolStripMenuItem.Click += new System.EventHandler(this.幼圆ToolStripMenuItem_Click);
            // 
            // 彩云ToolStripMenuItem
            // 
            this.彩云ToolStripMenuItem.Name = "彩云ToolStripMenuItem";
            this.彩云ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.彩云ToolStripMenuItem.Text = "彩云";
            this.彩云ToolStripMenuItem.Click += new System.EventHandler(this.彩云ToolStripMenuItem_Click);
            // 
            // 个性化铃声ToolStripMenuItem
            // 
            this.个性化铃声ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.稻香ToolStripMenuItem,
            this.酒醉的蝴蝶ToolStripMenuItem,
            this.狼给的诱惑ToolStripMenuItem,
            this.爱情买卖ToolStripMenuItem,
            this.默认铃声ToolStripMenuItem,
            this.自定义铃声ToolStripMenuItem});
            this.个性化铃声ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("个性化铃声ToolStripMenuItem.Image")));
            this.个性化铃声ToolStripMenuItem.Name = "个性化铃声ToolStripMenuItem";
            this.个性化铃声ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.个性化铃声ToolStripMenuItem.Text = "个性化铃声";
            // 
            // 稻香ToolStripMenuItem
            // 
            this.稻香ToolStripMenuItem.Name = "稻香ToolStripMenuItem";
            this.稻香ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.稻香ToolStripMenuItem.Text = "稻香";
            this.稻香ToolStripMenuItem.Click += new System.EventHandler(this.稻香ToolStripMenuItem_Click);
            // 
            // 酒醉的蝴蝶ToolStripMenuItem
            // 
            this.酒醉的蝴蝶ToolStripMenuItem.Name = "酒醉的蝴蝶ToolStripMenuItem";
            this.酒醉的蝴蝶ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.酒醉的蝴蝶ToolStripMenuItem.Text = "酒醉的蝴蝶";
            this.酒醉的蝴蝶ToolStripMenuItem.Click += new System.EventHandler(this.酒醉的蝴蝶ToolStripMenuItem_Click);
            // 
            // 狼给的诱惑ToolStripMenuItem
            // 
            this.狼给的诱惑ToolStripMenuItem.Name = "狼给的诱惑ToolStripMenuItem";
            this.狼给的诱惑ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.狼给的诱惑ToolStripMenuItem.Text = "狼给的诱惑";
            this.狼给的诱惑ToolStripMenuItem.Click += new System.EventHandler(this.狼给的诱惑ToolStripMenuItem_Click);
            // 
            // 爱情买卖ToolStripMenuItem
            // 
            this.爱情买卖ToolStripMenuItem.Name = "爱情买卖ToolStripMenuItem";
            this.爱情买卖ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.爱情买卖ToolStripMenuItem.Text = "爱情买卖";
            this.爱情买卖ToolStripMenuItem.Click += new System.EventHandler(this.爱情买卖ToolStripMenuItem_Click);
            // 
            // 默认铃声ToolStripMenuItem
            // 
            this.默认铃声ToolStripMenuItem.Name = "默认铃声ToolStripMenuItem";
            this.默认铃声ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.默认铃声ToolStripMenuItem.Text = "（不需要铃声）";
            this.默认铃声ToolStripMenuItem.Click += new System.EventHandler(this.默认铃声ToolStripMenuItem_Click);
            // 
            // 自定义铃声ToolStripMenuItem
            // 
            this.自定义铃声ToolStripMenuItem.Name = "自定义铃声ToolStripMenuItem";
            this.自定义铃声ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.自定义铃声ToolStripMenuItem.Text = "自定义铃声";
            this.自定义铃声ToolStripMenuItem.Click += new System.EventHandler(this.自定义铃声ToolStripMenuItem_Click);
            // 
            // 搜索ToolStripMenuItem
            // 
            this.搜索ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("搜索ToolStripMenuItem.Image")));
            this.搜索ToolStripMenuItem.Name = "搜索ToolStripMenuItem";
            this.搜索ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.搜索ToolStripMenuItem.Text = "搜索事件";
            this.搜索ToolStripMenuItem.Click += new System.EventHandler(this.搜索ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("帮助ToolStripMenuItem.Image")));
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.模式ToolStripMenuItem,
            this.个性化ToolStripMenuItem,
            this.搜索ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(767, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "今日诸事不宜";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(454, 254);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(289, 169);
            this.listBox2.TabIndex = 32;
            // 
            // 常规模式ToolStripMenuItem
            // 
            this.常规模式ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("常规模式ToolStripMenuItem.Image")));
            this.常规模式ToolStripMenuItem.Name = "常规模式ToolStripMenuItem";
            this.常规模式ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.常规模式ToolStripMenuItem.Text = "常规模式";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.老年壁纸1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(767, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 434);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "多功能智能大学生时间管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.notice)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer;
        private AxWMPLib.AxWindowsMediaPlayer notice;
        private System.Windows.Forms.ToolStripMenuItem 模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 常规模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简介模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 星座模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 万年历ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个性化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个性化背景ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个性化字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个性化铃声ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 默认铃声ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 酒醉的蝴蝶ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 狼给的诱惑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 爱情买卖ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 稻香ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 老年壁纸1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 老年壁纸2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 老年壁纸3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 老年壁纸4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 老年壁纸5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 老年壁纸6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义壁纸ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义铃声ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 默认字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宋体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粗体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 楷体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 幼圆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 彩云ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
    }
}

