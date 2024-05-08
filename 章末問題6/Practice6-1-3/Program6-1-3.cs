using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice6_1_3 {
    internal class Program {

        //問題6-1-3
        //問題用配列のそれぞれの数値を文字列に変換し、結果を表示してください。

        static void Main(string[] args) {

            //問題用配列
            var wNumbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            //LINQを使う場合
            IEnumerable<string> wTextNumbers = wNumbers.Select(x => x.ToString());
            string wResult = string.Join(",", wTextNumbers);
            Console.WriteLine($"問題用配列を文字列配列に変換したものは以下の通りです。\n{wResult}");

            //LINQを使わない場合
            var wNumbersList = new List<string>();
            foreach (int wNumber in wNumbers) {
                wNumbersList.Add(wNumber.ToString());
            }
            string wNoLinqResult = string.Join(",", wNumbersList);
            Console.WriteLine($"問題用配列を文字列配列に変換したものは以下の通りです。\n{wNoLinqResult}");
        }
    }
}
