﻿using System;
using System.Text;

namespace Practice5_3_5 {
    internal class Program {

        //問題5-3-5
        //問題用文字列を空白で区切り、配列に格納した後、StringBuilderクラスを使い文字列を連結させ、
        //元の文字列と同じものを作り出してください。元の文字列の中には連続した空白は存在しないもの
        //とします。

        static void Main(string[] args) {

            //問題用文字列
            string wText = "jackdaws love my big sphinx of quartz";

            if (string.IsNullOrEmpty(wText)) {
                Console.WriteLine("問題用文字列がnullもしくは空文字であるため処理を中止します");
                return;
            }

            var wRemakedText = new StringBuilder();
            foreach (string wWord in wText.Split(' ')) {
                wRemakedText.Append(wWord + ' ');
            }

            //リメイク後のテキストと元のテキスト両方表示して確認
            Console.WriteLine(wRemakedText.Remove(wRemakedText.Length - 1, 1));
            Console.WriteLine(wText);
        }
    }
}
