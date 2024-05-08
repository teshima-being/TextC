using System;
using System.Text.RegularExpressions;

namespace Practice5_3_3 {
    internal class Program {

        //問題5-3-3
        //問題用文字列の中に単語がいくつあるかカウントしてください。

        static void Main(string[] args) {

            //問題用文字列
            string wText = "  Jackdaws 　love\nmy big　　 sphinx 　of\rquartz　　";

            int wWordsCount = Regex.Split(wText, @"\b\s+\b").Length;
            Console.WriteLine($"問題用文字列に含まれる単語数は{wWordsCount}個です。");
        }
    }
}
