using Microsoft.VisualBasic;
using System;
using System.Text;
using System.Text.RegularExpressions;
using TextFileProcessor;

namespace Practice17_1 {

    /// <summary>
    /// 数値変換(全角数字 → 半角数字)クラス
    /// </summary>
    internal class NumberConverter : TextProcessor {

        private StringBuilder FResultText = new StringBuilder();

        /// <summary>
        /// StringBuilderのテキストを初期化します。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        protected override void Initialize(string vFilePath) {
            FResultText.Clear();
        }

        /// <summary>
        /// 文字列を引数に取り、文字列中の全角数字を半角数字に置換したのち、StringBuilderに格納します。
        /// </summary>
        /// <param name="vLine">文字列</param>
        protected override void Execute(string vLine) {
            FResultText.AppendLine(Regex.Replace(vLine, "[０-９]+", x => Strings.StrConv(x.Value, VbStrConv.Narrow)));
        }

        /// <summary>
        /// 処理結果をコンソールに表示します。
        /// </summary>
        protected override void Terminate() {
            Console.WriteLine($"処理結果は以下の通りです。\n{FResultText}");
        }
    }
}
