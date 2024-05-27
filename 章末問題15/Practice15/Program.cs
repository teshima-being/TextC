using System;
using System.Linq;

namespace Practice15 {
    internal class Program {
        static void Main(string[] args) {

            var wBooksData = Library.Books;
            if (wBooksData == null) {
                Console.WriteLine("書籍データが存在しません。");
                return;
            }

            var wCategoriesData = Library.Categories;
            if (wCategoriesData == null) {
                Console.WriteLine("カテゴリデータが存在しません。");
                return;
            }

            //問題15-1
            //Libraryクラスにコンストラクタを追加し、本章の最初に示した書籍のカテゴリデータと
            //書籍データの値を、CategoriesプロパティとBooksプロパティにセットするコードを
            //書いてください。

            Console.WriteLine("****************************問題15-1****************************");

            //Libraryクラスに記述済。以下でコンソールに表示し確認。
            foreach (Book wBook in wBooksData) {
                Console.WriteLine(wBook);
            }

            //問題15-2
            //最も価格の高い書籍を抽出し、その書籍の情報をコンソールに出力してください。

            Console.WriteLine("****************************問題15-2****************************");

            var wMaxPrice = wBooksData.Max(x => x.Price);
            foreach (Book wBook in wBooksData.Where(x => x.Price == wMaxPrice)) {
                Console.WriteLine(wBook);
            }

            //問題15-3
            //発行年ごとに書籍の数をカウントして、その結果をコンソールに出力してください。

            Console.WriteLine("****************************問題15-3****************************");

            var wPublishedYearGroups = wBooksData.GroupBy(x => x.PublishedYear).OrderBy(x => x.Key);
            foreach (IGrouping<int, Book> wGroup in wPublishedYearGroups) {
                Console.WriteLine($"データ内の書籍のうち{wGroup.Key}年に発行された書籍は{wGroup.Count()}冊です。");
            }

            //問題15-4
            //発行年、価格の順（それぞれ値の大きい順）に並べ替え、その結果をコンソールに出力してください。

            Console.WriteLine("****************************問題15-4****************************");

            foreach (Book wBook in wBooksData.OrderByDescending(x => x.PublishedYear).ThenByDescending(x => x.Price)) {
                Console.WriteLine(wBook);
            }

            //問題15-5
            //2016年に発行された書籍のカテゴリ一覧を取得し、コンソールに出力してください。

            Console.WriteLine("****************************問題15-5****************************");

            var wPublished2016YearBooks = wBooksData.Where(x => x.PublishedYear == 2016);

            if (wPublished2016YearBooks == null) {
                Console.WriteLine("2016年に出版された書籍はありません。");
            } else {
                var wBooks = wPublished2016YearBooks.Join(wCategoriesData, x => x.CategoryId, y => y.Id, (x, y) => new {
                    Title = x.Title,
                    Category = y.Name,
                });
                foreach (var wBook in wBooks) {
                    Console.WriteLine($"タイトル：{wBook.Title}, カテゴリ名：{wBook.Category}");
                }
            }

            //問題15-6
            //GroupByメソッドを使い、カテゴリごとに書籍を分類し、カテゴリ名をアルファベット順に並び替え、
            //その結果をコンソールに出力してください。

            Console.WriteLine("****************************問題15-6****************************");

            var wCategoryGroups = wBooksData.Join(wCategoriesData, x => x.CategoryId, y => y.Id, (x, y) => new {
                Title = x.Title,
                Category = y.Name,
            }).GroupBy(x => x.Category).OrderBy(x => x.Key);

            foreach (var wGroup in wCategoryGroups) {
                Console.WriteLine($"{wGroup.Key}");
                foreach (var wBook in wGroup) {
                    Console.WriteLine($"タイトル：{wBook.Title}");
                }
            }

            //問題15-7
            //カテゴリ"Development"の書籍に対して、発行年ごとに分類し、その結果をコンソールに出力してください。

            Console.WriteLine("****************************問題15-7****************************");

            Category wCategoryData = wCategoriesData.SingleOrDefault(x => x.Name == "Development");

            if (wCategoryData == null) {
                Console.WriteLine("カテゴリ名がデータに存在しません。カテゴリ名を確認してください。");
            } else {
                var wGroups = wBooksData.Where(x => x.CategoryId == wCategoryData.Id)
                                        .GroupBy(x => x.PublishedYear).OrderBy(x => x.Key);

                foreach (IGrouping<int, Book> wGroup in wGroups) {
                    Console.WriteLine($"{wGroup.Key}年発行");
                    foreach (Book wBook in wGroup) {
                        Console.WriteLine(wBook);
                    }
                }
            }

            //問題15-8
            //GroupJoinメソッドを使って、4冊以上発行されているカテゴリ名を求め、そのカテゴリ名をコンソールに
            //出力してください。

            Console.WriteLine("****************************問題15-8****************************");

            var wBookGroups = wCategoriesData.GroupJoin(wBooksData, x => x.Id, y => y.CategoryId, (x, z) => new {
                CategoryName = x.Name,
                Books = z,
            });

            foreach (var wCategory in wBookGroups.Where(x => x.Books.Count() >= 4)) {
                Console.WriteLine(wCategory.CategoryName);
            }
        }
    }
}