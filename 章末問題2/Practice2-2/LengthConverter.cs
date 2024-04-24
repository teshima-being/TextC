namespace Practice2_2 {

    /// <summary>
    /// インチとメートルの単位変換クラス
    /// </summary>
    internal class LengthConverter {

        /// <summary>
        /// インチ換算での長さをメートル換算での長さに変換します。
        /// </summary>
        /// <param name="vInchi">インチ換算での長さ</param>
        /// <returns>メートル換算での長さ</returns>
        public static float InchiToMeter(int vInchi) {
            return vInchi * 0.0254f;
        }
    }
}
