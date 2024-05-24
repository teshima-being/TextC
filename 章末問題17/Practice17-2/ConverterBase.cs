namespace Practice17_2 {

    /// <summary>
    /// 距離変換抽象クラス
    /// </summary>
    public abstract class ConverterBase {

        /// <summary>
        /// メートルとの比率(この比率を掛けるとメートルに換算できる)
        /// </summary>
        protected abstract double Ratio { get; }

        /// <summary>
        /// 距離の単位名(例えば"メートル"、"フィート"など)
        /// </summary>
        public abstract string UnitName { get; }

        /// <summary>
        /// 単位名を引数に取り、それが自身のクラスであればtrue、そうでなければfalseを返します。
        /// </summary>
        /// <param name="vName">単位名</param>
        /// <returns>bool値</returns>
        public abstract bool IsMyUnit(string vName);

        /// <summary>
        /// 距離単位をメートルから変換します
        /// </summary>
        /// <param name="vMeter">メートル単位の距離</param>
        /// <returns>単位変換後の距離</returns>
        public double FromMeter(double vMeter) {
            return vMeter / this.Ratio;
        }

        /// <summary>
        /// 距離単位をメートルに変換します
        /// </summary>
        /// <param name="vFeet">単位変換前の距離</param>
        /// <returns>メートル換算の距離</returns>
        public double ToMeter(double vFeet) {
            return vFeet * this.Ratio;
        }
    }
}
