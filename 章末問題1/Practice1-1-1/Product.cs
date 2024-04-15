using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice {
    class Product {
        //商品コード
        public int Code { get; set; }
        //商品名
        public string Name { get; set; }
        //商品価格(税抜き)
        public int Price { get; set; }

        //コンストラクタ
        public Product(int vCode, string vName, int vPrice) {
            this.Code = vCode;
            this.Name = vName;
            this.Price = vPrice;
        }

        /// <summary>
        /// 商品の税抜き価格から消費税額を求める
        /// </summary>
        /// <param name="vPrice">商品の税抜き価格</param>
        /// <returns>消費税額(税率0.10)</returns>
        public int GetTax(int vPrice) {
            return (int)(vPrice * 0.10);
        }
    }
}
