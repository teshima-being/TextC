namespace Practice17_2 {

    /// <summary>
    /// マイル変換クラス
    /// </summary>
    public class MileConverter : ConverterBase {

        /// <summary>
        /// メートルとの比率
        /// </summary>
        protected override double Ratio { get { return 1609.344; } }

        /// <summary>
        /// 単位名
        /// </summary>
        public override string UnitName { get { return "マイル"; } }

        /// <summary>
        /// 単位名を引数に取り、それがマイルであればtrue、それ以外の場合はfalseを返します。
        /// </summary>
        /// <param name="vName">単位名</param>
        /// <returns>bool値</returns>
        public override bool IsMyUnit(string vName) {
            return vName.ToLower() == "mile" || vName == this.UnitName;
        }
    }
}
