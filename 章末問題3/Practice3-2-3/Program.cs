﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice3_2_3 {
    internal class Program {

        //問題3-2-3
        //LINQのWhereメソッドを使い、小文字の'o'が含まれている都市名を抽出し、配列に格納してください。
        //その後、配列の各要素をコンソールに出力してください。

        static void Main(string[] args) {

            //問題用リスト
            var wNames = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong"
            };

            //PickUpCitiesメソッド呼び出し
            PickUpCities(wNames, 'o');
        }

        /// <summary>
        /// 都市名リストと検索文字を引数に受け取り、検索文字が含まれる都市名のみをコンソールに表示する。
        /// </summary>
        /// <param name="vCityNames">都市名リスト</param>
        /// <param name="vKeyWord">検索文字(1文字)</param>
        public static void PickUpCities(IEnumerable<string> vCityNames, char vKeyWord) {

            string[] wCities = vCityNames.Where(x => x.Contains(vKeyWord)).ToArray();

            if (wCities == null) {
                Console.WriteLine($"文字{vKeyWord}を含む都市名はリストに存在しません。");
                return;
            }

            var wCityNamesResult = new StringBuilder($"文字{vKeyWord}を含む都市名は以下のようになります。\n");

            foreach (string wCity in wCities) {
                wCityNamesResult.Append(wCity + ", ");
            }

            wCityNamesResult.Length--;    //wCityNamesの最後のカンマを削除
            Console.WriteLine(wCityNamesResult.ToString());
        }
    }
}
