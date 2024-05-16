using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Practice14_1 {
    internal class Program {

        //問題14-1
        //ファイルにプログラムのパスとパラメータが複数行書かれています。このファイルを読み込み、
        //プログラムを順に起動するプログラムを書いてください。1つのプログラムが終わるのを待って
        //次のプログラムを起動してください。入力するファイルの形式は通常のテキストファイルでも
        //XMLファイルでも、好みの形式で構いません。

        static void Main(string[] args) {

            if (args.Length == 0) {
                Console.WriteLine("引数にプログラムの情報が格納されているテキストファイルを指定してください。");
                return;
            }

            var wTextFilePath = args[0];

            if (!File.Exists(wTextFilePath)) {
                Console.WriteLine("ファイルが見つかりません。パスを確認してください。");
            }

            if (Path.GetExtension(wTextFilePath) != ".txt") {
                Console.WriteLine("指定されたファイルはテキストファイルではありません。テキストファイルを指定してください。");
            }

            int wProgramNumber = 0;
            foreach (var wProgramInfo in File.ReadLines(wTextFilePath)) {
                string[] wProgramPathParamsPair = GetProgramPathAndParams(wProgramInfo);
                using (var wProcess = Process.Start(wProgramPathParamsPair[0], wProgramPathParamsPair[1])) {
                    wProcess.WaitForExit();
                    wProgramNumber++;
                    Console.WriteLine($"{wProgramNumber}行目のプログラムが完了しました。");
                }
            }
        }

        /// <summary>
        /// プログラムのパスや引数についての情報がカンマで区切られ、格納された文字列を引数に取り、要素1にプログラムのパス、
        /// 要素2にプログラムの引数をもつ要素数2の配列を返します。
        /// </summary>
        /// <param name="vProgramInfo">プログラムのパスと引数の情報がカンマで区切られ、格納された文字列</param>
        /// <returns>プログラムのパスと引数を要素にもつ、要素数2の配列</returns>
        static string[] GetProgramPathAndParams(string vProgramInfo) {
            var wProgramInfos = vProgramInfo.Split(',');

            var wProgramParams = new StringBuilder(string.Empty);

            if (wProgramInfos.Length > 0) {
                for (int i = 1; i < wProgramInfos.Length; i++) {
                    wProgramParams.Append(wProgramInfos[i] + " ");
                }
            }
            return new string[] { wProgramInfos[0], wProgramParams.ToString() };
        }
    }
}
