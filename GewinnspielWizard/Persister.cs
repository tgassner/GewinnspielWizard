using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GewinnspielWizard {
    class Persister {

        public static void Store(string fileName, PersistentContainer persistentContainer) {
            string json = JsonConvert.SerializeObject(persistentContainer);
            WriteFile(fileName, json);
        }

        public static PersistentContainer Load(string fileName) {
            string json = ReadFile(fileName);
            PersistentContainer pc = JsonConvert.DeserializeObject<PersistentContainer>(json);
            return pc;
        }

        public static string ReadFile(String sFilename) {
            string sContent = "";

            if (File.Exists(sFilename)) {
                StreamReader myFile = new StreamReader(sFilename, System.Text.Encoding.Default);
                sContent = myFile.ReadToEnd();
                myFile.Close();
            }
            return sContent;
        }

        public static void WriteFile(String sFilename, String sLines) {
            using (StreamWriter myFile = new StreamWriter(sFilename)) {
                myFile.Write(sLines);
            }
        }
    }
}