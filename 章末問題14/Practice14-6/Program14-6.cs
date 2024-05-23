using System;

namespace Practice14_6 {
    internal class Program {

        //問題14-6
        //日本（東京）の現地時間から、対応する協定世界時とシンガポールの現地時間を表示するコードを書いてください。

        static void Main(string[] args) {
            
            //東京の現在時刻を取得する
            DateTime wTokyoDateTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time"));
            Console.WriteLine($"東京の現地時間は{wTokyoDateTime:G}です。");

            //協定世界時に変換する
            Console.WriteLine($"協定世界時で表現すると{wTokyoDateTime.ToUniversalTime():G}です。");

            //シンガポールの現地時間に変換する
            DateTime wSingaporeDateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(wTokyoDateTime, "Singapore Standard Time");
            Console.WriteLine($"シンガポールの現地時間で表現すると{wSingaporeDateTime:G}です。");

            Console.ReadLine(); //確認用
        }
    }
}
