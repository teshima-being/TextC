namespace Practice17_2 {

    /// <summary>
    /// インチ変換クラス
    /// </summary>
    public class InchConverter : ConverterBase {

        /// <summary>
        /// メートルとの比率
        /// </summary>
        protected override double Ratio { get { return 0.0254; } }

        /// <summary>
        /// 単位名
        /// </summary>
        public override string UnitName { get { return "インチ"; } }

        /// <summary>
        /// 単位名を引数に取り、それがインチであればtrue、それ以外の場合はfalseを返します。
        /// </summary>
        /// <param name="vName">単位名</param>
        /// <returns>bool値</returns>
        public override bool IsMyUnit(string vName) {
            return vName.ToLower() == "inch" || vName == this.UnitName;
        }
    }
}
