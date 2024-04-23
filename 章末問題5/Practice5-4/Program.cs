using System;
using System.Collections.Generic;

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

            Dictionary<string, string> wArtistInfomations = GetArtistInfo(wText);
            
            Console.WriteLine($"作家　: {wArtistInfomations["Novelist"]}");
            Console.WriteLine($"代表作: {wArtistInfomations["BestWork"]}");
            Console.WriteLine($"誕生年: {wArtistInfomations["Born"]}");


            //データ項目が増えたときにConsole.WriteLineが増えていくのは嫌だったので、繰り返しで
            //何とかできないかと考えましたが、いまいちしっくり来ていません…。
            var wKeyWords = new string[] { "Novelist=作家　", "BestWork=代表作", "Born=誕生年" };
            foreach (string wKeyWord in wKeyWords) {
                string[] wKeyPair = wKeyWord.Split('=');
                Console.WriteLine($"{wKeyPair[1]}: {wArtistInfomations[wKeyPair[0]]}");
            }

        }

        public static Dictionary<string, string> GetArtistInfo(string vTarget) {
            string[] wInfomations = vTarget.Split(';');

            var wArtistInfomations = new Dictionary<string, string>();

            foreach (string wInfo in wInfomations) {
                string[] wInfoPair = wInfo.Split('=');
                wArtistInfomations.Add(wInfoPair[0], wInfoPair[1]);
            }
            return wArtistInfomations;
        }
    }
}
