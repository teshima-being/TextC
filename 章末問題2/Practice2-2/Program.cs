using System;

namespace Practice2_2 {

    //問題2-2
    //インチからメートルへの変換表を1インチ刻みでコンソールに出力する
    //プログラムを書いてください。
    //このときのインチの範囲は、1インチから10インチまでとしてください。
    //1インチ ＝ 0.0254メートル

    internal class Program {
        static void Main(string[] args) {
            PrintInchiToMeterList(1, 10);
        }

        /// <summary>
        /// インチからメートルへの換算表を1インチ刻みでコンソールに出力します。
        /// </summary>
        /// <param name="vStart">換算を開始する値</param>
        /// <param name="vStop">換算を終了する値</param>
        static void PrintInchiToMeterList(int vStart, int vStop) {
            for (int wInchi = vStart; wInchi <= vStop; wInchi++) {
                Console.WriteLine
                    ($"{wInchi}インチ ＝ {LengthConverter.InchiToMeter(wInchi): 0.0000}メートル");
            }
        }
    }
}
