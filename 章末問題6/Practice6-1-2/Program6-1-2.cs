using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice6_1_2 {
    internal class Program {

        //問題6-1-2
        //問題用配列の中で、最後から2つの要素を取り出して表示してください。

        static void Main(string[] args) {

            //問題用配列
            var wNumbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
          
            //ユーザー入力値による判定（今回は2と入力する）
            Console.WriteLine("配列の後ろから抜き出したい要素の個数を指定してください。");
            if (!int.TryParse(Console.ReadLine(), out int wItemsCount)){
                Console.WriteLine("有効な数値を入力してください。");
                return;
            }

            //配列の要素数による判定
            if (wNumbers.Length < wItemsCount) {
                Console.WriteLine($"配列内の要素が不足しているため、指定された個数分の要素を取得できません");
                return;
            }

            //LINQを使う場合
            IEnumerable<int> wNumbersFromLast = wNumbers.Skip(wNumbers.Length - wItemsCount);
            Console.WriteLine($"配列の最後から要素を{wItemsCount}個取り出した結果は以下の通りです。");
            Console.WriteLine(string.Join(",", wNumbersFromLast));
     
            //LINQを使わない場合
            int wCount = 0;
            var wNoLinqNumbers = new List<int>();
            foreach (int wNumber in wNumbers) {
                if (wCount < wNumbers.Length - wItemsCount) {
                    wCount++;
                    continue;
                }
                wNoLinqNumbers.Add(wNumber);
            }
            Console.WriteLine($"配列の最後から要素を{wItemsCount}個取り出した結果は以下の通りです。");
            Console.WriteLine(string.Join(",", wNoLinqNumbers));
        }
    }
}
