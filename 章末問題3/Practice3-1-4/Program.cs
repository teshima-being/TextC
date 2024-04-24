using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice3_1_4 {
    internal class Program {

        //問題3-1-4
        //LINQのSelectメソッドを使い、それぞれの値を2倍にし、その結果をList<int>に格納してください。
        //その後、List<int>の各要素をコンソールに出力してください。

        static void Main(string[] args) {

            //問題用リスト
            var wNumbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            IEnumerable<int> wNewNumbers = wNumbers.Select(x => x * 2);

            var wResult = new StringBuilder("問題用リストの各要素を2倍にした値は以下の通りです。\n");

            foreach (int wNum in wNewNumbers) {
                wResult.Append($"{wNum} ");
            }
            wResult.Length--;       //wResultの最後の半角スペースを削除
            Console.WriteLine(wResult.ToString());
        }
    }
}
