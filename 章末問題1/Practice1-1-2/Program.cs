using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1_2 {
    internal class Program {

        //問題1-2-1
        //MyClassとMyStructの2つの型を引数にとるメソッドPrintObjectsを定義してください。
        //PrintObjectsメソッドでは、2つのオブジェクトの内容(プロパティの値)をコンソールに
        //表示するようにしてください。
        //なお、PrintObjectsメソッドは、Programクラスのメソッドとして定義してください。

        /// <summary>
        /// MyClassクラスとMyStruct構造体のメソッドをコンソールに表示する
        /// </summary>
        /// <param name="vMyClass">クラス</param>
        /// <param name="vMyStruct">構造体</param>
        static void PrintObjects(MyClass vMyClass, MyStruct vMyStruct) {
            Console.WriteLine($"(X, Y) = ({vMyClass.X}, {vMyClass.Y})");
            Console.WriteLine($"(X, Y) = ({vMyStruct.X}, {vMyStruct.Y})");

            vMyClass.X *= 2;
            vMyClass.Y *= 2;
            vMyStruct.X *= 2;
            vMyStruct.Y *= 2;
        }

        static void Main(string[] args) {

            //問題1-2-2
            //Mainメソッドで、PrintObjectsメソッドを呼び出すコードを書いてください。
            //MyClass、MyStructオブジェクトの値は、自由に決めて構いません。

            MyClass wMyClass = new MyClass { X = 1, Y = 2 };
            MyStruct wMyStruct = new MyStruct { X = 1, Y = 2 };
            PrintObjects(wMyClass, wMyStruct);

            //問題1-2-3
            //PrintObjectsメソッド内で、それぞれのプロパティの値を2倍に変更するコードを追加してください。
            //MainメソッドではPrintObjects呼び出しの後に、MyClass、MyStructオブジェクトのプロパティの値
            //をコンソールに表示するコードを加えてください。

            Console.WriteLine($"(X, Y) = ({wMyClass.X}, {wMyClass.Y})");
            Console.WriteLine($"(X, Y) = ({wMyStruct.X}, {wMyStruct.Y})");

            //問題1-2-4
            //上のコードを実行し、結果を確認してください。そして、どうしてそのような結果になったのか、
            //理由を説明してください。

                //結果
                //(X, Y) = (1, 2)　※クラス
                //(X, Y) = (1, 2)　※構造体
                //(X, Y) = (2, 4)　※クラス
                //(X, Y) = (1, 2)　※構造体

                //理由
                //MyClass(クラス)は参照型であるため、PrintObjectsメソッドで参照先の値が2倍されると呼び出し元の値も2倍される。
                //一方、MyStruct(構造体)は値型であるため、PrintObjectsメソッドで値を2倍にしても、呼び出し元は影響を受けない。
        }
    }
}
