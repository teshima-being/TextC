using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Practice6_1_4 {
    public partial class Form1 : Form {

        //問題用配列
        private readonly int[] FNumbers = { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

        public Form1() {
            InitializeComponent();

            //テキストラベルに問題用配列を表示
            this.ArrayLabel.Text = string.Join(",", FNumbers);
        }

        /// <summary>
        /// 昇順で抽出ボタンがクリックされたときに、配列を昇順で並び替え、InputTextBoxに入力された
        /// 数値分の要素を抽出します。
        /// </summary>
        /// <param name="sender">昇順で抽出ボタン</param>
        /// <param name="e">クリック</param>
        private void AscendingButton_Click(object sender, EventArgs e) {

            if (!JudgeUserInput()) return;

            ShowPickedUpNumbers(this.FNumbers, int.Parse(this.InputTextBox.Text), true);
        }

        /// <summary>
        /// 降順で抽出ボタンがクリックされたときに、配列を降順で並び替え、InputTextBoxに入力された
        /// 数値分の要素を抽出します。
        /// </summary>
        /// <param name="sender">降順で抽出ボタン</param>
        /// <param name="e">クリック</param>
        private void DescendingButton_Click(object sender, EventArgs e) {

            if (!JudgeUserInput()) return;

            ShowPickedUpNumbers(this.FNumbers, int.Parse(this.InputTextBox.Text), false);
        }

        /// <summary>
        /// ユーザーの入力数値が指定可能範囲内かどうか判定し、指定範囲可能な値で鵜ある場合はtrue、指定可能範囲外の場合は
        /// falseを返します。
        /// </summary>
        /// <returns></returns>
        public bool JudgeUserInput() {

            if (!int.TryParse(this.InputTextBox.Text, out int wItemsCount)) {
                MessageBox.Show("テキストボックスには整数値を入力してください");
                return false;
            }

            if (wItemsCount <= 0 || this.FNumbers.Length < wItemsCount) {
                MessageBox.Show("入力数値が指定可能範囲外です。");
                return false;
            }
            return true;
        }

        /// <summary>
        /// int型配列とユーザーの入力数値、昇順か降順かの判定を行うbool値を引数にとり、指定された方法で配列の要素を並び替えたのち、
        /// ユーザーが指定した個数文の要素を抽出してフォーム画面に表示します。
        /// </summary>
        /// <param name="vNumbers">int型配列</param>
        /// <param name="vItemsCount">InputTextBoxの入力値</param>
        /// <param name="vIsAscending">昇順の場合true、降順の場合falseを指定</param>
        public void ShowPickedUpNumbers(int[] vNumbers, int vItemsCount, bool vIsAscending) {

            IEnumerable<int> wPickedUpNumbers = null;

            if (vIsAscending) {
                 wPickedUpNumbers = vNumbers.OrderBy(x => x).Take(vItemsCount);              //昇順処理
            } else {
                 wPickedUpNumbers = vNumbers.OrderByDescending(x => x).Take(vItemsCount);    //降順処理
            }

            string wResult = string.Join(",", wPickedUpNumbers);
            this.ShowResultLabel.Text = $"抽出後の文字列は以下の通りです。\n{wResult}";
        }
    }
}
