using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Practice11_2 {
    internal class Program {

        //問題11-2
        //問題用XMLファイルを読み込み、次の形式に変換したのち、別のファイルに保存してください。 

        /*
        形式
        <?xml version="1.0" encoding="utf-8"?>
        <difficultkanji>
          <word kanji = "鬼灯" yomi="ほおずき" />
          <word kanji = "暖簾" yomi="のれん" />
          <word kanji = "杜撰" yomi="ずさん" />
          <word kanji = "坩堝" yomi="るつぼ" />
        </difficultkanji>
        */

        static void Main(string[] args) {

            if (args.Length == 0) {
                Console.WriteLine("コマンドライン引数でXMLファイルのパスを指定してください。");
                return;
            }

            string wXFilePath = args[0];

            if (!IsXmlFile(wXFilePath)) return;

            var wKanjiData = XDocument.Load(wXFilePath).Descendants("word").Select(x => ConvertElementsToAttributes(x));
            var wOutputRoot = new XElement("difficultkanji", wKanjiData);

            //読み込んだファイルと同じ階層に"KanjiData"の名前でファイルを保存する
            wOutputRoot.Save(Path.Combine(Path.GetDirectoryName(wXFilePath), "KanjiData.xml"));

            //確認用
            Console.WriteLine(wOutputRoot.ToString());
        }

        /// <summary>
        /// XMLファイルの要素を引数に取り、その要素の全ての子要素を属性に変換した要素を返します
        /// </summary>
        /// <param name="vElement">XMLファイルの要素</param>
        /// <returns>子要素を属性に変換したのちの要素</returns>
        public static XElement ConvertElementsToAttributes(XElement vElement) {
            foreach (var wElement in vElement.Elements()) {
                vElement.SetAttributeValue(wElement.Name.LocalName, wElement.Value);
            }
            vElement.Elements().Remove();
            return vElement;
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
