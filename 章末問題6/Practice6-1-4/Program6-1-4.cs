using System;
using System.Windows.Forms;

namespace Practice6_1_4 {
    internal static class Program {

        //問題6-1-4
        //問題用配列を数の小さい順に並べ、先頭から3つを取り出し、結果を表示してください。
        //※気分転換も含めてWindowsフォームアプリケーションとして作成しています。

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}