namespace Practice4_2_3 {
    internal class Program {

        //問題4-2-3
        //4-2-1で作成した配列の中の、最初に見つかった21世紀のYearMonthオブジェクトを返すメソッドを
        //書いてください。見つからなかった場合はnullを返してください。foreach文を使って実装してください。

        static void Main(string[] args) {

            var wYearMonths = new YearMonth[] {
                new YearMonth(1940, 7),
                new YearMonth(1964, 10),
                new YearMonth(1972, 12),
                new YearMonth(1998, 1),
                new YearMonth(2020, 9),
            };
        }

        /// <summary>
        /// YearMonthオブジェクトの配列と受け取り、配列の中の最初に見つかった21世紀のYearMonthオブジェクトを返す。
        /// 見つからなかった場合はnullを返す。
        /// </summary>
        /// <param name="vYearMonths">YearMonthオブジェクトの配列</param>
        /// <returns>21世紀のYearMonthオブジェクト</returns>
        public static YearMonth Get21Century(YearMonth[] vYearMonths) {
            foreach (YearMonth wYearMonth in vYearMonths)
                if (wYearMonth.Is21Century) {
                    return wYearMonth;
                }
            return null;
        }
    }
}
