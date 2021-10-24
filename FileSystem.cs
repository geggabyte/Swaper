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

        public void AddGame(string gameName, string savePath)
        {
            if(Directory.Exists("data\\" + gameName)) return;
            string cfgWay = "data\\" + gameName + "\\" + gameName +".cfg";

            GamesList.Add(gameName);

            Directory.CreateDirectory("data\\" + gameName);
            File.Create(cfgWay).Close();

            StreamWriter sw = new StreamWriter(cfgWay);
            sw.WriteLine(savePath);
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
    }
}
