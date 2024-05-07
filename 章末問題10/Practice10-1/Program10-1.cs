using System;
using System.Text.RegularExpressions;

namespace Practice10_1 {
    internal class Program {

        //問題10-1
        //指定された文字列が携帯電話の電話番号かどうかを判定するメソッドを定義してください。
        //電話番号は必ずハイフン(-)で区切られていなければなりません。
        //また、先頭3文字は"070", "080", "090" のいずれかとします。

        static void Main(string[] args) {

            var wSampleTexts = new string[] {
                "090-1111-2222 ",
                "060-2222-3333",
                "080-3333-4444",
                "090-12k4-5678",
                "08-2345-6789",
                "070-9876-5432",
                "0595-65-7777",
                "番号は090-7777-6666",
                "080-1234-5678です",
                "090-3333-4444",
            };

            //確認用
            foreach (string wText in wSampleTexts) {
                if (IsPhoneNumber(wText)) {
                    Console.WriteLine(wText);
                }
            }
        }

        /// <summary>
        /// 文字列を引数に受け取り、文字列が携帯電話番号のときはtrue、そうではないときはfalseを返します。
        /// <param name="vText">文字列</param>
        /// <returns>bool値</returns>
        public static bool IsPhoneNumber(string vText) {
            return Regex.IsMatch(vText, @"^0[789]0-\d{4}-\d{4}$");
        }
    }
}
