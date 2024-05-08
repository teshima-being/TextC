using System;
using System.Text.RegularExpressions;

namespace Practice5_3_2 {
    internal class Program {

        //問題5-3-2
        //問題用文字列の中の"big"という部分文字列を"small"に置き換えてください。

        static void Main(string[] args) {

            //問題用文字列
            string wText = "Jackdaws love my big sphinx of quartz";

            //置換したい文字列の指定（今回はbigを入力）
            Console.WriteLine("置換したい文字列を入力してください。");
            string wTargetWord = Console.ReadLine();

            //置換文字列に空文字を指定した場合は処理を終了する
            if (wTargetWord == string.Empty) {
                Console.WriteLine("置換文字列に空文字は指定できません。");
                return;
            }

            //置換後の文字列の指定（今回はsmallを入力）
            Console.WriteLine("置換後の文字列を入力してください。");
            string wReplacedWord = Console.ReadLine();

            Console.WriteLine($"問題用文字列内の{wTargetWord}を指定文字列に置き換えた後の結果は以下の通りです。\n" +
                              $"{ReplaceWord(wText, wTargetWord, wReplacedWord)}");
        }

        /// <summary>
        /// 対象文字列、置換文字列、置換後文字列を引数に受け取り、対象文字列内の置換文字列を
        /// 置換した後の文字列を返します。
        /// </summary>
        /// <param name="vText">対象文字列</param>
        /// <param name="vTarget">置換文字列</param>
        /// <param name="vReplaced">置換後文字列</param>
        /// <returns>置換が完了した対象文字列</returns>
        public static string ReplaceWord(string vText, string vTarget, string vReplaced) {

            string wReplacedText = vText.Replace(vTarget, vReplaced);

            //置換文字列が見つからなかった場合
            if (wReplacedText == vText) {
                return $"問題用文字列の中に{vTarget}という単語は存在しません。";
            }

            //置換後文字列に空文字を指定した場合は余計な半角スペースを削除する
            if (vReplaced == string.Empty) {
                return DeleteBlanks(wReplacedText);
            }

            //通常時の処理
            return wReplacedText;
        }

        /// <summary>
        /// 対象文字列を引数に受け取り、余計なスペースを削除した後の文字列を返します。
        /// </summary>
        /// <param name="vText">対象文字列</param>
        /// <returns>余計なスペースを削除した後の文字列</returns>
        public static string DeleteBlanks(string vText) {
            var wRegex = new Regex(@"\s+");
            return wRegex.Replace(vText, " ").Trim();
        }
    }
}
