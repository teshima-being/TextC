using System;
using System.Text;

namespace Practice5_3_5 {
    internal class Program {

        //問題5-3-5
        //問題用文字列を空白で区切り、配列に格納した後、StringBuilderクラスを使い文字列を連結させ、
        //元の文字列と同じものを作り出してください。元の文字列の中には連続した空白は存在しないもの
        //とします。

        static void Main(string[] args) {

            //問題用文字列
            string wText = "jackdaws love my big sphinx of quartz";

            var wRemakedText = new StringBuilder();
            foreach (string wWord in GetWordsArray(wText)) {
                wRemakedText.Append(wWord + ' ');
            }

            //リメイク後のテキストと元のテキスト両方表示して確認
            Console.WriteLine(wRemakedText.Remove(wRemakedText.Length - 1, 1));
            Console.WriteLine(wText);
        }

        /// <summary>
        /// 文字列を引数に受け取り、文字列を半角スペースで区切って作成した文字列配列を返します。
        /// </summary>
        /// <param name="vString"></param>
        /// <returns></returns>
        public static string[] GetWordsArray(string vString) {
            string[] wWordsArray = vString.Split(' ');
            return wWordsArray;
        }
    }
}
