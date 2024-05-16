using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Practice10_2 {
    internal class Program {

        //問題10-2
        //テキストファイルを読み込み、3文字以上の数字だけからなる部分文字列を
        //全て抜き出すコードを書いてください。

        static void Main(string[] args) {

            if (args.Length == 0) {
                Console.WriteLine("コマンドラインの引数でテキストファイルのパスを指定してください。");
                return;
            }

            string wTextFilePath = args[0];

            //ファイルが存在しない、もしくはテキストファイルではない場合は処理を中止する
            if (!IsTextFile(wTextFilePath)) return;

            DisplayNumbers(wTextFilePath, 3);

            Console.WriteLine("処理が終わりました。");
        }

        /// <summary>
        /// ファイルパスを引数に取り、該当ファイルが存在するか、テキストファイルであるかを判定し、両方満たす場合のみ
        /// trueを返します。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        /// <returns>bool値</returns>
        public static bool IsTextFile(string vFilePath) {
            if (!File.Exists(vFilePath)) {
                Console.WriteLine("指定されたファイルは存在しません。パスを確認してください。");
                return false;
            }
            if (Path.GetExtension(vFilePath) != ".txt") {
                Console.WriteLine("テキストファイルではありません。テキストファイルを指定してください。");
                return false;
            }
            return true;
        }

        /// <summary>
        /// テキストファイルのファイルパスと文字数を引数にとり、指定文字数以上の数字だけからなる部分文字列を
        /// 全て抜き出し、コンソールに表示します。
        /// </summary>
        /// <param name="vFilePath">テキストファイルパス</param>
        /// <param name="vLength">数字の文字数</param>
        public static void DisplayNumbers(string vFilePath, int vLength) {
            string wTexts;
            using (var wReader = new StreamReader(vFilePath)) {
                wTexts = wReader.ReadToEnd();
            }

            var wMatches = Regex.Matches(wTexts, $@"\b\d{{{vLength},}}\b");

            if (wMatches.Count == 0) {
                Console.WriteLine("条件を満たす文字列は存在しませんでした。");
                return;
            }

            foreach (Match wMatch in wMatches) {
                Console.WriteLine(wMatch.Value);
            }
        }
    }
}
