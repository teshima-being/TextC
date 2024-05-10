using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Practice11_1_3 {
    internal class Program {

        //問題11-1-3
        //メンバー人数が最も多い競技名を表示してください。

        static void Main(string[] args) {

            if (args.Length == 0) {
                Console.WriteLine("コマンドライン引数でXMLファイルのパスを指定してください。");
                return;
            }

            string wXFilePath = args[0];

            if (!File.Exists(wXFilePath)) {
                Console.WriteLine("指定したファイルが見つかりません。パスを確認してください。");
                return;
            }

            if (Path.GetExtension(wXFilePath) != ".xml") {
                Console.WriteLine("ファイルの拡張子が正しくありません。XMLファイルを指定してください。");
            }

            var wBallSportsData = XDocument.Load(wXFilePath);

            //匿名クラス
            var wBallSports = wBallSportsData.Root.Elements().Select(x => new {
                Name = (string)x.Element("name"),
                Teammembers = (int)x.Element("teammembers")
            });

            //メンバー人数が最も多い競技が複数あった場合、その全てを表示する
            int wMostPlayers = wBallSports.Max(x => x.Teammembers);

            Console.WriteLine($"メンバー人数の最大値は{wMostPlayers}人で、対象となる競技は以下の通りです。");
            foreach (var wBallSport in wBallSports.Where(x => x.Teammembers == wMostPlayers)) {
                Console.WriteLine(wBallSport.Name);
            }

        }
    }
}
