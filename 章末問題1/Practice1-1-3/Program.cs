using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1_3 {
    internal class Program {
        static void Main(string[] args) {

            //問題1-3-2
            //Studentクラスのインスタンスを生成するコードを書いてください。
            //このとき、すべてのプロパティに値を設定してください。

            Student wStudent = new Student("三重花子", 3, 3, DateTime.Parse("1990/04/15"));


            //問題1-3-3
            //1-3-2で生成したインスタンスの各プロパティの値をコンソールに出力するコードを書いてください。

            Console.WriteLine(wStudent.Name);   //Console.WriteLineで列挙
            Console.WriteLine(wStudent.Grade);
            Console.WriteLine(wStudent.ClassNumber);
            Console.WriteLine(wStudent.Birthday.ToString("yyyy/mm/dd"));

            Dictionary<string, string> prop = new Dictionary<string, string> ();　//Dictionary練習
            prop.Add("名前", wStudent.Name);
            prop.Add("学年", wStudent.Grade.ToString());
            prop.Add("組", wStudent.ClassNumber.ToString());
            prop.Add("誕生日", wStudent.Birthday.ToString("yyyy/MM/dd"));

            foreach (string p in prop.Keys) {
                Console.WriteLine($"{p}は{prop[p]}です。");
            }

            //問題1-3-4
            //1-3-2で生成したインスタンスをPerson型およびobject型の変数に代入できることを確認してください。
            Person wPerson = wStudent;
            Console.WriteLine($"{wPerson.Name}さんの誕生日は{wPerson.Birthday.ToString("yyyy/MM/dd")}です");
            Object wObject = new Student("", 1, 2, new DateTime(2000, 4, 15));
            
            //extra
            //1-3-2で作成したインスタンスを使って、三重花子さんの年齢を求めてコンソールに表示する。
            Console.WriteLine($"{wStudent.Name}さんの現在の年齢は{wStudent.GetAge()}歳です。");
        }
    }
}
