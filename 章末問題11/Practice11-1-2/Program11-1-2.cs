using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Practice11_1_2 {
    internal class Program {

        //問題11-1-2
        //最初にプレーされた年の若い順に漢字の競技名を表示してください。

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
            IEnumerable<XElement> wBallSports = wBallSportsData.Root.Elements().OrderBy(x => x.Element("firstplayed").Value);

            Console.WriteLine("誕生年で昇順に並び替えた結果は以下の通りです。");
            foreach (XElement wBallSport in wBallSports) {
                Console.WriteLine(wBallSport.Element("name").Attribute("kanji").Value);
            }
        }
    }
}
