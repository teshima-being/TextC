using Practice13.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice13 {
    internal class Program {
        static void Main(string[] args) {

            //問題13-1
            //以下の2名の著者と4冊の書籍をデータに追加してください。

            /*
            《著者》
             菊池寛　　1888年12月26日生まれ　　男性
             川端康成　1899年 6月14日生まれ　　男性

            《書籍》
             こころ　　　　　　1991年出版　　夏目漱石 著
             伊豆の踊子　　　2003年出版　　川端康成 著
             真珠婦人　　　　　2002年出版　　菊池寛　 著
             注文の多い料理店　2000年出版　　宮沢賢治 著
            */

            var wAuthors = new Author[] {
                new Author("菊池寛", new DateTime(1888, 12, 26), "M"),
                new Author("川端康成", new DateTime(1899, 6, 14), "M"),
            };
            AddAuthors(wAuthors);

            var wBooks = new Book[] {
                new Book("こころ", 1991, new Author("夏目漱石", new DateTime(1867, 2, 9), "M")),
                new Book("伊豆の踊子", 2003, new Author("川端康成", new DateTime(1899, 6, 14), "M")),
                new Book("真珠夫人", 2002, new Author("菊池寛", new DateTime(1888, 12, 26), "M")),
                new Book("注文の多い料理店", 2000, new Author("宮沢賢治", new DateTime(1896, 8, 27), "M")),
            };
            AddBooks(wBooks);


            //問題13-2
            //すべての書籍情報を著者名とともに表示するコードを書き、上記で追加したデータが正しく追加されたか
            //確認してください。

            DisplayAllBooks();
            Console.WriteLine("*****************************************************"); //仕切り


            //問題13-3
            //タイトルが最も長い書籍を求めてください。複数ある場合は、すべてを求めて表示してください。

            using (var wDB = new BooksDbContext()) {
                Console.WriteLine("タイトルが最も長い書籍は以下となります。");
                foreach (Book wBook in wDB.Books.Where(x => x.Title.Length == wDB.Books.Max(y => y.Title.Length))) {
                    Console.WriteLine($"{wBook.Title} ({wBook.Author.Name} 著)");
                }
            }
            Console.WriteLine("*****************************************************"); //仕切り


            //問題13-4
            //出版年の古い順に3冊だけ書籍を取得し、そのタイトルと著者名を求めてください。

            using (var wDB = new BooksDbContext()) {
                Console.WriteLine("出版年が古い順に3冊だけ抽出した結果は以下の通りです。");
                foreach (Book wBook in wDB.Books.OrderBy(x => x.PublishedYear).Take(3)) {
                    Console.WriteLine($"{wBook.Title} ({wBook.Author.Name} 著) {wBook.PublishedYear}年出版");
                }
            }
            Console.WriteLine("*****************************************************"); //仕切り


            //問題13-5
            //著者ごとに書籍のタイトルと出版年を表示してください。なお、著者は誕生日の遅い順に並べてください。

            using (var wDB = new BooksDbContext()) {
                foreach (IGrouping<Author, Book> wGroup in wDB.Books.GroupBy(x => x.Author).OrderBy(x => x.Key.Birthday)) {
                    Console.WriteLine($"<{wGroup.Key.Name} ({wGroup.Key.Birthday:d})>");

                    foreach (Book wBook in wGroup) {
                        Console.WriteLine($"・{wBook.Title} ({wBook.PublishedYear}年出版)");
                    }
                }
            }
        }

        /// <summary>
        /// 全ての書籍のデータをコンソールに表示します
        /// </summary>
        static void DisplayAllBooks() {
            using (var wDB = new BooksDbContext()) {
                foreach (Book wBook in wDB.Books) {
                    Console.WriteLine($"{wBook.Title}, {wBook.PublishedYear}年出版, {wBook.Author.Name} 著");
                }
            }
        }

        /// <summary>
        /// 著者クラスのコレクションを引数に取り、データベースに著者データのみ追加します
        /// </summary>
        /// <param name="vAuthors">著者クラスのコレクション</param>
        static void AddAuthors(IEnumerable<Author> vAuthors) {
            using (var wDB = new BooksDbContext()) {
                foreach (Author wAuthor in vAuthors) {
                    wDB.Authors.Add(wAuthor);
                }
                wDB.SaveChanges();
            }
        }

        /// <summary>
        /// 書籍クラスのコレクションを引数に取り、データベースに書籍データのみ追加します
        /// </summary>
        /// <param name="vBooks">書籍クラスのコレクション</param>
        static void AddBooks(IEnumerable<Book> vBooks) {
            using (var wDB = new BooksDbContext()) {
                foreach (Book wBook in vBooks) {
                    Author wAuthor = wDB.Authors.FirstOrDefault(x => x.Name == wBook.Author.Name);
                    if (wAuthor == null) {
                        Console.WriteLine($"{wBook.Title}は著者情報の登録がありません。著者情報を登録してください。");
                        continue;
                    }
                    wBook.Author = wAuthor;
                    wDB.Books.Add(wBook);
                }
                wDB.SaveChanges();
            }
        }
    }
}
