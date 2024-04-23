using System;
using System.Linq;

namespace Practice5_3_4 {
    internal class Program {

        //問題5-3-4
        //問題用文字列に含まれる4文字以下の単語を列挙してください。

        static void Main(string[] args) {

            //問題用文字列
            string wText = "Jackdaws love my big sphinx of quartz";

            //検索対象となる単語の文字数を指定
            int wWordLength = 4;

            string wResult = String.Join(",", GetWordsArray(wText, wWordLength));

            Console.WriteLine($"問題用文字列内の{wWordLength}文字以下の単語は以下の通りです。\n{wResult}");
        }

        /// <summary>
        /// 対象文字列と指定文字数を引数に受け取り、対象文字列を空白で分割して作られる文字列配列の中で、
        /// 指定文字数以下の単語のみを抽出した文字列配列を返します。
        /// </summary>
        /// <param name="vString">対象文字列</param>
        /// <param name="vLength">指定文字数</param>
        /// <returns>指定文字数以下の単語のみからなる文字列配列</returns>
        public static string[] GetWordsArray(string vString, int vLength) {

            //文字列の前後の空白を除去し、文字列を空白で分割した要素を空データを無視して配列に格納する
            string[] wWords = vString.Trim().Split(new[] { ' ' , '　' }, StringSplitOptions.RemoveEmptyEntries);
            string[] wCheckedWords = wWords.Where(s => s.Length <= vLength).ToArray();
            return wCheckedWords;
        }
    }
}
