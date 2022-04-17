using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class TimeTable
    {
        public string date;
        public string time;
        public string name;
        public string tag;
        public bool warn;

        public static string chosetime;

 

        public static int conTim = 0;
        public static int maxconTim = 1000;
        public static TimeTable[] tim = new TimeTable[maxconTim];
        public static TimeTable[] temp = new TimeTable[1];//暂存修改事件的数组

        public static void inttimetable()
        {
            //conTim = 4;
            tim[0] = new TimeTable("15:00", "学习", "写上机报告", "2022/3/19", false);
            tim[1] = new TimeTable("14:00", "学习", "背单词", "2022/3/20", false);
            tim[2] = new TimeTable("13:00", "生活", "吃饭", "2022/3/20", false);
            tim[3] = new TimeTable("18:00", "娱乐", "参加生日派对", "2022/3/21", false);
        }
        public TimeTable(string time, string tag,string name,string date,bool warn)
        {
            this.time = time;
            this.name = name;
            this.tag = tag;
            this.date = date;
            this.warn = warn;
        }


        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}",date,time,tag,name);
        }
    }
}
