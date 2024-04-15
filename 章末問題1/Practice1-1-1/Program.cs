using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;

namespace Practice1_1_1 {
    class Program {
        static void Main(string[] args) {

            //問題1-1-1
            //Productクラスを使い、どら焼きオブジェクトを生成するコードを書いてください。
            //このときの商品番号は"98"、商品価格は"210円"としてください。

            Product wDorayaki = new Product(98, "どら焼き", 210);

            //問題1-1-2
            //どら焼きオブジェクトの消費税額を求め、コンソールに出力するコードを書いてください。

            Console.WriteLine(wDorayaki.GetTax(wDorayaki.Price));

            //問題1-1-3
            //Productクラスが属する名前空間を別の名前空間に変更し、Mainメソッドから呼び出すようにしてください。
            //ただし、MainメソッドのあるProgramクラスの名前空間はそのままとしてください。

            //usingディレクティブを追加しました。
        }
    }
}
