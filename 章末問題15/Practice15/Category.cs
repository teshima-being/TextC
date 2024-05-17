namespace Practice15 {

    /// <summary>
    /// カテゴリクラス
    /// </summary>
    internal class Category {

        /// <summary>
        /// カテゴリID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// カテゴリ名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// カテゴリクラスのコンストラクタ
        /// </summary>
        /// <param name="vId"></param>
        /// <param name="vName"></param>
        public Category(int vId, string vName) {
            this.Id = vId;
            this.Name = vName;
        }

        /// <summary>
        /// 結果の確認を容易にするためにToStringメソッドをオーバーライドしています。
        /// </summary>
        /// <returns>カテゴリクラスのプロパティが確認できる文字列</returns>
        public override string ToString() {
            return $"Id:{this.Id}, カテゴリ名:{this.Name}";
        }
    }
}
