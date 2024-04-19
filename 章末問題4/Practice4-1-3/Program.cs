using System;

namespace Practice4_1_3 {
    internal class Program {

        //問題4-1-3
        //YearMonthクラスに、1ヵ月後を求めるAddOneMonthメソッドを追加してください。
        //このとき、自分自身のプロパティは変更せずに、新たなYearMonthオブジェクト
        //を生成しその値を返してください。12月の時の処理に注意してください。

        static void Main(string[] args) {

            var wYearMonth = new YearMonth(2000, 12);
            ShowYearMonth(wYearMonth);

            YearMonth wOneMonthLater = YearMonth.AddOneMonth(wYearMonth); //元のYearMonthオブジェクトが変更されていないか確認
            ShowYearMonth(wOneMonthLater);
            ShowYearMonth(wYearMonth);
        }

        /// <summary>
        /// YearMonthオブジェクトを受け取り、そのプロパティの内容をコンソールに表示する
        /// </summary>
        /// <param name="vYearMonth">YearMonthオブジェクト</param>
        public static void ShowYearMonth(YearMonth vYearMonth) {
            string wMessage = vYearMonth.Is21Century ? "21世紀です" : "21世紀ではありません";
            Console.WriteLine($"{vYearMonth.Year}年{vYearMonth.Month}月は{wMessage}");
        }
    }
}
