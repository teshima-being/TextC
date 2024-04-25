using System;
using System.Collections.Generic;

namespace Practice6_2_1 {
    internal class Program {

        //問題6-2-1
        //問題用Listの中で、タイトルが"ワンダフル・C#ライフ"である書籍の価格とページ数を
        //表示するコードを書いてください。

        static void Main(string[] args) {

            //問題用List
            var wBooks = new List<Book>() {
                new Book("C#プログラミングの新常識", 3800, 378),
                new Book("ラムダ式とLINQの極意", 2500, 312),
                new Book("ワンダフル・C#ライフ", 2900, 385),
                new Book("一人で学ぶ並列処理プログラミング", 4800, 464),
                new Book("フレーズで覚えるC#入門", 5300, 604),
                new Book("私でも分かったASP.NET MVC", 3200, 453),
                new Book("楽しいC#プログラミング教室", 2540, 348),
            };

            Console.WriteLine("検索文字列を入力してください。");
            string wUserInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(wUserInput)) {
                Console.WriteLine("検索文字列が未入力のため、検索できませんでした。");
                return;
            }

            var wBooksForUser = Book.SearchBooks(wBooks, wUserInput);

            if (wBooksForUser.Count == 0) {
                Console.WriteLine("該当する書籍はリストにありませんでした。");
                return;
            }

            Console.WriteLine("検索結果は以下の通りです。");

            foreach (Book wBook in wBooksForUser) {
                Console.WriteLine($"{wBook.Title}, {wBook.Price}円, {wBook.Pages}頁");
            }
        }
    }
}
