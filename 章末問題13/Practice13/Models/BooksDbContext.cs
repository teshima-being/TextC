using System.Data.Entity;

namespace Practice13.Models {

    /// <summary>
    /// データモデル設定クラス
    /// </summary>
    public class BooksDbContext : DbContext {

        /// <summary>
        /// データモデル設定クラスのコンストラクタ
        /// </summary>
        public BooksDbContext() : base("name=BooksDbContext") {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BooksDbContext, Configuration>());
        }

        /// <summary>
        /// 書籍データ
        /// </summary>
        public DbSet<Book> Books { get; set; }

        /// <summary>
        /// 著者データ
        /// </summary>
        public DbSet<Author> Authors { get; set; }
    }
}