using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Practice9_2 {
    internal class Program {

        //問題9-2
        //テキストファイルを読み込み、行の先頭に行番号を振り、その結果を別のテキストファイルに
        //出力するプログラムを書いてください。書式と出力先のファイル名は自由に決めて構いません。
        //出力するファイル名と同名のファイルがあった場合は、上書きしてください。

        static void Main(string[] args) {

            Console.WriteLine("検索対象のファイルのパスを入力してください。");
            string wFilePath = Console.ReadLine();

            //ファイルの有無を判定
            if (!File.Exists(wFilePath)) {
                Console.WriteLine("指定されたファイルが見つかりません。処理を中止します。");
                return;
            }

            //テキストファイルか判定
            if (Path.GetExtension(wFilePath) != ".txt") {
                Console.WriteLine("指定されたファイルはテキストファイルではありません。");
                return;
            }

            //※今回は結果を確認しやすくするため、読み込んだファイルと同じ階層に保存するようにしました
            string wDirectoryName = Path.GetDirectoryName(wFilePath);

            string wOutputFileName;
            while (true) {
                Console.WriteLine("保存先ファイルの拡張子を除いたファイル名を指定してください。");
                wOutputFileName = Console.ReadLine();
                if (wOutputFileName != Path.GetFileNameWithoutExtension(wFilePath)) break;
                Console.WriteLine("読み込んだファイルと同じ名前は使用できません。再度名前の指定をしてください。");
            }
            string wOutputPath = Path.Combine(wDirectoryName, wOutputFileName) + ".txt";
            File.WriteAllLines(wOutputPath, AddIndex(wFilePath));
        }

        /// <summary>
        /// テキストファイルのパスを引数に取り、テキストの各行に行番号を挿入したテキスト(IEnumerable)を返します。
        /// </summary>
        /// <param name="vFilePath">テキストファイルのパス</param>
        /// <returns>行番号が付与されたテキスト(IEnumerable)</returns>
        public static IEnumerable<string> AddIndex(string vFilePath) {
            IEnumerable<string> wTextLines = File.ReadAllLines(vFilePath, Encoding.UTF8);

            //空のテキストファイルの場合は行番号を付与せずそのまま返す
            if (!wTextLines.Any()) {
                Console.WriteLine("対象ファイルは空のテキストでした。");
                return wTextLines;
            }

            //行番号の最大桁数を求める
            int wDigits = (int)Math.Log10(wTextLines.Count()) + 1;  //行番号の最大桁数を求める

            return wTextLines.Select((x, y) => $"{(++y).ToString().PadLeft(wDigits)}: {x}");
        }
    }
}
