using System.Collections.Generic;
using System.IO;

namespace Practice2_3 {

    /// <summary>
    /// 売上を集計するクラス
    /// </summary>
    internal class SalesCounter {
        private IEnumerable<Sale> FSales;

        /// <summary>
        /// SalesCounterクラスのコンストラクタ
        /// </summary>
        /// <param name="vFilePath">売上データファイルの相対パス</param>
        public SalesCounter(string vFilePath) {
            this.FSales = ReadSales(vFilePath);
        }

        /// <summary>
        /// 売上データを読み込みSaleオブジェクトのリストを返します。
        /// </summary>
        /// <param name="vFilePath">売上データファイルの相対パス</param>
        /// <returns>売上データのリスト</returns>
        private static IEnumerable<Sale> ReadSales(string vFilePath) {
            var wSales = new List<Sale>();
            string[] wLines = File.ReadAllLines(vFilePath);
            foreach (string wLine in wLines) {
                string[] wItems = wLine.Split(',');
                var wSale = new Sale {
                    ShopName = wItems[0],
                    ProductCategory = wItems[1],
                    Amount = int.Parse(wItems[2])
                };
                wSales.Add(wSale);
            }
            return wSales;
        }

        /// <summary>
        /// 店舗別の売り上げを求めて、Dictionary型変数に格納します。
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, int> GetPerStoreSales() {
            var wStoreSales = new Dictionary<string, int>();
            foreach (Sale wSale in this.FSales) {
               if (wStoreSales.ContainsKey(wSale.ProductCategory)) 
                    wStoreSales[wSale.ProductCategory] += wSale.Amount;
               else 
                    wStoreSales[wSale.ProductCategory] = wSale.Amount;
            }
            return wStoreSales;
        }
    }
}
