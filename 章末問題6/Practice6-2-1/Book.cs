using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice6_2_1 {

    /// <summary>
    /// タイトル、価格、ページ数の3つのプロパティを持つ書籍クラス
    /// </summary>
    public class Book {

        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// 価格
        /// </summary>
        public int Price { get; }

        /// <summary>
        /// ページ数
        /// </summary>
        public int Pages { get; }

        /// <summary>
        /// Bookクラスのコンストラクタ
        /// </summary>
        /// <param name="vTitle">タイトル</param>
        /// <param name="vPrice">価格</param>
        /// <param name="vPages">ページ数</param>
        public Book(string vTitle, int vPrice, int vPages) {
            this.Title = vTitle;
            this.Price = vPrice;
            this.Pages = vPages;
        }
        
        /// <summary>
        /// Bookオブジェクトのリストと検索文字列を受け取り、タイトルに検索文字列が含まれる
        /// Bookオブジェクトのリストを返します。
        /// </summary>
        /// <param name="vBooks">Bookオブジェクトのリスト</param>
        /// <param name="vKeyWord">検索文字</param>
        /// <returns>タイトルに検索文字が含まれるBookオブジェクトのリスト</returns>
        public static List<Book> SearchBooks(List<Book> vBooks, string vKeyWord) {

            var wBooks = new List<Book>();

            if (vBooks == null || vBooks.Count == 0) {
                Console.WriteLine("BooKオブジェクトが見つかりません。要素0のBookリストを返し、処理を終了します。");
                return wBooks;
            }
            
            wBooks = vBooks.Where(x => x.Title.Contains(vKeyWord)).ToList();
            return wBooks;
        }
    }
}
