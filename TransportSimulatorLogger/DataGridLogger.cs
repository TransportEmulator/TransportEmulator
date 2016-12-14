using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportSimulatorLogger
{
    class DataGridLogger : LogBase
    {
        List<String[]> logData = new List<String[]>();
        public override void Log(string source, string message)
        {
            lock (lockObj) {
                logData.Add(new string[]{ source,message});
            }
        }
    }
}
