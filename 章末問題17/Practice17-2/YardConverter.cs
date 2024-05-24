namespace Practice17_2 {

    /// <summary>
    /// ヤード変換クラス
    /// </summary>
    public class YardConverter : ConverterBase {

        /// <summary>
        /// メートルとの比率
        /// </summary>
        protected override double Ratio { get { return 0.9144; } }

        /// <summary>
        /// 単位名
        /// </summary>
        public override string UnitName { get { return "ヤード"; } }

        /// <summary>
        /// 単位名を引数に取り、それがヤードであればtrue、それ以外の場合はfalseを返します。
        /// </summary>
        /// <param name="vName">単位名</param>
        /// <returns>bool値</returns>
        public override bool IsMyUnit(string vName) {
            return vName.ToLower() == "yard" || vName == this.UnitName;
        }
    }
}
