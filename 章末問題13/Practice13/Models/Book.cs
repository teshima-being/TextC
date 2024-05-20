namespace Practice13.Models {

    /// <summary>
    /// Bookクラス
    /// </summary>
    public class Book {

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; private set;}

        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; private set;}

        /// <summary>
        /// 出版年
        /// </summary>
        public int PublishedYear { get; private set; }

        /// <summary>
        /// 著者 
        /// </summary>
        public virtual Author Author { get; set; }

        /// <summary>
        /// 書籍クラスのコンストラクタ
        /// </summary>
        /// <param name="vTitle">タイトル</param>
        /// <param name="vPublishedYear">出版年</param>
        /// <param name="vAuthor">著者</param>
        public Book(string vTitle, int vPublishedYear, Author vAuthor) {
            this.Title = vTitle;
            this.PublishedYear = vPublishedYear;
            this.Author = vAuthor;
        }

        /// <summary>
        /// 引数なしの書籍クラスのコンストラクタ
        /// </summary>
        public Book() { }
    }
}
