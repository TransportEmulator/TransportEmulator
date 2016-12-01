using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportSimulatorLogger
{
    public class FileLogger : LogBase
    {
        public string filePath = @"..\\TransportLog.csv";
        public override void Log(string source,string message)
        {
            lock (lockObj)
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath,true))
                {                   
                    streamWriter.WriteLine(string.Format("{0},{1}", source, message));
                    streamWriter.Close();
                }
            }
        }
    }
}
