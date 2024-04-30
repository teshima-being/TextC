using System;

namespace Practice8_2 {
    internal class Program {

        //問題8-2
        //テキストの次の指定曜日を求めるメソッドを参考に、次の週の指定曜日の日付を求めるメソッドを定義してください。

        static void Main(string[] args) {
            DateTime wResultDate = GetNextWeekDay(DateTime.Today, DayOfWeek.Saturday);
            Console.WriteLine(wResultDate.ToString("M月d日(dddd)"));
        }

        //テキスト8-26：次の指定曜日を求めるメソッド
        public static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek) {
            var days = dayOfWeek - date.DayOfWeek;
            if (days <= 0) {
                days += 7;
            }
            return date.AddDays(days);
        }
        
        /// <summary>
        /// 基準日と曜日を引数に取り、基準日から起算して翌週の指定曜日の日付を求めます。
        /// </summary>
        /// <param name="vBaseDate">基準日</param>
        /// <param name="vDayOfWeek">曜日</param>
        /// <returns>翌週の指定曜日の日付</returns>
        public static DateTime GetNextWeekDay(DateTime vBaseDate, DayOfWeek vDayOfWeek) {

            DateTime wNextWeek = vBaseDate.AddDays(7);
            var wDateDiff = (int)vDayOfWeek - (int)wNextWeek.DayOfWeek;
            return wNextWeek.AddDays(wDateDiff);
        }
    }
}
