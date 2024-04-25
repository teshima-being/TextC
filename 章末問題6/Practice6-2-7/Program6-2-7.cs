using Practice6_2_1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice6_2_7 {
    internal class Program {

        //問題6-2-7
        //問題用Listの中で、タイトルに"C#"が含まれていて、かつ500ページ以下の本を見つけ、
        //本のタイトルを表示するコードを書いてください。複数見つかった場合は、全て表示してください。

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

            IEnumerable<Book> wFilteredBooks = Book.SearchBooks(wBooks, "C#").Where(x => x.Pages <= 500);
            foreach (Book wBook in wFilteredBooks) {
                Console.WriteLine(wBook.Title);
            }
        }
    }
}
