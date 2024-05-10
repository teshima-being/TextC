using System;
using System.Linq;

namespace Practice6_1_1 {
    internal class Program {

        //問題6-1-1
        //問題用配列の中で、最大値を求め、結果を表示してください。

        static void Main(string[] args) {

            //問題用配列
            var wNumbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            //LINQを使う場合
            int wMaxNumber = wNumbers.Max();
            Console.WriteLine($"最大値は{wMaxNumber}です");

            //LINQを使わない場合
            int wNoLinqMax = int.MinValue;  //int範囲の最小値を初期値に設定
            foreach (int wNumber in wNumbers) {
                if (wNoLinqMax < wNumber)
                    wNoLinqMax = wNumber;
            }
            Console.WriteLine($"最大値は{wNoLinqMax}です");
        }
    }
}
