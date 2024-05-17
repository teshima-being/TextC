using System;
using System.Text.RegularExpressions;

namespace Practice10_3 {
    internal class Program {

        //問題10-3
        //問題用文字列配列から、単語"time"が含まれる文字列を取り出し、timeの開始位置を
        //すべて出力してください。大文字/小文字の区別なく検索してください。

        static void Main(string[] args) {

            //問題用文字列配列
            var wSampleTexts = new string[] {
                "Time is money.",
                "What time is it?",
                "It will take time.",
                "We reorganized the timetable.",
                "Time after time I've invited them over for dinner, but they never come.",  //文中にtimeが2度含まれる場合を追加
            };

            foreach (string wText in wSampleTexts) {
                var wMatches = Regex.Matches(wText, @"\btime\b", RegexOptions.IgnoreCase);

                foreach (Match wMatch in wMatches) {
                    Console.WriteLine($"{wText}：timeの開始インデックスは{wMatch.Index}です。");
                }
            }
        }
    }
}
