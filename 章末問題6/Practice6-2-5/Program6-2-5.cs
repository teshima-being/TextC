using System;
using System.Collections.Generic;
using System.Linq;
using Practice6_2_1;

namespace Practice6_2_5 {
    internal class Program {

        //問題6-2-5
        //問題用Listについて、価格が4000円未満の本の中で最大のページ数を求めるコードを
        //書いてください。

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

            IEnumerable<Book> wUnderPriceBooks = wBooks.Where(x => x.Price < 4000);

            if (wUnderPriceBooks.Count() == 0) {
                Console.WriteLine("条件に合致する書籍はリストにはありませんでした。");
                return;
            }
            Console.WriteLine($"条件を満たす書籍の中で最大となるページ数は{wUnderPriceBooks.Max(x => x.Pages)}頁です。");
        }
    }
}
