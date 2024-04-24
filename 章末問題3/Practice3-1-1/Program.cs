using System;
using System.Collections.Generic;

namespace Practice3_1_1 {
    internal class Program {

        //問題3-1-1
        //問題用リストに対し、List<T>のExistsメソッドを使い、8か9で割り切れる数があるかどうかを
        //調べ、その結果をコンソールに出力してください。

        static void Main(string[] args) {

            //問題用リスト
            var wNumbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            bool wHasNumber = wNumbers.Exists(x => x % 8 == 0 || x % 9 == 0);
            string wAnswer = wHasNumber ? "存在します" : "存在しません";
            Console.WriteLine("8か9で割り切れる数は" + wAnswer);
        }
    }
}
