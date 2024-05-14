using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Practice9_1_2 {
    internal class Program {

        //問題9-1-2
        //9-1-1で作成したプログラムをFile.ReadAllLinesメソッドを利用して書き換えてください。

        static void Main(string[] args) {

            Console.WriteLine("検索対象のファイルのパスを入力してください。");
            string wFilePath = Console.ReadLine();

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("指定されたファイルが見つかりません。処理を中止します。");
                return;
            }

            Console.WriteLine("検索ワードを入力してください。");
            string wKeyWord = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(wKeyWord)) {
                Console.WriteLine("検索ワードに空白文字からなる文字列や空文字は指定できません。");
                return;
            }

            Console.WriteLine($"指定したファイルの中で{wKeyWord}を含む行は{CountRows(wFilePath, wKeyWord)}行あります。");
        }

        /// <summary>
        /// ファイルパスと検索ワードを引数に受け取り、指定ファイル内で検索ワードが含まれている行数をカウントします。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        /// <param name="vKeyWord">検索ワード</param>
        /// <returns>検索ワードを含む行数</returns>
        public static int CountRows(string vFilePath, string vKeyWord) {
            return File.ReadAllLines(vFilePath, Encoding.UTF8).Count(x => x.Contains(vKeyWord));
        }
    }
}
