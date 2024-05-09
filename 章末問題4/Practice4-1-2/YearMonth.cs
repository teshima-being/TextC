namespace Practice4_1_2 {

    /// <summary>
    /// 年(Year)・月(Month)・21世紀か否か判定(Is21Century)の3つのプロパティを持つYearMonthクラス
    /// </summary>
    internal class YearMonth {

        private int Fmonth; //月を表すメンバ変数

        /// <summary>
        /// 年
        /// </summary>
        public int Year { get; private set; }

        /// <summary>
        /// 月
        /// 1～12の範囲の値の設定が可能
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
        /// 21世紀か否か判定
        /// 値の取得のみ可能
        /// </summary>
        public bool Is21Century => 2001 <= this.Year && this.Year <= 2100;

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
