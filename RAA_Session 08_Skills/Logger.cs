using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;

namespace RAA_Session_08_Skills
{
    internal class Logger
    {
        public string FilePath { get; set; }
        public string UserName { get; set; }
        public string LogPath { get; set; }

        public Logger(string filePath, string userName)
        {
            FilePath = filePath;
            UserName = userName;

            LogPath = @"C:\temp\RAA log.csv";
        }

        public void method1()
        {
            string message = FilePath + "," + UserName + "," + DateTime.Now.ToString();
            WriteToFile(message);
        }

        public void method2()
        {

        }

        public void method3()
        {

        }

        private void WriteToFile(string message)
        {
            if(File.Exists(LogPath) == false)
            {
                string header = "Item 1, Item 2, Item 3";
                File.WriteAllText(LogPath, header + Environment.NewLine);
            }

            File.AppendAllText(LogPath, message + Environment.NewLine);
        }
    }
}
