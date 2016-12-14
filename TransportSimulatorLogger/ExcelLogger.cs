using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace TransportSimulatorLogger
{
    public class ExcelLogger : LogBase
    {
        private static int length = 0;
        ExcelFile file;
        public ExcelLogger() {
            file = new ExcelFile();
            file.ExcelFilePath = "C:\\Users\\drozd_000\\Documents\\logger.xls";
        }
        public override void Log(string source, string message)
        {
            lock (lockObj)
            {
                file.openExcel();
                file.addDataToExcel(source, message);
                file.closeExcel();
            }    
         }
    }
}
