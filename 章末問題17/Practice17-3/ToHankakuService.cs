using Microsoft.VisualBasic;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice17_3 {

    /// <summary>
    /// 数値変換(全角数字 → 半角数字)クラス
    /// </summary>
    internal class ToHankakuService : ITextFileService {

        private StringBuilder FResultText = new StringBuilder();

        /// <summary>
        /// StringBuilderの初期化を行います。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        public void Initialize(string vFilePath) {
            FResultText.Clear();
        }

        /// <summary>
        /// 文字列を引数に取り、文字列中の全角数字を半角数字に変換した文字列をStringBuilderに格納します。
        /// </summary>
        /// <param name="vLine"></param>
        public void Execute(string vLine) {
            FResultText.AppendLine(Regex.Replace(vLine, @"[０-９]+", x => Strings.StrConv(x.Value, VbStrConv.Narrow)));
        }

        /// <summary>
        /// 処理結果をコンソールに表示します。
        /// </summary>
        public void Terminate() {
            Console.WriteLine($"処理結果は以下の通りです。\n{FResultText}");
        }
    }
}
