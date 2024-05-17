using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practice10_4 {
    internal class Program {

        //問題10-4
        //テキストファイルを読み込み、version="v4.0"と書かれた箇所を、version="v5.0"に置き換え、
        //同じファイルに保存してください。なお、入力ファイルの = の前後には任意の数の空白文字が
        //入っていることもあります。出力時には、= の前後の空白は削除してください。
        //"version"は"Version"である可能性もあります。

        static void Main(string[] args) {

            if (args.Length == 0) {
                Console.WriteLine("コマンドラインの引数でテキストファイルのパスを指定してください。");
                return;
            }

            string wTextFilePath = args[0];

            //ファイルが存在しない、もしくはテキストファイルではない場合は処理を中止する
            if (!IsTextFile(wTextFilePath)) return;

            string[] wTexts = File.ReadAllLines(wTextFilePath);

            File.WriteAllLines(wTextFilePath, wTexts.Select(x => ReplaceVersion(x)));

            Console.WriteLine("置換が終了しました。");
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
        /// 文字列を引数に受け取り、文字列内に含まれる特定の文字列を置換した文字列を返します。
        /// </summary>
        /// <param name="vText">置換したい文字列</param>
        /// <returns>置換後の文字列</returns>
        public static string ReplaceVersion(string vText) {
            return Regex.Replace(vText, @"\b[vV]ersion\s*=\s*""v4\.0""", "version=\"v5.0\"");
        }
    }
}
