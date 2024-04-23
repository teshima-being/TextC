using System;

namespace Practice5_1 {
    internal class Program {

        //問題5-1
        //コンソールから入力した2つの文字列が等しいか調べるコードを書いてください。
        //このとき、大文字、小文字の違いは無視するようにしてください。コンソールからの
        //入力は、Console.ReadLineメソッドを利用してください。

        static void Main(string[] args) {
            Console.WriteLine("2つの文字列を比較します。なお、終了するときは\"終了\"と入力してください。");
            
            while (true) {

                Console.WriteLine("1つ目の文字列を入力してください。");
                string wText1 = Console.ReadLine();
                if (wText1 == "終了") break;

                Console.WriteLine("2つ目の文字列を入力してください。");
                string wText2 = Console.ReadLine();
                if (wText2 == "終了") break;

                string wResult = CompareString(wText1, wText2)? "一致しています。":"一致していません。";
                Console.WriteLine($"2つの文字列は{wResult}");
            }
        }

        /// <summary>
        /// 2つの文字列を引数に取り、文字列が等しいか否かをbool値で返します。
        /// 比較の際には大文字と小文字の違いは無視をします。
        /// </summary>
        /// <param name="vText1">1つ目の文字列</param>
        /// <param name="vText2">2つ目の文字列</param>
        /// <returns>bool値</returns>
        public static bool CompareString(string vText1, string vText2) {
            return String.Compare(vText1, vText2, ignoreCase: true) == 0;
        }
    }
}
