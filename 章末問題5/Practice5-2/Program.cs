using System;

namespace Practice5_2 {
    internal class Program {

        //問題5-2
        //コンソールから入力した数字文字列をint型に変換した後、カンマ付きの数字文字列に
        //変換してください。入力した文字列は、int.TryParseメソッドで数値に変換してください。

        static void Main(string[] args) {
            Console.WriteLine("-2,147,483,648～-2,147,483,648の範囲の整数を入力してください。");

            while (true) {
                if (int.TryParse(Console.ReadLine(), out int wNumber)) {
                    Console.WriteLine(wNumber.ToString("#,0"));
                } 
                else {
                    Console.WriteLine("正常な数値が入力されていません。処理を終了します。");
                    break;
                }
            }
        }
    }
}
