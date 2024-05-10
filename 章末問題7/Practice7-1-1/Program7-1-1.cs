using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practice7_1_1 {
    internal class Program {

        //問題7-1-1
        //問題用文字列に対して、各アルファベット文字(空白などアルファベット以外は除外)が何文字ずつ
        //現れるかカウントするプログラムを書いてください。このときに、必ずディクショナリクラスを
        //使ってください。大文字/小文字の区別はしないでください。以下の形式で出力してください。
        //'A': 2
        //'B': 1
        //'C': 1
        //'D': 1

        static void Main(string[] args) {

            //問題用配列
            string wText = "Cozy lummox gives smart squid who asks for job pen";

            var wCharCountDic = new Dictionary<char, int>();

            foreach (char wCharacter in wText.ToUpper()) {

                //アルファベット以外は除外
                if (!Regex.IsMatch(wCharacter.ToString(), @"[A-Z]")) continue;

                //ディクショナリに存在しない要素は追加
                if (!wCharCountDic.TryGetValue(wCharacter, out int _)) {
                    wCharCountDic.Add(wCharacter, 1);
                    continue;
                }
                wCharCountDic[wCharacter]++;
            }

            //ディクショナリをキー順に並び替えてから全ての要素を表示
            foreach (var wItem in wCharCountDic.OrderBy(x => x.Key)) {
                Console.WriteLine($"'{wItem.Key}': {wItem.Value}");
            }
        }
    }
}
