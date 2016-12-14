using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TransportSimulatorLogger
{
    public static class LogHelper

    {

        private static LogBase logger = new ExcelLogger();
        
        public static void Log(LogTarget target,string source, string message)
        {
            switch (target)
            {
                case LogTarget.File:
                    logger = new FileLogger();
                    ThreadPool.QueueUserWorkItem(delegate { logger.Log(source, message); });
                    break;
                case LogTarget.Database:
                    logger = new DBLogger();
                    logger.Log(source,message);
                    break;
                case LogTarget.EventLog:
                    logger = new EventLogger();
                    logger.Log(source,message);
                    break;
                case LogTarget.ExcelLogger:
                   // logger = new DataGridLogger();
                    ThreadPool.QueueUserWorkItem(delegate { logger.Log(source, message); } );
                    break;
                default:
                    return;
            }
        }

    }
}
