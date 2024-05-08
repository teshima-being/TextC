using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practice5_3_4 {
    internal class Program {

        //問題5-3-4
        //問題用文字列に含まれる4文字以下の単語を列挙してください。

        static void Main(string[] args) {

            //問題用文字列
            string wText = "Jackdaws love my big sphinx of quartz";

            //検索対象となる単語の文字数を指定
            int wWordLength = 4;

            string wResult = string.Join(",", Regex.Split(wText, @"\b\s+\b")
                                                   .Where(x => x.Length <= wWordLength).ToArray());

            Console.WriteLine($"問題用文字列内の{wWordLength}文字以下の単語は以下の通りです。\n{wResult}");
        }
    }
}
