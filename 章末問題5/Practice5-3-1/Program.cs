using System;
using System.Linq;

namespace Practice5_3_1 {
    internal class Program {

        //問題5-3-1
        //問題用文字列の中に空白が何文字あるかカウントしてください。

        static void Main(string[] args) {

            //問題用文字列
            string wText = "　Jackdaws love my big　sphinx of quartz";

            //全角、半角の区別なく空白を数える
            int wBlankCounter = wText.Count(x => char.IsWhiteSpace(x));
            Console.WriteLine($"問題用文字列の中に空白は{wBlankCounter}個あります。");
        }
    }
}
