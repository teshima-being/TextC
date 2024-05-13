using System;
using Practice7_2_1;

namespace Practice7_2_3 {
    internal class Program {

        //問題7-2-3
        //CountプロパティとRemoveメソッドを利用するコードを書いてください。

        static void Main(string[] args) {

            var wOrganizations = new Abbreviations();

            //当初の要素の数を表示
            Console.WriteLine(wOrganizations.Count);

            //要素を追加
            wOrganizations.Add("KBS", "京都放送");
            wOrganizations.Add("MTV", "三重テレビ");

            //再度要素の数を表示
            Console.WriteLine(wOrganizations.Count);

            //要素を削除
            string wResult = wOrganizations.Remove("ASEAN")? "成功" : "失敗";
            Console.WriteLine($"削除に{wResult}しました");

            //再度要素の数を表示
            Console.WriteLine(wOrganizations.Count);

            //要素を削除
            wResult = wOrganizations.Remove("NNN") ? "成功" : "失敗";
            Console.WriteLine($"削除に{wResult}しました");

            //再度要素の数を表示
            Console.WriteLine(wOrganizations.Count);
        }
    }
}
