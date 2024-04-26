using System;
using Practice7_2_1;

namespace Practice7_2_2 {
    internal class Program {

        //問題7-2-2
        //略語を引数に受け取るRemoveメソッドをAbbreviationsクラスに追加してください。
        //要素が見つからない場合はfalseを、削除できた場合はtrueを返してください。

        static void Main(string[] args) {

            //Romoveメソッドの確認
            var wOrganizations = new Abbreviations();

            string wFirstResult = wOrganizations["ASEAN"] ?? "存在しません。";
            Console.WriteLine(wFirstResult);

            Console.WriteLine(wOrganizations.Remove("ASEAN"));

            string wSecondResult = wOrganizations["ASEAN"] ?? "存在しません";
            Console.WriteLine(wSecondResult);

            Console.WriteLine(wOrganizations.Remove("NAINAI"));
        }
    }
}
