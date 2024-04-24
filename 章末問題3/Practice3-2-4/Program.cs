using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice3_2_4 {
    internal class Program {

        //問題3-2-4
        //LINQのWhereメソッドとSelectメソッドを使い、'B'で始まる都市名の文字数を抽出し、
        //その文字数をコンソールに出力してください。都市名を表示する必要はありません。

        static void Main(string[] args) {

            //問題用リスト
            var wNames = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong"
            };

            //WhereメソッドとSelectメソッドを利用する
            IEnumerable<int> wCityEnum = wNames.Where(x => x[0] == 'B').Select(x => x.Length);
            foreach (int wCity in wCityEnum) {
                Console.WriteLine(wCity.ToString());
            }

            //練習
            //CountCharacterメソッドを呼び出す
            CountCharacter(wNames, 'B');
        }

        /// <summary>
        /// 都市名リストと検索文字を引数に受け取り、検索文字で始まる都市名とその文字数をコンソールに表示する。
        /// </summary>
        /// <param name="vList">都市名リスト</param>
        /// <param name="vChar">検索文字(1文字)</param>
        public static void CountCharacter(List<string> vList, char vChar) {
            
            var wCityNames = vList.Where(x => x[0] == vChar).ToList();

            if (wCityNames.Count == 0) {
                Console.WriteLine($"文字{vChar}で始まる都市名はリストに存在しません。");
                return;
            }
            Console.WriteLine($"文字{vChar}で始まる都市名とその文字数は以下の通りです。");

            foreach (string wCity in wCityNames) {
                Console.WriteLine($"都市名 {wCity}, 文字数 {wCity.Length}");
            }
        }
    }
}
