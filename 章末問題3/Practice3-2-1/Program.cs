using System;
using System.Collections.Generic;

namespace Practice3_2_1 {
    internal class Program {

        //問題3-2-1
        //問題用リストに対して、コンソールから入力した都市名が何番目に格納されているかを
        //List<T>のFindIndexメソッドを使って調べ、その結果をコンソールに出力してください。
        //なお、コンソールからの入力には、Console.ReadLineメソッドを利用してください。

        static void Main(string[] args) {

            //問題用リスト
            var wNames = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong"
            };
            
            //ShowIndexメソッド呼び出し
            ShowIndex(wNames);
        }

        /// <summary>
        /// 都市名リストを引数に受け取り、ユーザーのコンソールへの入力値がリストの何番目か調べ、
        /// その結果をコンソールに表示する。
        /// リストに存在しない値を入力すると処理を終了する。
        /// </summary>
        /// <param name="vCityNames">都市名リスト</param>
        public static void ShowIndex(List<string> vCityNames) {

            Console.WriteLine("都市名を入力してください。");

            while(true) {
                //コンソールに入力された値を変数wCityNameに格納
                string wCityName = Console.ReadLine();

                int wCityIndex = vCityNames.FindIndex(x => x == wCityName);

                if (wCityIndex == -1) {
                    Console.WriteLine($"{wCityName}はリストに存在しません。アプリケーションを終了します。");
                    return;
                }
                Console.WriteLine($"{wCityName}はリストの{wCityIndex + 1}番目にあります。");
            }
        }
    }
}
