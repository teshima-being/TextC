namespace Practice4_1_1 {

    /// <summary>
    /// 年(Year)と月(Month)の2つのプロパティを持つYearMonthクラス
    /// </summary>
    internal class YearMonth {

        private int Fmonth; //月を表すメンバ変数

        /// <summary>
        /// 年
        /// </summary>
        public int Year { get; private set; }

        /// <summary>
        /// 月
        /// 1～12の範囲の値が設定可能
        /// </summary>
        public int Month {
            get { return this.Fmonth; }
            set {
                if (1 <= value && value <= 12) {
                    this.Fmonth = value;
                }
            }
        }

        /// <summary>
        /// YearMonthクラスのコンストラクタ
        /// </summary>
        /// <param name="vYear">年</param>
        /// <param name="vMonth">月(1～12の範囲の値)</param>
        public YearMonth(int vYear, int vMonth) {
            this.Year = vYear;
            this.Month = vMonth;
        }
    }
}
