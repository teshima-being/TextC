namespace Practice15 {

    /// <summary>
    /// 書籍クラス
    /// </summary>
    internal class Book {

        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// 価格
        /// </summary>
        public int Price { get; }

        /// <summary>
        /// カテゴリID
        /// </summary>
        public int CategoryId { get; }

        /// <summary>
        /// 発行年
        /// </summary>
        public int PublishedYear { get; }

        /// <summary>
        /// 書籍クラスのコンストラクタ
        /// </summary>
        /// <param name="vTitle">タイトル</param>
        /// <param name="vCategoryId">カテゴリID</param>
        /// <param name="vPrice">価格</param>
        /// <param name="vPublishedYear">発行年</param>
        public Book(string vTitle, int vCategoryId, int vPrice, int vPublishedYear) {
            this.Title = vTitle;
            this.CategoryId = vCategoryId;
            this.Price = vPrice;
            this.PublishedYear = vPublishedYear;
        }

        /// <summary>
        /// 結果の確認を容易にするためにToStrinメソッドをオーバーライドしています。
        /// </summary>
        /// <returns>書籍のプロパティが確認できる文字列</returns>
        public override string ToString() {
            return $"発行年:{this.PublishedYear}, カテゴリ:{this.CategoryId}, 価格:{this.Price}, タイトル:{this.Title}";
        }
    }
}
