using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice3_2_2 {
    internal class Program {

        //問題3-2-2
        //LINQのCountメソッドを使い、小文字の'o'が含まれている都市名がいくつあるかカウントし、
        //その結果をコンソールに出力してください。

        static void Main(string[] args) {

            //問題用リスト
            var wNames = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong"
            };

            //CountCitiesメソッド呼び出し
            CountCities(wNames, 'o');
        }

        /// <summary>
        /// 都市名リストと検索文字を引数に受け取り、リスト内に検索文字を含む都市名がいくつあるか調べ、
        /// その結果をコンソールに表示する。
        /// </summary>
        /// <param name="vList">都市名リスト</param>
        /// <param name="vChar">検索文字(1文字)</param>
        public static void CountCities(List<string> vList, char vChar) {

            int wCountCities = vList.Count(s => s.Contains(vChar));
            
            if (wCountCities == 0) {
                Console.WriteLine($"文字{vChar}を含む都市名はリストに存在しません。");
                return;
            }
            Console.WriteLine($"文字{vChar}を含む都市名はリストに{wCountCities}個あります。");
        }
    }
}
