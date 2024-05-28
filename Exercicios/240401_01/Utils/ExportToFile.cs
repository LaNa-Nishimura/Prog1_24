using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlTypes;

namespace _240401_01.Utils
{
    public class ExportToFile
    {
        private const string dir = @"C:\Users\235199\Desktop\Prog1_24\Exercicios\Arquivos";

        public static bool SaveToDelimitedTxt(string fileName, string fileContent) {
            string filePath = $@"{dir}\{fileName}";

            try {
                if (!System.IO.Directory.Exists(dir)) {
                    Directory.CreateDirectory(dir);
                }
                using(StreamWriter sw = File.CreateText(filePath)) {
                    sw.Write(fileContent);
                }
            }

            catch {
                return false;
            }

            return true;
        }
    }
}