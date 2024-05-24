using System.Security.Cryptography.X509Certificates;

namespace Practice17_2 {

    /// <summary>
    /// メートル変換クラス
    /// </summary>
    public class MeterConverter : ConverterBase {

        /// <summary>
        /// メートルとの比率
        /// </summary>
        protected override double Ratio { get { return 1; } }

        /// <summary>
        /// 単位名
        /// </summary>
        public override string UnitName { get { return "メートル"; } }

        /// <summary>
        /// 単位名を引数に取り、それがメートルであればtrue、それ以外の場合はfalseを返します。
        /// </summary>
        /// <param name="vName">単位名</param>
        /// <returns>bool値</returns>
        public override bool IsMyUnit(string vName) {
            return vName.ToLower() == "meter" || vName == this.UnitName;
        }
    }
}
