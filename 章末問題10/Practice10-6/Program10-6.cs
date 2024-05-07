using System;
using System.Text.RegularExpressions;

namespace Practice10_6 {
    internal class Program {

        //問題10-6
        //5文字の回文とマッチする正規表現を書いてください。数字や記号だけから成る回文を除外するにはどうしたら
        //良いかも考えてください。

        static void Main(string[] args) {

            //確認用文字列
            var wTexts = new string[] {"しんぶんし", "こんばんは", "くすりのりすく", "level", "０_９_０",
                                       "はんしんは", "よわいわよ", "12321", "?_?_?", "e_e_e", "つまがまつ" };

            foreach (var w in wTexts) {
                Console.WriteLine($"{w} ⇒ {IsKaibun(w)}");
            }
        }

        /// <summary>
        /// 文字列を引数に取り、その文字列が5文字の回文の場合はtrue、そうでない場合はfalseを返します。
        /// なお、文字列が数字と記号(アンダーバー含む)のみからなる場合falseを返します。
        /// </summary>
        /// <param name="vWord">文字列</param>
        /// <returns>bool値</returns>
        public static bool IsKaibun(string vWord) {
            if (!Regex.IsMatch(vWord, @"\b(\w)(\w)\w\2\1\b")) return false;

            if (Regex.IsMatch(vWord, @"\b[\d_＿]+\b")) return false;

            return true;
        }
    }
}
