using System;
using System.Collections.Generic;
using System.Linq;
using Practice6_2_1;

namespace Practice6_2_6 {
    internal class Program {

        //問題6-2-6
        //問題用Listの中で、ページ数が400ページ以上の書籍を、価格の高い順に
        //表示(タイトルと価格を表示)するコードを書いてください。

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

            IEnumerable<Book> wOverPagesBooks = wBooks.Where(x => x.Pages >= 400);
            var wSortedBooks = wOverPagesBooks.OrderByDescending(x => x.Price);

            foreach (Book wBook in wSortedBooks) {
                Console.WriteLine($"タイトル：{wBook.Title}, 価格：{wBook.Price}");
            }
        }
    }
}
