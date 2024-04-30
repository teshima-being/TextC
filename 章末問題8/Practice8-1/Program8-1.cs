using System;
using System.Globalization;

namespace Practice8_1 {
    internal class Program {

        //問題8-2
        //現在の日時を以下のような3種類の書式でコンソールに出力してください。
        //2019/1/15 19：48
        //2019年01月15日 19時48分32秒
        //平成31年 1月15日（火曜日） ※月は2桁固定で0サプレス

        static void Main(string[] args) {
            
            var wCulture = new CultureInfo("ja-JP");
            wCulture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var wToday = DateTime.Now;
            Console.WriteLine(wToday.ToString("yyyy/M/d HH:mm"));
            Console.WriteLine(wToday.ToString("yyyy年MM月dd日 HH時mm分ss秒"));
            Console.WriteLine(wToday.ToString($"ggyy年{wToday.Month,2}月d日（dddd）", wCulture));
        }
    }
}
