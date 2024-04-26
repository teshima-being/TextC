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
        /// <param name="vCityNames">都市名リスト</param>
        /// <param name="vKeyWord">検索文字(1文字)</param>
        public static void CountCharacter(IEnumerable<string> vCityNames, char vKeyWord) {
            
            var wCityNamesStartWithKey = vCityNames.Where(x => x[0] == vKeyWord);

            if (wCityNamesStartWithKey.Count() == 0) {
                Console.WriteLine($"文字{vKeyWord}で始まる都市名はリストに存在しません。");
                return;
            }
            Console.WriteLine($"文字{vKeyWord}で始まる都市名とその文字数は以下の通りです。");

            foreach (string wCity in wCityNamesStartWithKey) {
                Console.WriteLine($"都市名 {wCity}, 文字数 {wCity.Length}");
            }
        }
    }
}
