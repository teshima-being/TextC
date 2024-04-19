using System;

namespace Practice4_2_4 {
    internal class Program {

        //問題4-2-4
        //4-2-3で作成したメソッドを呼び出し、最初に見つかった21世紀のデータの年を表示してください。
        //見つからなければ、"21世紀のデータはありません"を表示してください。

        static void Main(string[] args) {

            var wYearMonths = new YearMonth[] {
                new YearMonth(1940, 7),
                new YearMonth(1964, 10),
                new YearMonth(1972, 12),
                new YearMonth(1998, 1),
                new YearMonth(2020, 9),
            };

            Console.WriteLine(Get21Century(wYearMonths)?.Year.ToString("0年") ?? "21世紀のデータはありません");
        }

        /// <summary>
        /// YearMonthオブジェクトの配列と受け取り、配列の中の最初に見つかった21世紀のYearMonthオブジェクトを返す。
        /// 見つからなかった場合はnullを返す。
        /// </summary>
        /// <param name="vYearMonths">YearMonthオブジェクトの配列</param>
        /// <returns>21世紀のYearMonthオブジェクト</returns>
        public static YearMonth Get21Century(YearMonth[] vYearMonths) {
            foreach (YearMonth wYearMonth in vYearMonths)
                if (wYearMonth.Is21Century){
                    return wYearMonth;
                }
            return null;
        }
    }
}
