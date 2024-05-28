using System.Linq;

namespace Practice17_2 {

    /// <summary>
    /// 単位変換クラスのインスタンス生成クラス
    /// </summary>
    public class ConverterFactory {

        /// <summary>
        /// 単位変換クラスのインスタンス
        /// </summary>
        private static ConverterBase[] FConverters = new ConverterBase[] {
            new MeterConverter(),
            new FeetConverter(),
            new YardConverter(),
            new InchConverter(),
            new MileConverter(),
            new KiloMeterConverter(),
        };

        /// <summary>
        /// 単位名を引数に取り、該当する単位変換クラスのインスタンスを返します。
        /// なお、単位名に該当する単位変換クラスが存在しなかった場合はnullを返します。
        /// </summary>
        /// <param name="vName">単位名</param>
        /// <returns>単位変換クラスのインスタンス</returns>
        public static ConverterBase GetInstance(string vName) {
            return FConverters.FirstOrDefault(x => x.IsMyUnit(vName));
        }
    }
}
