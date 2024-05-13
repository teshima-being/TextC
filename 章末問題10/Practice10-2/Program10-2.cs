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

            if (!File.Exists(wTextFilePath)) {
                Console.WriteLine("指定されたファイルは存在しません。パスを確認してください。");
                return;
            }

            if (Path.GetExtension(wTextFilePath) != ".txt") {
                Console.WriteLine("テキストファイルではありません。テキストファイルを指定してください。");
                return;
            }

            DisplayNumbers(wTextFilePath, 3);

            Console.WriteLine("処理が終わりました。");
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
