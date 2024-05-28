using System.IO;

namespace TextFileProcessor {

    /// <summary>
    /// テキスト処理抽象クラス
    /// </summary>
    public abstract class TextProcessor {

        /// <summary>
        /// ファイルパスを引数に取り、ファイル内のテキストを1行ずつ読み込み、指定した処理を行います。
        /// </summary>
        /// <typeparam name="T">TextProcessorもしくはその派生クラス</typeparam>
        /// <param name="vFileName">ファイルパス</param>
        public static void Run<T>(string vFileName) where T : TextProcessor, new() {
            var wSelf = new T();
            wSelf.Process(vFileName);
        }

        /// <summary>
        /// ファイルパスを引数に取り、ファイル内のテキストを1行ずつ読み込み、指定した処理を行います。
        /// </summary>
        /// <param name="vFileName">ファイルパス</param>
        private void Process(string vFileName) {
            Initialize(vFileName);
            using (var wReader = new StreamReader(vFileName)) {
                while (!wReader.EndOfStream) {
                    string wLine = wReader.ReadLine();
                    Execute(wLine);
                }
            }
            Terminate();
        }

        /// <summary>
        /// 初期化処理を設定します。
        /// </summary>
        /// <param name="vFileName">ファイルパス</param>
        protected virtual void Initialize(string vFileName) { }

        /// <summary>
        /// 文字列に対する処理を設定します。
        /// </summary>
        /// <param name="vLine">文字列</param>
        protected virtual void Execute(string vLine) { }

        /// <summary>
        /// Runメソッドの最後に行う処理を設定します。
        /// </summary>
        protected virtual void Terminate() { }
    }
}
