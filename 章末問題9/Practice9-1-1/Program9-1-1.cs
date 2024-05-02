using System;
using System.IO;
using System.Text;

namespace Practice9_1_1 {
    internal class Program {

        //問題9-1-1
        //指定したC#のソースファイルを読み込み、キーワード"class"が含まれている行数をカウントする
        //コンソールアプリケーションを作成してください。
        //このとき、StreamReaderクラスを使い、1行ずつ読み込む処理にしてください。
        //なお、以下の2点を前提として構いません。
        //①classキーワードの前後には、必ず空白文字がある
        //②リテラル文字列やコメントの中には、"class"という単語は含まれていない

        static void Main(string[] args) {

            Console.WriteLine("検索対象のファイルのパスを入力してください。");
            string wFilePath = Console.ReadLine();

            if (!File.Exists(wFilePath)) {
                Console.WriteLine("指定されたファイルが見つかりません。処理を中止します。");
                return;
            }

            Console.WriteLine("検索ワードを入力してください。");   //※今回の問題では" class "と入力する
            string wKeyWord = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(wKeyWord)) {
                Console.WriteLine("検索ワードに空白文字からなる文字列や空文字は指定できません。");
                return;
            }

            Console.WriteLine($"指定したファイルの中で{wKeyWord}を含む行は{CountRows(wFilePath, wKeyWord)}行あります。");
        }

        /// <summary>
        /// ファイルパスと検索ワードを引数に受け取り、指定ファイル内で検索ワードが含まれている行数をカウントします。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        /// <param name="vKeyWord">検索ワード</param>
        /// <returns>検索ワードを含む行数</returns>
        public static int CountRows(string vFilePath, string vKeyWord) {
            int wCount = 0;
            using (var wReader = new StreamReader(vFilePath, Encoding.UTF8)) {
                while (!wReader.EndOfStream) {
                    var wTargetLine = wReader.ReadLine();
                    if (wTargetLine.Contains(vKeyWord)) wCount++;
                }
            }
            return wCount;
        }
    }
}
