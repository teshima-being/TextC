using System.Data.Entity.Migrations;

namespace Practice13.Models {

    /// <summary>
    /// 自動マイグレーションクラス
    /// </summary>
    internal class Configuration : DbMigrationsConfiguration<BooksDbContext> {

        /// <summary>
        /// 自動マイグレーションクラスのコンストラクタ
        /// </summary>
        public Configuration() {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "Practice13.Models.BooksDbContext";
        }
    }
}
