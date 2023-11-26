using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NikolaevaAN.Sprint5.Task7.V20.Lib
{
    public class DataService : ISprint5Task7V20
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaverFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V20.txt";
            FileInfo fileInfo = new FileInfo(pathSaverFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaverFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length - 1; i++)
                    {
                        if (((line[i] == 'с') & (line[i + 1] == 'с')) | ((line[i] == 'С') & (line[i + 1] == 'с')))
                        {
                            line.Remove(i, 1);
                        }
                        else
                        {
                            strLine = strLine + line[i];
                        }
                    }
                    strLine = strLine + line.Substring(line.Length - 1);
                    File.AppendAllText(pathSaverFile, strLine + Environment.NewLine);
                    strLine = "";
                }
                return pathSaverFile;
            }
        }
    }
}
