using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Swaper
{
    class FileSystem
    {
        public List<String> GamesList = new List<string>();
        string SwaperCfgWay = "data\\swap.cfg";

        public FileSystem()
        {
            if (Directory.Exists("data"))
            {
                if (File.Exists(SwaperCfgWay))
                {
                    string result;
                    StreamReader sr = new StreamReader(SwaperCfgWay);
                    while (true)
                    {
                        result = sr.ReadLine();
                        if (result == null) break;
                        GamesList.Add(result);
                    }
                    sr.Close();
                }
                else Save();
            }
            else
            {
                Directory.CreateDirectory("data");
                Save();
            }
        }

        public List<string> ShowSaves(string game)
        {
            List<string> result = new List<string>();
            foreach(string a in Directory.GetDirectories("data\\" + game))
            {
                result.Add(Path.GetFileName(a));
            }
            return result;
        }

        public void AddGame(string gameName, string savePath, string saveFolderName)
        {
            if(Directory.Exists("data\\" + gameName)) return;
            string cfgWay = "data\\" + gameName + "\\" + gameName +".cfg";


            GamesList.Add(gameName);


            Directory.CreateDirectory("data\\" + gameName);
            Directory.CreateDirectory("data\\" + gameName + "\\" + saveFolderName);
            File.Create(cfgWay).Close();


            CopyDirectory(savePath, "data\\" + gameName + "\\" + saveFolderName);


            StreamWriter sw = new StreamWriter(cfgWay);
            sw.WriteLine(savePath);
            sw.WriteLine(saveFolderName);
            sw.WriteLine(saveFolderName);
            sw.Close();

            Save();
        }

        public void Remove(string name)
        {
            if (!Directory.Exists("data\\" + name)) return;
            Directory.Delete("data\\" + name, true);
            GamesList.Remove(name);
            Save();
        }

        public void Save()
        {
            StreamWriter sw = new StreamWriter(SwaperCfgWay);
            foreach(string a in GamesList)
            {
                sw.WriteLine(a);
            }
            sw.Close();
        }

        public void CopyCurrentToSelected(string gameName, string saveDestination)
        {
            string _data = "data\\" + gameName + "\\";
            StreamReader sr = new StreamReader(_data + gameName + ".cfg");
            CopyDirectory(sr.ReadLine(), _data + saveDestination);
            sr.Close();
        }

        public void CreateEmpty(string name, string gameName)
        {
            Directory.CreateDirectory("data\\" + gameName + "\\" + name);
        }

        public void RemoveSave(string saveName, string gameName)
        {
            Directory.Delete("data\\" + gameName + "\\" + saveName, true);
        }

        public void SelectSave(string gameName, string saveName)
        {
            string dataPath = "data\\" + gameName + "\\";

            StreamReader sr = new StreamReader(dataPath + gameName + ".cfg");

            string savePath = sr.ReadLine();
            string standartSaveName = sr.ReadLine();
            string lastSave = sr.ReadLine();
            sr.Close();

            CopyDirectory(savePath, dataPath + lastSave);
            Directory.Delete(savePath, true);
            Directory.CreateDirectory(savePath);
            CopyDirectory(dataPath + saveName, savePath);

            StreamWriter sw = new StreamWriter(dataPath + gameName + ".cfg");
            sw.WriteLine(savePath);
            sw.WriteLine(standartSaveName);
            sw.WriteLine(saveName);
            sw.Close();
        }

        private void CopyDirectory(string sourcePath, string targetPath)
        {
            foreach(string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            foreach (string newPath in Directory.GetFiles(sourcePath, "*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }
    }
}
