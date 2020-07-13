using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTools.MathModel
{
    public class Date
    {
        public Date()
        {
            DateTime now = DateTime.Now;
            year = now.Year;
            month = now.Month;
            day = now.Day;
        }
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        /// <summary>
        /// 解析标准日期字符串
        /// </summary>
        /// <param name="str"></param>
        public Date(string str)
        {
            this.year = int.Parse(str.Split('/')[0]);
            this.month = int.Parse(str.Split('/')[1]);
            this.day = int.Parse(str.Split('/')[3]);
        }
        public readonly int year;
        public readonly int month;
        public readonly int day;
        public int code = 0;
        public int hasCode() => code;//散列值
        public int ToNum() => year * 10000 + month * 100 + day;
        /// <summary>
        /// 返回两个日期是否相等的布尔值
        /// </summary>
        /// <param name="other">另一个日期</param>
        /// <returns>是否相等</returns>
        public bool equals(Date other) => this.ToNum() == other.ToNum() ? true : false;
        /// <summary>
        /// 返回该日期与指定日期相差的天数
        /// </summary>
        /// <param name="other">指定日期</param>
        /// <returns>相差天数</returns>
        public int compareTo(Date other) => other.ToNum() - this.ToNum();
        public override string ToString() => year + "/" + month + "/" + day;
    }
    public class Transcation
    {
        /// <summary>
        /// 解析string
        /// </summary>
        /// <param name="str">标准交易字符串</param>
        public Transcation(string str)
        {
            this.who = str.Split('-')[0];
            this.when = new Date(str.Split('-')[1]);
            this.amount = double.Parse(str.Split('-')[2]);
        }
        public Transcation(string who, Date when, double amount)
        {
            this.who = who;
            this.when = when;
            this.amount = amount;
        }
        public readonly string who;
        public readonly Date when;
        public readonly double amount;
        public int code = 0;
        public int hasCode() => code;//散列值
        public bool equals(Transcation other) => true;
        /// <summary>
        /// 返回比较之后的金额差
        /// </summary>
        /// <param name="other">另一笔交易</param>
        /// <returns>金额差</returns>
        public double compareTo(Transcation other) => this.amount - other.amount;
        public override string ToString() => who + "-" + when.ToString() + "-" + amount;
    }
}
