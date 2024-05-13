using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice9_5 {
    internal class Program {

        //問題9-5
        //指定したディレクトリおよびそのサブディレクトリの配下にあるファイルから
        //ファイルサイズが1Mバイト（1,048,576バイト）以上のファイル名の一覧を表示する
        //プログラムを書いてください。

        static void Main(string[] args) {

            Console.WriteLine("検索するディレクトリパスを指定してください。");
            string wDirectory = Console.ReadLine();

            if (!Directory.Exists(wDirectory)) {
                Console.WriteLine("指定されたディレクトリは存在しません。処理を中止します。");
                return;
            }

            foreach (var wFileInfo in SearchFilesWithSize(wDirectory, 1048576)) {
                Console.WriteLine($"ファイル名：{wFileInfo.FullName.Remove(0,wDirectory.Length)}, ファイルサイズ：{wFileInfo.Length}");
            }
        }

        /// <summary>
        /// 検索対象のDirectoryのパスとファイルサイズ(byte)を引数に取り、対象Directory配下の全てのファイルのうち、
        /// サイズが指定数値以上であるファイルの列挙可能なコレクションを返します。
        /// </summary>
        /// <param name="vDirectoryPath">ディレクトリパス</param>
        /// <param name="vFileSize">ファイルサイズ(byte)</param>
        /// <returns>ファイルサイズが指定数値以上のファイル情報のコレクション</returns>
        public static IEnumerable<FileInfo> SearchFilesWithSize(string vDirectoryPath, int vFileSize) {
            var wTargetDirInfo = new DirectoryInfo(vDirectoryPath);
            return wTargetDirInfo.EnumerateFiles("*", SearchOption.AllDirectories).Where(x => x.Length >= vFileSize);
        }
    }
}
