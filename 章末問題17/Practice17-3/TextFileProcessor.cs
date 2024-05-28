using System.IO;

namespace Practice17_3 {

    /// <summary>
    /// テキストファイル処理クラス
    /// </summary>
    public class TextFileProcessor {

        private ITextFileService FService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vService">テキスト処理インターフェース</param>
        public TextFileProcessor(ITextFileService vService) {
            this.FService = vService;
        }

        /// <summary>
        /// ファイルパスを引数に取り、指定されたファイル中のテキストを1行ずつ読み取り、設定された処理を行います。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        public void Run(string vFilePath) {
            FService.Initialize(vFilePath);
            using (var wReader = new StreamReader(vFilePath)) {
                while (!wReader.EndOfStream) {
                    string wLine = wReader.ReadLine();
                    FService.Execute(wLine);
                }
            }
            FService.Terminate();
        }
    }
}
