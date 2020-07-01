using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    class SavePassword
    {
        string path = "SavePass.txt";
        public SavePassword()
        {

        }
        public SavePassword(string login, string pass)
        {
            DataRecordingToFile(login, pass);
        }
        public void DataRecordingToFile(string login, string pass)
        {
            
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(login + "\n" + pass);
            sw.Close();
            fs.Close();
            
        }
        public string GetData(int num)
        {
            string[] array = new string[2];
            string line = String.Empty;
            int i = 0;
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                while ((line = sr.ReadLine()) != null)
                {
                    array[i] = line;
                    i++;
                }
                sr.Close();

            }
            return array[num];
        }
        public bool CheckedFile()
        {
            if (File.Exists(path)) {
                return true;
            }
            return false;
        }
        public void ClearData()
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }

        }
    }
}
