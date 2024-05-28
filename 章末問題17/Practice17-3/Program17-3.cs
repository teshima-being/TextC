using System;
using System.IO;

namespace Practice17_3 {
    internal class Program {

        //問題17-3
        //17-1で作成したプログラムを指定した構造(テキスト430p参照)に合うように書き換えてください。
        //なお、ITextFileServiceとTextFileProcessorは以下の通りとします。

        /*
        public interface ITextFileService {
            void Initialize(string fname);
            void Execute(string line);
            void Terminate();
        }

        public class TextFileProcessor {
            private ITextFileService _service;
            
            public  TextFileProcessor(ITextFileService service) {
                _service = service;
            }

            public void Run(string fileName) {
                _service.Initialize(fileName);
                using(var sr = new SreamReader(fileName)) {
                    while(!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        _service.Execute(line);
                    }
                }
                _service.Terminate();
            }
        }
        */

        static void Main(string[] args) {

            if (args.Length == 0) {
                Console.WriteLine("引数にテキストファイルのパスを指定してください。");
                return;
            }

            string wTextFilePath = args[0];

            if (IsTextFile(wTextFilePath)) {
                var wToHankaku = new ToHankakuService();
                var wTextFileProcessor = new TextFileProcessor(wToHankaku);
                wTextFileProcessor.Run(wTextFilePath);
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
