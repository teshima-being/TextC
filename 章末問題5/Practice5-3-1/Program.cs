using System;
using System.Linq;

namespace Practice5_3_1 {
    internal class Program {

        //問題5-3-1
        //問題用文字列の中に空白が何文字あるかカウントしてください。

        static void Main(string[] args) {

            //問題用文字列
            string wText = "Jackdaws love my big sphinx of quartz";

            if (string.IsNullOrEmpty(wText)) {
                Console.WriteLine("問題用文字列がnullもしくは空文字であるため処理を中止します");
                return;
            }
            
            int wCharCounter = CountCharacters(wText, ' ');
            Console.WriteLine($"問題用文字列の中に検索文字は{wCharCounter}個あります。");

            //全角、半角の区別なく空白を数える場合
            int wBlankCounter = wText.Count(x => char.IsWhiteSpace(x));
            Console.WriteLine($"問題用文字列の中に空白は{wBlankCounter}個あります。");
        }

        /// <summary>
        /// 対象文字列と検索文字を受け取り、対象文字列の中に含まれている検索文字の個数を返します。
        /// </summary>
        /// <param name="vTargetText">対象文字列</param>
        /// <param name="vKeyWord">検索文字</param>
        /// <returns>対象文字列内の検索文字の個数</returns>
        public static int CountCharacters(string vTargetText, char vKeyWord) {
            return vTargetText.Count(x => x == vKeyWord);
        }
    }
}
