using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Practice11_1_1 {
    internal class Program {

        //問題11-1-1
        //XMLファイルを読み込み、競技名とチームメンバー数の一覧を表示してください。

        static void Main(string[] args) {

            if (args.Length == 0) {
                Console.WriteLine("コマンドライン引数でXMLファイルのパスを指定してください。");
                return;
            }

            string wXFilePath = args[0];

            if(!IsXmlFile(wXFilePath)) return;

            var wBallSportsData = XDocument.Load(wXFilePath);
            IEnumerable<XElement> wBallSports = wBallSportsData.Root.Elements();

            foreach (XElement wBallSport in wBallSports) {
                XElement wSportName = wBallSport.Element("name");
                XElement wTeamMembers = wBallSport.Element("teammembers");

                Console.WriteLine($"{wSportName.Value}は1チーム{wTeamMembers.Value}名で構成されています。");
            }
        }

        /// <summary>
        /// ファイルパスを引数に取り、指定したファイルが存在するかと、指定したファイルがXMLファイルであるかを判定します。
        /// 指定したファイルが存在し、かつXMLファイルであった場合のみtrueを返します。
        /// </summary>
        /// <param name="vFilePath">ファイルパス</param>
        /// <returns>bool値</returns>
        static bool IsXmlFile(string vFilePath) {
            if (!File.Exists(vFilePath)) {
                Console.WriteLine("指定したファイルが見つかりません。パスを確認してください。");
                return false;
            }
            if (Path.GetExtension(vFilePath) != ".xml") {
                Console.WriteLine("ファイルの拡張子が正しくありません。XMLファイルを指定してください。");
                return false;
            }
            return true;
        }
    }
}
