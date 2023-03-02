using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arxium.TestApp
{
    public static class Logger
    {
        private static string _workDir = Directory.GetCurrentDirectory();
        private const string _logName = "DrugIncrementTest.log";
        private static string _log = Directory.GetParent(_workDir)?.Parent?.Parent?.FullName + $"\\log\\{_logName}";

        public static void Log(string log)
        {
            try
            {
                using (var fs = File.Open(_log, FileMode.Append))
                {
                    var toLog = new UTF8Encoding(true).GetBytes(log + Environment.NewLine);
                    fs.Write(toLog, 0, toLog.Length);
                }
            }
            catch (FileLoadException ex)
            {
                Console.WriteLine("File is opened ", ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found ", ex.Message);
            }
        }

        public static void InitializeLog()
        {
            try
            {
                if (File.Exists(_log))
                    File.Delete(_log);

                var fs = File.Create(_log);
            }
            catch(Exception ex)
            {
                Console.WriteLine("File is opened ", ex.Message);
            }
        }

        public static string GetLogs()
        {
            string textLog = "";
            try
            {
                textLog = File.ReadAllText(_log);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return textLog;
        }
    }
}
