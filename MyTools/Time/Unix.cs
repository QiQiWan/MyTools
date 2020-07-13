using System;
using System.Collections.Generic;
using System.Text;

namespace MyTools.Time
{
    public class Unix
    {
        private static long Jan1st1970Ms = new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc).Ticks;
        /// <summary>
        /// 将Unix时间戳转换为DateTime类型时间
        /// </summary>
        /// <param name="d">double 型数字</param>
        /// <returns>DateTime</returns>
        public static System.DateTime ConvertIntDateTime(double d)
        {
            System.DateTime time = System.DateTime.MinValue;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            time = startTime.AddSeconds(d);
            return time;
        }

        /// <summary>
        /// 将c# DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time">时间</param>
        /// <returns>double</returns>
        public static double ConvertDateTimeInt(System.DateTime time)
        {
            double intResult = 0;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            intResult = (time - startTime).TotalSeconds;
            return intResult;
        }
        /// <summary>
        /// 返回当前时间的毫秒数, 这个毫秒其实就是自1970年1月1日0时起的毫秒数
        /// </summary>
        public static long currentTimeMillis()
        {
            return (System.DateTime.UtcNow.Ticks - Jan1st1970Ms) / 10000;
        }

        /// <summary>
        /// 从一个代表自1970年1月1日0时起的毫秒数，转换为DateTime (北京时间)
        /// </summary>
        public static System.DateTime getDateTime(long timeMillis)
        {
            return new System.DateTime((long)((timeMillis + 28800000L) * 10000 + Jan1st1970Ms));
        }

        /// <summary>
        /// 从一个代表自1970年1月1日0时起的毫秒数，转换为DateTime (UTC时间)
        /// </summary>
        public static System.DateTime getDateTimeUTC(long timeMillis)
        {
            return new System.DateTime(timeMillis * 10000 + Jan1st1970Ms);
        }
    }
}
