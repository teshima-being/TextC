using System;
using System.IO;
using System.IO.Compression;
using System.Linq;


namespace Practice14_5 {
    internal class Program {

        //問題14-5
        //指定されたZIPファイルから、拡張子が.txtのファイルだけを抽出するコンソールアプリケーションを
        //作成してください。ZIPファイルと出力先フォルダはパラメータで指定するようにしてください。
        //第1パラメータがZIPファイルのパス、第2パラメータが出力先フォルダです。
        //出力先フォルダが存在しない場合は新たに作成してください。

        static void Main(string[] args) {

            if (args.Length != 2) {
                Console.WriteLine("引数の数が不正です。第1引数で対象ZIPファイルのパス、第2引数で出力先フォルダのパスを指定してください。");
                return;
            }

            string wZipFilePath = args[0];
            if (!IsZipFile(wZipFilePath)) return;

            using (ZipArchive wZip = ZipFile.OpenRead(wZipFilePath)) {
                var wAllTextFiles = wZip.Entries.Where(x => Path.GetExtension(x.Name) == ".txt");

                if (wAllTextFiles == null) {
                    Console.WriteLine("テキストファイルが存在しません。処理を中止します。");
                    return;
                }

                string wOutputDirPath = args[1];
                if (!Directory.Exists(wOutputDirPath)) {
                    Directory.CreateDirectory(wOutputDirPath);
                }

                foreach (var wFile in wAllTextFiles) {
                    wFile.ExtractToFile(Path.Combine(wOutputDirPath, wFile.Name), overwrite: true);
                }
            }
            Console.WriteLine("処理が終了しました。");

            Console.ReadLine(); //確認用
        }


        /// <summary>
        /// ファイルパスを引数に取り、指定されたファイルが存在するかとZIPファイルであるかを判定し、
        /// 両方満たす場合のみtrueを返します。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        /// <returns>bool値</returns>
        public static bool IsZipFile(string vFilePath) {
            if (!File.Exists(vFilePath)) {
                Console.WriteLine("ファイルが見つかりません。パスを確認してください。");
                return false;
            }
            if (Path.GetExtension(vFilePath) != ".zip") {
                Console.WriteLine("ZIPファイルではありません。検索対象にはZIPファイルを指定してください。");
                return false;
            }
            return true;
        }
    }
}
