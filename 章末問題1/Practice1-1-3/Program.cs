using System;
using System.Collections.Generic;

namespace Practice1_1_3 {
    internal class Program {
        static void Main(string[] args) {

            //問題1-3-2
            //Studentクラスのインスタンスを生成するコードを書いてください。
            //このとき、すべてのプロパティに値を設定してください。

            var wStudent = new Student("三重花子", 3, 3, DateTime.Parse("1990/04/15"));


            //問題1-3-3
            //1-3-2で生成したインスタンスの各プロパティの値をコンソールに出力するコードを書いてください。

            Console.WriteLine(wStudent.Name);   //Console.WriteLineで列挙
            Console.WriteLine(wStudent.Grade);
            Console.WriteLine(wStudent.ClassNumber);
            Console.WriteLine(wStudent.Birthday.ToString("yyyy/MM/dd"));

            var wProperties= new Dictionary<string, string> ();　//Dictionary練習
            wProperties.Add("名前", wStudent.Name);
            wProperties.Add("学年", wStudent.Grade.ToString());
            wProperties.Add("組", wStudent.ClassNumber.ToString());
            wProperties.Add("誕生日", wStudent.Birthday.ToString("yyyy/MM/dd"));

            foreach (string wProperty in wProperties.Keys) {
                Console.WriteLine($"{wProperty}は{wProperties[wProperty]}です。");
            }

            //問題1-3-4
            //1-3-2で生成したインスタンスをPerson型およびobject型の変数に代入できることを確認してください。
            Person wPerson = wStudent;
            Console.WriteLine($"{wPerson.Name}さんの誕生日は{wPerson.Birthday.ToString("yyyy/MM/dd")}です");
            object wObject = new Student("三重花子", 1, 2, new DateTime(2000, 4, 15));
            
            //extra
            //1-3-2で作成したインスタンスを使って、三重花子さんの年齢を求めてコンソールに表示する。
            Console.WriteLine($"{wStudent.Name}さんの現在の年齢は{wStudent.GetAge()}歳です。");
        }
    }
}
