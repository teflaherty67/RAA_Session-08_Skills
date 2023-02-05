using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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

        }

        public void method2()
        {

        }

        public void method3()
        {

        }
    }
}
