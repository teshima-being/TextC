using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practice10_5 {
    internal class Program {

        //問題10-5
        //HTMLファイルを読み込み、<DIV>や<P>などのタグ名が大文字になっているものを<div>、<p>などと
        //小文字のタグに変換してください。可能ならば、<DIV class="myBox" id="myId">のように属性が
        //記述されている場合にも対応してください。属性の中には'<'、'>'は含まれていないものとします。

        static void Main(string[] args) {

            if (args.Length == 0) {
                Console.WriteLine("コマンドラインの引数でHTMLファイルのパスを指定してください。");
                return;
            }

            string wFilePath = args[0];

            //ファイルが存在しない、もしくはHTMLファイルではない場合は処理を中止する
            if (!IsHTMLFile(wFilePath)) return;

            string[] wTexts = File.ReadAllLines(wFilePath);

            File.WriteAllLines(wFilePath, wTexts.Select(x => ConvertTagNameToLower(x)));

            //確認用
            foreach (string wText in wTexts) {
                Console.WriteLine(ConvertTagNameToLower(wText));
            }
        }

        /// <summary>
        /// ファイルパスを引数に取り、該当ファイルが存在するか、HTMLファイルであるかを判定し、両方満たす場合のみ
        /// trueを返します。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        /// <returns>bool値</returns>
        public static bool IsHTMLFile(string vFilePath) {
            if (!File.Exists(vFilePath)) {
                Console.WriteLine("指定されたファイルは存在しません。パスを確認してください。");
                return false;
            }
            if (Path.GetExtension(vFilePath) != ".html") {
                Console.WriteLine("HTMLファイルではありません。HTMLファイルを指定してください。");
                return false;
            }
            return true;
        }

        /// <summary>
        /// HTMLファイル内の文字列を引数に受け取り、HTMLタグが大文字になっている箇所を小文字に変換した文字列を返す
        /// </summary>
        /// <param name="vText">HTMLファイル内の文字列</param>
        /// <returns>置換後の文字列</returns>
        public static string ConvertTagNameToLower(string vText) {
            string wPattern = @"<(/?)([A-Z]+)(.*?)>";
            return Regex.Replace(vText, wPattern, x => {
                return string.Concat("<", x.Groups[1].Value, x.Groups[2].Value.ToLower(), x.Groups[3].Value, ">");
            });
        }
    }
}
