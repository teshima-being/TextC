using System;

namespace Practice5_3_3 {
    internal class Program {

        //問題5-3-3
        //問題用文字列の中に単語がいくつあるかカウントしてください。

        static void Main(string[] args) {

            //問題用文字列
            string wText = "  Jackdaws 　love　my big　　 sphinx 　of quartz　　";

            if (string.IsNullOrEmpty(wText)) {
                Console.WriteLine("問題用文字列がnullもしくは空文字であるため処理を中止します");
                return;
            }

            Console.WriteLine($"問題用文字列に含まれる単語数は{CountWords(wText)}個です。");
        }

        /// <summary>
        /// 対象文字列を引数に受け取り、その文字列内の単語の個数を返します。
        /// </summary>
        /// <param name="vTargetText">対象文字列</param>
        /// <returns>対象文字列内の単語数</returns>
        public static int CountWords(string vTargetText) {

            //文字列を空白で分割した要素を空データを無視して配列に格納する
            string[] wWords = vTargetText.Trim().Split(new[] { ' ' , '　' }, StringSplitOptions.RemoveEmptyEntries);

            return wWords.Length;
        }
    }
}
