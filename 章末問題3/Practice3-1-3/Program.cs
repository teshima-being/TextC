using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice3_1_3 {
    internal class Program {

        //問題3-1-3
        //LINQのWhereメソッドを使い、値が50以上の要素を列挙し、その結果をコンソールに出力してください。

        static void Main(string[] args) {

            //問題用リスト
            var wNumbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            //値が50以上の要素だけを取り出す
            IEnumerable<int> wNewNumbers = wNumbers.Where(x => x >= 50);

            var wResult = new StringBuilder(string.Empty);

            foreach (var wNum in wNewNumbers) {
                wResult.Append(wNum.ToString() + " ");
            }
            wResult.Remove(wResult.Length - 1, 1);    //wResultの最後の半角スペースを削除

            Console.WriteLine($"50以上の数字は{wResult}です");
        }
    }
}
