using System;
using System.IO;
using System.Text;

namespace Practice9_3 {
    internal class Program {

        //問題9-3
        //あるテキストファイルの最後に別のテキストファイルの内容を追加するコンソールアプリケーションを
        //書いてください。コマンドラインで2つのテキストファイルのパス名を指定できるようにしてください。

        static void Main(string[] args) {

            //コマンドライン引数の要素数をチェック
            if (args.Length != 2) {
                Console.WriteLine("引数の要素数が正しくありません。転記元と転記先の2つのファイルパスを渡してください。");
                return;
            }

            string wReadFilePath = args[0];
            if (!IsTextFile(wReadFilePath)) {
                Console.WriteLine("転記元のファイルパスを確認してください。");
                return;
            }

            var wTextLines = File.ReadLines(wReadFilePath, Encoding.UTF8);

            string wOutputFilePath = args[1];
            if (!IsTextFile(wOutputFilePath)) {
                Console.WriteLine("転記先のファイルパスを確認してください。");
                return;
            }

            using (var wOutputFile = new StreamWriter(wOutputFilePath, append: true)) {
                foreach (var wTextLine in wTextLines) {
                    wOutputFile.WriteLine(wTextLine);
                }
            }
        }

        /// <summary>
        /// ファイルパスを引数に受け取り、対象ファイルがテキストファイルかどうかをbool値で返します。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        /// <returns>bool値</returns>
        public static bool IsTextFile(string vFilePath) {
            if (!File.Exists(vFilePath)) {
                Console.WriteLine("指定したファイルが存在しないため、処理を終了します。");
                return false;
            }

            if (Path.GetExtension(vFilePath) != ".txt") {
                Console.WriteLine("テキストファイルを指定してください。");
                return false;
            }
            return true;
        }
    }
}
