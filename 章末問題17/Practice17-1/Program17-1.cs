using System;
using System.IO;
using TextFileProcessor;

namespace Practice17_1 {
    internal class Program {

        //問題17-1
        //テキスト中で示したTextProcessorクラスを使い、テキストファイルの中の全角数字をすべて
        //半角数字に置き換えて、置き換えた結果をコンソールに出力するプログラムを作ってください。

        static void Main(string[] args) {

            if (args.Length == 0) {
                Console.WriteLine("引数にテキストファイルのパスを指定してください。");
                return;
            }

            string wTextFilePath = args[0];

            if (IsTextFile(wTextFilePath)) {
                TextProcessor.Run<NumberConverter>(wTextFilePath);
            }
        }

        /// <summary>
        /// ファイルパスを引数に取り、対象ファイルが存在するかとテキストファイルであるかを判定します。
        /// 両方真の場合のみtrueを返し、それ以外の場合はfalseを返します。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        /// <returns>bool値</returns>
        static bool IsTextFile(string vFilePath) {

            if (!File.Exists(vFilePath)) {
                Console.WriteLine("ファイルが見つかりません。パスを確認してください。");
                return false;
            }

            if (Path.GetExtension(vFilePath) != ".txt") {
                Console.WriteLine("指定されたファイルはテキストファイルではありません。テキストファイルを指定してください。");
                return false;
            }
            return true;
        }
    }
}
