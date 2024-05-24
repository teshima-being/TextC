namespace Practice17_2 {

    /// <summary>
    /// 距離変換クラス
    /// </summary>
    public class DistanceConverter {

        /// <summary>
        /// 単位変換元
        /// </summary>
        public ConverterBase From { get; }

        /// <summary>
        /// 単位変換先
        /// </summary>
        public ConverterBase To { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vFrom">単位変換元</param>
        /// <param name="vTo">単位変換先</param>
        public DistanceConverter(ConverterBase vFrom, ConverterBase vTo) {
            this.From = vFrom;
            this.To = vTo;
        }

        /// <summary>
        /// 単位変換元換算での距離を単位変換先換算での距離に変換した結果を返します。
        /// </summary>
        /// <param name="vValue">単位変換元換算での距離</param>
        /// <returns>単位変換先換算での距離</returns>
        public double Convert(double vValue) {
            var wMeter = this.From.ToMeter(vValue);
            return this.To.FromMeter(wMeter);
        }
    }
}
