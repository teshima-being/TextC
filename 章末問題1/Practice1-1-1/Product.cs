namespace Practice {
    /// <summary>
    /// Productクラス
    /// </summary>
    class Product {
        /// <summary>
        /// 商品コード
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 商品名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 商品価格(税抜き)
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Productクラスのコンストラクタ
        /// </summary>
        /// <param name="vCode">商品コード</param>
        /// <param name="vName">商品名</param>
        /// <param name="vPrice">商品価格(税抜き)</param>
        public Product(int vCode, string vName, int vPrice) {
            this.Code = vCode;
            this.Name = vName;
            this.Price = vPrice;
        }

        /// <summary>
        /// 商品価格(税抜き)から消費税額を求める
        /// </summary>
        /// <param name="vPrice">商品価格(税抜き)</param>
        /// <returns>消費税額(税率0.10)</returns>
        public int GetTax(int vPrice) {
            return (int)(vPrice * 0.10);
        }
    }
}
