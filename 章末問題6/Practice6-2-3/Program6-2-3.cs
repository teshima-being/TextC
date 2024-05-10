using System;
using System.Collections.Generic;
using System.Linq;
using Practice6_2_1;

namespace Practice6_2_3 {
    internal class Program {

        //問題6-2-3
        //問題用Listの中で、タイトルに"C#"が含まれている書籍の平均ページ数を求める
        //コードを書いてください

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

            double wAveragePages = Book.SearchBooks(wBooks, wUserInput).Average(x => x.Pages);
            Console.WriteLine($"タイトルに{wUserInput}を含む書籍の平均ページ数は" +
               　　　　　　　 $"{Math.Ceiling(wAveragePages)}頁です。\n※小数点以下切り上げ");
        }
    }
}
