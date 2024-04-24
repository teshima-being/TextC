namespace Practice2_3 {

    /// <summary>
    /// 売上(店舗名・商品カテゴリ・売上高)を表すクラス
    /// </summary>
    internal class Sale {
        
        /// <summary>
        /// 店舗名
        /// </summary>
        public string ShopName { get; set; }
        
        /// <summary>
        /// 商品カテゴリ
        /// </summary>
        public string ProductCategory { get; set; }
        
        /// <summary>
        /// 売上高
        /// </summary>
        public int Amount { get; set; }
    }
}
