using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice16_2 {
    internal class Program {

        //問題16-2
        //指定したディレクトリにあるC#のソースファイル(サブディレクトリを含む)の中を全て検索し、
        //キーワードasyncとawaitの両方を利用しているファイルを列挙してください。
        //列挙する際は、ファイルのフルパスを表示してください。表示する順番は問いません。
        //並列処理をした場合と並列処理をしない場合の2つのバージョンを作成し、どれくらい速度に
        //違いがあるかも調べてください。

        static void Main(string[] args) {

            if (args.Length == 0) {
                Console.WriteLine("引数が不正です。コマンドライン引数で検索対象ディレクトリのパスを指定してください。");
                return;
            }

            string wDirPath = args[0];
            if (!Directory.Exists(wDirPath)) {
                Console.WriteLine("ディレクトリが見つかりません。ディレクトリのパスを確認してください。");
                return;
            }

            string[] wFilePaths = Directory.GetFiles(wDirPath, "*.cs", SearchOption.AllDirectories);

            while (true) {
                Console.WriteLine($"並列処理をしない場合は0\nTaskクラスで並列処理をする場合は1\nPLINQで並列処理をする場合は3\nを入力してください。");

                if (int.TryParse(Console.ReadLine(), out int wUserInputNumber)) {
                    if (0 <= wUserInputNumber && wUserInputNumber <= 2) {
                        DisplayResult(wUserInputNumber, wFilePaths);
                        break;
                    }
                }
                Console.WriteLine("入力値が不正です。0, 1, 2 のいずれかで指定してください。");
            }
        }

        /// <summary>
        /// ファイルパスのコレクションを引数にとり、対象ファイル内で "async", "await" の両キーワードを利用している
        /// ファイルのパスを取得し、コンソールに表示します。
        /// </summary>
        /// <param name="vFilePaths">ファイルパスのコレクション</param>
        static void SearchAllFiles(IEnumerable<string> vFilePaths) {

            foreach (string wFilePath in vFilePaths) {
                DisplayFilePath(wFilePath);
            }
            Console.WriteLine("処理が終了しました。");
        }

        /// <summary>
        /// ファイルパスのコレクションを引数にとり、対象ファイル内で "async", "await" の両キーワードを利用している
        /// ファイルのパスを取得し、コンソールに表示します。
        /// なお、このメソッドはTaskクラスを利用した並列処理を実行します。
        /// </summary>
        /// <param name="vFilePaths">ファイルパスのコレクション</param>
        static async Task SearchAllFilesWithTask(IEnumerable<string> vFilePaths) {

            var wTasks = new List<Task>();

            foreach (string wFilePath in vFilePaths) {
                var wTask = Task.Run(() => DisplayFilePath(wFilePath));
                wTasks.Add(wTask);
            }
            await Task.WhenAll(wTasks);
            Console.WriteLine("処理が終了しました。");
        }

        /// <summary>
        /// ファイルパスのコレクションを引数にとり、対象ファイル内で "async", "await" の両キーワードを利用している
        /// ファイルのパスを取得し、コンソールに表示します。
        /// なお、このメソッドはPLINQを利用した並列処理を実行します。
        /// </summary>
        /// <param name="vFilePaths">ファイルパスのコレクション</param>
        static void SearchAllFilesWithPlinq(IEnumerable<string> vFilePaths) {

            IEnumerable<string[]> wFileInfoPairs = vFilePaths.AsParallel().Select(x => new[] { x, File.ReadAllText(x) })
                                                             .Where(x => Regex.IsMatch(x[1], @"\basync\b") && Regex.IsMatch(x[1], @"\bawait\b"));

            foreach (string[] wFileInfoPair in wFileInfoPairs) {
                Console.WriteLine(wFileInfoPair[0]);
            }
            Console.WriteLine("処理が終了しました。");
        }

        /// <summary>
        /// ファイルパスを引数にとり、対象ファイル内で"async", "await" の両キーワードを利用している場合、
        /// そのファイルのパスをコンソールに表示します。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        static void DisplayFilePath(string vFilePath) {
            string wText = File.ReadAllText(vFilePath);
            if (Regex.IsMatch(wText, @"\basync\b") && Regex.IsMatch(wText, @"\bawait\b")) {
                Console.WriteLine(vFilePath);
            }
        }


        static void DisplayResult(int vNumber, IEnumerable<string> vFilePaths) {

            var wSW = new Stopwatch();
            wSW.Start();

            switch (vNumber) {
                case 0:
                    Console.WriteLine("********並列処理を利用しなかった場合********");
                    SearchAllFiles(vFilePaths);
                    break;
                case 1:
                    Console.WriteLine("**********Taskクラスを利用した場合**********");
                    SearchAllFilesWithTask(vFilePaths).Wait();
                    break;
                case 2:
                    Console.WriteLine("************PLINQを利用した場合************");
                    SearchAllFilesWithPlinq(vFilePaths);
                    break;
            }

            wSW.Stop();
            Console.WriteLine($"処理に要した時間は{wSW.ElapsedMilliseconds}ミリ秒でした。");
        }
    }
}
