using System;
using System.Windows.Forms;

namespace Practice16_1 {
    internal static class Program {

        //問題16-1
        //StreamReaderクラスには、非同期処理を実現するReadLineAsyncメソッドが追加されています。
        //このメソッドを使い、テキストファイルを非同期で読み込むコードを書いてください。
        //アプリケーションの形態は、WindowsFormsでもWPFでも好きなものを選んでください。

        [STAThread]
        static void Main() {
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        
        /// <summary>
        /// 高DPI対応のための設定を呼び出します。
        /// </summary>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
