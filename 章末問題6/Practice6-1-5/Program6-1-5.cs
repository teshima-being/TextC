using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice6_1_5 {
    internal class Program {

        //問題6-1-5
        //問題用配列について、重複を排除した後、10より大きい値がいくつあるのかカウントし、
        //結果を表示してください。

        static void Main(string[] args) {

            //問題用配列
            var wNumbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            //LINQを使う場合
            int wOriginalNumbersCount = wNumbers.Distinct().Count(x => 10 < x);
            Console.WriteLine($"問題用配列の中に10より大きい値は{wOriginalNumbersCount}個あります。");

            //LINQを使わない場合
            var wOriginalNumbers = new List<int>();
            foreach (int wNumber in wNumbers) {
                if (!wOriginalNumbers.Contains(wNumber)) {
                    wOriginalNumbers.Add(wNumber);
                }                
            }
            int wCount = 0;
            foreach (int wNumber in wOriginalNumbers) {
                if (wNumber > 10) wCount++;
            }
            Console.WriteLine($"問題用配列の中に10より大きい値は{wCount}個あります。");
        }
    }
}
