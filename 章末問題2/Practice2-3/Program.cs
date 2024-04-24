using System;
using System.Collections.Generic;

namespace Practice2_3 {
    internal class Program {

        //問題2-3
        //「2.2：売り上げ集計プログラム」で作成したプログラム(※)を変更し、
        //商品カテゴリ別の売上高を求めるプログラムを作成してください。
        //※「sale.txt」を読み取り、店舗別の売上高をコンソールに出力するプログラム

        static void Main(string[] args) {
            var wSales = new SalesCounter(@"..\..\sales.txt");
            IDictionary<string, int> wAmountPerStores = wSales.GetPerStoreSales();
            foreach (KeyValuePair<string, int> wKeyPair in wAmountPerStores) {
                Console.WriteLine($"{wKeyPair.Key}の売り上げは{wKeyPair.Value:0,000,000}円です");
            }
        }
    }
}
