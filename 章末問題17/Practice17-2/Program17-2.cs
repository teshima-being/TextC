using Microsoft.VisualBasic;
using System;

namespace Practice17_2 {
    internal class Program {

        //問題17-2
        //本書で示した距離換算プログラムに昨日を追加し、マイルとキロメートルも扱えるようにしてください。

        static void Main(string[] args) {

            while (true) {
                var wFrom = GetConverter("Step1：変換元の単位を入力してください。");
                var wTo = GetConverter("Step2：変換先の単位を入力してください。");
                var wDistance = GetDistance(wFrom);

                var wConverter = new DistanceConverter (wFrom, wTo);
                var wResult = wConverter.Convert(wDistance);
                Console.WriteLine($"結果：{wDistance}{wFrom.UnitName}は{wResult:0.000}{wTo.UnitName}です。");
            }
        }

        /// <summary>
        /// 文字列を引数に取り、その文字列をコンソールに表示します。また、ユーザーからの入力値をもとに
        /// 該当する単位変換クラスのインスタンスを返します。
        /// </summary>
        /// <param name="vMessage">文字列</param>
        /// <returns>単位変換クラスのインスタンス</returns>
        static ConverterBase GetConverter(string vMessage) {

            ConverterBase wConverter = null;
            while (wConverter == null) {
                Console.Write($"{vMessage}⇒  ");
                var wUnit = Console.ReadLine();
                wConverter = ConverterFactory.GetInstance(wUnit);
                if (wConverter == null) {
                    Console.WriteLine("入力された単位は指定できません。単位を確認してください。");
                }
            }
            return wConverter;
        }

        /// <summary>
        /// 単位変換クラスを引数に取り、ユーザー入力値をもとに、その単位で換算した距離を返します。
        /// </summary>
        /// <param name="vFrom">単位変換クラス</param>
        /// <returns>指定した単位で換算した距離</returns>
        static double GetDistance(ConverterBase vFrom) {

            double wValue = 0;
            while (wValue == 0) {
                Console.Write($"Step3：変換したい距離(単位：{vFrom.UnitName}、0は指定不可)を入力してください。⇒  ");

                //全角文字を半角文字に変換したのち数値かどうかチェックをする(全角数字入力でも可とするため)
                if (!double.TryParse(Strings.StrConv(Console.ReadLine(), VbStrConv.Narrow), out wValue)) {
                    Console.WriteLine("入力値が指定可能範囲外です。");
                }
            }
            return wValue;
        }
    }
}
