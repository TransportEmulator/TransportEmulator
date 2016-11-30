using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportSimulatorLogger
{
    public class DBLogger : LogBase

    {

        string connectionString = string.Empty;
        public override void Log(string message)
        {
            lock(lockObj){
                //MISCHANKA MUST IMPLEMENT IT LATER
            }
        }

    }
}
