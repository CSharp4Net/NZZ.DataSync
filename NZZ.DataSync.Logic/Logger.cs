using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NZZ.DataSync.Logic
{
    public class Logger
    {
        public Logger(string folder)
        {
            Parentfolder = folder;
        }

        private static object lockObject = new object();

        public string Parentfolder { get; private set; }

        public string LogFolder { get { return Path.Combine(Parentfolder, "Log"); } }

        private const string _logFileNameFormat = "{0}.log";

        private const string _logEntryFormat = "{0} : {1} | {2} - {3}";

        public string LogFileName { get { return string.Format(_logFileNameFormat, DateTime.Now.ToString("yyyyMMdd")); } }

        public string LogFilePath { get { return Path.Combine(LogFolder, LogFileName); } }

        public void Log(string message, params object[] parameters)
        {
            WriteLog(LogType.INFO, "COMMON", message, parameters);
        }

        public void Log(MethodBase sender, string message, params object[] parameters)
        {
            WriteLog(LogType.WARNING, sender.Name, message, parameters);
        }

        public void Log(MethodBase sender, Exception ex)
        {
            WriteLog(LogType.ERROR, sender.Name, ex.ToString());
        }

        private void WriteLog(LogType type, string sender, string message, params object[] parameters)
        {
            try
            {
                lock (lockObject)
                {
                    string timeStamp = DateTime.Now.ToString("HH:mm:ss.fff");
                    string typeText = type.ToString();

                    if (!Directory.Exists(LogFolder))
                        Directory.CreateDirectory(LogFolder);

                    using (TextWriter writer = File.AppendText(LogFilePath))
                    {
                        string pattern = "{(.*?)}";
                        MatchCollection matches = Regex.Matches(message, pattern);
                        int uniqueCount = matches.OfType<Match>().Select(m => m.Value).Distinct().Count();

                        if (uniqueCount > parameters.Length)
                        {
                            StreamWriter.Synchronized(writer).WriteLine("The number of expected args is higher then parameter count!");

                            StreamWriter.Synchronized(writer).WriteLine(_logEntryFormat, timeStamp, typeText, sender, message);
                        }
                        else
                            StreamWriter.Synchronized(writer).WriteLine(_logEntryFormat, timeStamp, typeText, sender, string.Format(message, parameters));

                        writer.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                StringBuilder body = new StringBuilder();
                body.AppendLine("This error details would by write:");
                body.AppendLine("- Sender = " + sender);
                body.AppendLine("- Message = " + message);
                body.AppendLine("- Arguments = " + parameters.Length.ToString());
                body.AppendLine("----------------------------------");
                body.AppendLine("Following error occured while writing:");
                body.AppendLine(ex.Message);
                body.AppendLine(ex.ToString());

                //Toast.MakeText(Logic.AppInfo.ActuallyContext, body.ToString(), ToastLength.Long);
            }
        }

        public enum LogType
        {
            INFO, WARNING, ERROR
        }
    }
}