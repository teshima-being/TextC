using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Practice7_1_2 {
    internal class Program {

        //問題7-1-2
        //Program7-1-1をSortedDictionary<TKey, TValue>を使って書き換えてください。

        static void Main(string[] args) {

            //問題用配列
            string wText = "Cozy lummox gives smart squid who asks for job pen";

            if (string.IsNullOrWhiteSpace(wText)) {
                Console.WriteLine("テキストがnullもしくは空白文字で構成されています。");
                return;
            }

            var wSortedCharCountDic = new SortedDictionary<char, int>();

            foreach (char wCharacter in wText.ToUpper()) {

                //アルファベット以外は除外
                if (!Regex.IsMatch(wCharacter.ToString(), @"[A-Z]")) continue;

                //ディクショナリに存在しない要素は追加
                if (!wSortedCharCountDic.TryGetValue(wCharacter, out int wCount)) {
                    wSortedCharCountDic.Add(wCharacter, 1);
                    continue;
                }
                wSortedCharCountDic[wCharacter]++;
            }

            foreach (var wItem in wSortedCharCountDic) {
                Console.WriteLine($"'{wItem.Key}': {wItem.Value}");
            }
        }
    }
}
