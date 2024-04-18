using System;
using System.Collections.Generic;

namespace Practice3_1_2 {
    internal class Program {

        //問題3-1-2
        //List<T>のForEachメソッドを使い、各要素を2.0で割った値をコンソールに出力してください。

        //割る数
        private const float C_Number = 2.0f;

        static void Main(string[] args) {

            //問題用リスト
            var wNumbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            //問題用リストの各要素を割る数で割った結果を出力する
            wNumbers.ForEach(n => Console.WriteLine(n / C_Number));
        }
    }
}
