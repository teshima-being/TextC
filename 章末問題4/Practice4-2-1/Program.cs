namespace Practice4_2_1 {
    internal class Program {

        //問題4-2-1
        //作成したYearMonthクラスのオブジェクトを要素に持つ配列を定定義し、初期値として5つの
        //YearMonthオブジェクトをセットしてください。

        static void Main(string[] args) {
            var wYearMonths = new YearMonth[] {
                new YearMonth(1940, 7),
                new YearMonth(1964, 10),
                new YearMonth(1972, 12),
                new YearMonth(1998, 1),
                new YearMonth(2020, 9),
            };
        }
    }
}
