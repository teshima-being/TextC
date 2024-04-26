using System;

namespace Practice7_2_1 {
    internal class Program {

        //問題7-2-1
        //ディクショナリに登録されている用語の数を返すCountプロパティをAbbreviationsクラスに
        //追加してください。

        static void Main(string[] args) {

            //Countプロパティの確認
            var wOrganizations = new Abbreviations();
            Console.WriteLine(wOrganizations.Count);
        }
    }
}
