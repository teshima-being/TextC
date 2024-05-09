using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice4_2_5 {
    internal class Program {

        //問題4-2-5
        //配列に格納されているすべてのYearMonthの1ヵ月後を求め、その結果を新たな配列に
        //入れてください。その後、その配列の要素の内容(年月)を順に表示してください。
        //LINQを使えるところはLINQを使って実装してください。

        static void Main(string[] args) {

            var wYearMonths = new YearMonth[] {
                new YearMonth(1940, 7),
                new YearMonth(1964, 10),
                new YearMonth(1972, 12),
                new YearMonth(2000, 12),
                new YearMonth(2020, 9),
            };

            //すべてのYearMonthの1ヵ月後を求め、新たな配列に格納する
            YearMonth[] wOneMonthLaters = wYearMonths.Select(x => YearMonth.AddOneMonth(x)).ToArray();

            //新たな配列の各要素の内容をコンソールに表示する
            foreach (YearMonth wYearMonth in wOneMonthLaters) {
                string wMessage = wYearMonth.Is21Century ? "21世紀です" : "21世紀ではありません";
                Console.WriteLine($"{wYearMonth}は{wMessage}");
            }

            //すべてのYearMonthの1ヵ月後を求め、新たなListに格納する
            List<YearMonth> wOneMonthPassed = wYearMonths.Select(x => YearMonth.AddOneMonth(x)).ToList();

            //新たなListの各要素の内容をコンソールに表示する
            wOneMonthPassed.ForEach(x => Console.WriteLine(x +"は" + (x.Is21Century? "21世紀です" : "21世紀ではありません")));
        }
    }
}
