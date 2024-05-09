using System;

namespace Practice4_1_4 {
    internal class Program {

        //問題4-1-4
        //ToStringメソッドをオーバーライドしてください。結果は、"2017年8月"といった形式にしてください。

        static void Main(string[] args) {

            var wYearMonth = new YearMonth(2100, 12);
            ShowYearMonth(wYearMonth);

            YearMonth wOneMonthLater = YearMonth.AddOneMonth(wYearMonth);
            ShowYearMonth(wOneMonthLater);
        }

        /// <summary>
        /// YearMonthオブジェクトを受け取り、そのプロパティの内容をコンソールに表示する
        /// </summary>
        /// <param name="vYearMonth">YearMonthオブジェクト</param>
        public static void ShowYearMonth(YearMonth vYearMonth) {
            string wMessage = vYearMonth.Is21Century ? "21世紀です" : "21世紀ではありません";
            Console.WriteLine($"{vYearMonth.ToString()}は{wMessage}");
        }
    }
}
