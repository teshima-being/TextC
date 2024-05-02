using System;
using System.Collections.Generic;
using System.IO;

namespace Practice9_4 {
    internal class Program {

        //問題9-4
        //指定したディレクトリ直下にあるファイルを別のディレクトリにコピーするプログラムを
        //作成してください。その際、コピーするファイル名は、拡張子を含まないファイル名の
        //後ろに、_bakを付加してください。つまり、元のファイル名がGreeting.textならば、
        //コピー先のファイル名はGreeting_bak.txtという名前にします。コピー先に同名のファイル
        //がある場合は置き換えてください。

        static void Main(string[] args) {

            Console.WriteLine("コピー元のディレクトリを指定してください。");
            string wUserInputDir = Console.ReadLine();

            if (!Directory.Exists(wUserInputDir)) {
                Console.WriteLine("指定したディレクトリは存在しません。処理を中止します。");
                return;
            }

            var wTargetDirectory = new DirectoryInfo(wUserInputDir);
            IEnumerable<FileInfo> wFiles = wTargetDirectory.EnumerateFiles("*", SearchOption.TopDirectoryOnly);

            if (wFiles == null) {
                Console.WriteLine("指定されたディレクトリ直下にはファイルが存在しません。");
                return;
            }

            Console.WriteLine("コピー先のディレクトリを指定してください。");
            string wOutputDirPath = Console.ReadLine();
            Directory.CreateDirectory(wOutputDirPath);

            foreach (var wFile in wFiles) {
                string wNewFilePath = CreateNewFilePath(wOutputDirPath, wFile.FullName);
                wFile.CopyTo(wNewFilePath, overwrite: true);

                //結果確認用
                Console.WriteLine(wNewFilePath);
            }
        }

        /// <summary>
        /// ファイルのコピー先のDirectory名とコピーするファイルのフルパスを引数に取り、
        /// 新たに作成するファイルのフルパスを返します。
        /// </summary>
        /// <param name="vDirectoryPath">ファイルのコピー先のディレクトリ名</param>
        /// <param name="vFilePath">コピーするファイルのフルパス</param>
        /// <returns>作成するファイルのフルパス</returns>
        public static string CreateNewFilePath(string vDirectoryPath, string vFilePath) {
            string wNewFileName = string.Concat(Path.GetFileNameWithoutExtension(vFilePath), "_bak", Path.GetExtension(vFilePath));
            return Path.Combine(vDirectoryPath, wNewFileName);
        }
    }
}
