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

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("指定されたファイルは存在しません。パスを確認してください。");
                return;
            }

            if (Path.GetExtension(wFilePath) != ".html") {
                Console.WriteLine("HTMLファイルではありません。テキストファイルを指定してください。");
                return;
            }

            string[] wTexts = File.ReadAllLines(wFilePath);

            File.WriteAllLines(wFilePath, wTexts.Select(x => TagNameToLower(x)));

            //確認用
            foreach (string wText in wTexts) {
                Console.WriteLine(TagNameToLower(wText));
            }
        }

        /// <summary>
        /// HTMLファイル内の文字列を引数に受け取り、HTMLタグが大文字になっている箇所を小文字に変換した文字列を返す
        /// </summary>
        /// <param name="vText">HTMLファイル内の文字列</param>
        /// <returns>置換後の文字列</returns>
        public static string TagNameToLower(string vText) {
            string wPattern = @"<(/?)([A-Z]+)(.*?)>";
            return Regex.Replace(vText, wPattern, x => { return string.Concat("<", x.Groups[1].Value, x.Groups[2].Value.ToLower(), x.Groups[3].Value, ">"); });
        }
    }
}
