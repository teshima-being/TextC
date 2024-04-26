using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice5_4 {
    internal class Program {

        //問題5-4
        //"Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886"という文字列から以下の出力を得る
        //コンソールアプリケーションを作成してください。
        //作家　: 谷崎潤一郎
        //代表作: 春琴抄
        //誕生年: 1886

        static void Main(string[] args) {

            //問題用文字列
            string wText = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            Dictionary<string, string> wArtistInfomationsDic = GetArtistInfo(wText);
            
            Console.WriteLine($"作家　: {wArtistInfomationsDic["Novelist"]}");
            Console.WriteLine($"代表作: {wArtistInfomationsDic["BestWork"]}");
            Console.WriteLine($"誕生年: {wArtistInfomationsDic["Born"]}");


            //データ項目が増えたときにConsole.WriteLineが増えていくのは嫌だったので、繰り返しで
            //何とかできないかと考えましたが、いまいちしっくり来ていません…。
            var wKeyWords = new string[] { "Novelist=作家　", "BestWork=代表作", "Born=誕生年" };
            foreach (string wKeyWord in wKeyWords) {
                string[] wKeyPair = wKeyWord.Split('=');
                Console.WriteLine($"{wKeyPair[1]}: {wArtistInfomationsDic[wKeyPair[0]]}");
            }
        }

        /// <summary>
        /// 作家情報を記載した文字列を受け取り、データを各項目ことに分類したDictionary型を返します。
        /// </summary>
        /// <param name="vTarget">作家情報を記載した文字列</param>
        /// <returns>項目名をキーにして作家情報を呼び出すDictionary</returns>
        public static Dictionary<string, string> GetArtistInfo(string vTarget) {
            string[] wInfomations = vTarget.Split(';');

            return wInfomations.ToDictionary(x => x.Split('=')[0], x => x.Split('=')[1]);         
        }
    }
}
