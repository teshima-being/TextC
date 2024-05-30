using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice16_1 {

    /// <summary>
    /// WindowsFormsクラス
    /// </summary>
    public partial class FFormDisplayText : Form {

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FFormDisplayText() {
            InitializeComponent();
        }

        /// <summary>
        /// ファイル検索ボタンがクリックされた際に、ファイルダイアログを開き、ユーザーに選択された
        /// テキストファイルのパスをテキストボックスに表示します。
        /// </summary>
        /// <param name="sender">ファイル検索ボタン</param>
        /// <param name="e">クリック</param>
        private void FButtonSearchFile_Click(object sender, EventArgs e) {

            //結果表示用のテキストボックスの値をリセット
            FTextBoxResult.Text = string.Empty;

            var wFileDialog = new OpenFileDialog();
            wFileDialog.Title = "ファイル選択";
            wFileDialog.InitialDirectory = @"C:\Users";
            wFileDialog.Filter = "Text files(*.txt) | *.txt";

            if (wFileDialog.ShowDialog() == DialogResult.OK) {
                FTextBoxFilePath.Text = wFileDialog.FileName;
            }
        }

        /// <summary>
        /// テキスト表示ボタンがクリックされた際に、選択されたテキストファイルのテキスト全文を
        /// テキストボックスに表示します。
        /// </summary>
        /// <param name="sender">テキスト表示ボタン</param>
        /// <param name="e">クリック</param>
        private async void FButtonDisplayText_Click(object sender, EventArgs e) {

            if (FTextBoxFilePath.Text == string.Empty) {
                MessageBox.Show("ファイルが選択されていません。\nファイル選択ボタンから対象ファイルを選んでください。", "確認メッセージ");
                return;
            }
            await ShowText(FTextBoxFilePath.Text);
        }

        /// <summary>
        /// テキストファイルパスを引数に取り、当該テキストファイルのテキスト全文を非同期処理で取得し、
        /// テキストボックスに表示します。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        private async Task ShowText(string vFilePath) {

            var wStringBuilder = new StringBuilder();
            using (var wStreamReader = new StreamReader(vFilePath, Encoding.UTF8)) {
                while (!wStreamReader.EndOfStream) {
                    string wText = await wStreamReader.ReadLineAsync();
                    wStringBuilder.AppendLine(wText);
                }
            }
            FTextBoxResult.Text = wStringBuilder.ToString();
        }

        /// <summary>
        /// キャンセルボタンがクリックされたときにフォームを閉じます。
        /// </summary>
        /// <param name="sender">キャンセルボタン</param>
        /// <param name="e">クリック</param>
        private void FButtonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
