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
        /// <param name="vCityNames">都市名リスト</param>
        /// <param name="vKeyWord">検索文字(1文字)</param>
        public static void CountCities(IEnumerable<string> vCityNames, char vKeyWord) {

            int wCityCount = vCityNames.Count(x => x.Contains(vKeyWord));
            
            if (wCityCount == 0) {
                Console.WriteLine($"文字{vKeyWord}を含む都市名はリストに存在しません。");
                return;
            }
            Console.WriteLine($"文字{vKeyWord}を含む都市名はリストに{wCityCount}個あります。");
        }
    }
}
