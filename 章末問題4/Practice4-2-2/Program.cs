using System;

namespace Practice4_2_2 {
    internal class Program {

        //問題4-2-2
        //4-2-1で作成した配列の要素(YearMonth)オブジェクトをすべて列挙し、その値をコンソールに出力してください。

        static void Main(string[] args) {

            var wYearMonths = new YearMonth[] {
                new YearMonth(1940, 7),
                new YearMonth(1964, 10),
                new YearMonth(1972, 12),
                new YearMonth(1998, 1),
                new YearMonth(2020, 9),
            };

            foreach (YearMonth wYearMonth in wYearMonths) {
                Console.WriteLine(wYearMonth.ToString());
            }
        }
    }
}
