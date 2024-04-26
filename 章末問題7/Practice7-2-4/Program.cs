using Practice7_2_1;
using System;
using System.Collections.Generic;

namespace Practice7_2_4 {
    internal class Program {

        //問題7-2-4
        //3文字の略語だけを取り出し、以下の形式でコンソールに出力するコードを書いてください。
        //必要ならAbbreviationsクラスに新たなメソッドを追加してください。

        static void Main(string[] args) {

            var wOrganizations = new Abbreviations();

            foreach (KeyValuePair<string, string> wItem in wOrganizations.SearchOrgsWithWordCount(4)) {
                Console.WriteLine($"{wItem.Key}={wItem.Value}");
            }
        }
    }
}
