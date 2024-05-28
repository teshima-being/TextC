namespace Practice17_3 {

    /// <summary>
    /// テキスト処理インターフェース
    /// </summary>
    public interface ITextFileService {

        /// <summary>
        /// ファイルパスを引数に取り、設定された初期化処理を行います。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        void Initialize(string vFilePath);

        /// <summary>
        /// テキスト中の1行分の文字列を引数にとり、設定された処理を行います。
        /// </summary>
        /// <param name="wLine"></param>
        void Execute(string wLine);

        /// <summary>
        /// 設定された処理を最後に行います。
        /// </summary>
        void Terminate();
    }
}
