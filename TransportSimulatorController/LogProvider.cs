using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportSimulatorLogger;

namespace TransportSimulatorController
{
    public class LogProvider
    {
        public static void logExcel(DataGridView dataGridView1,String fileName) {
            ExcelFile export = new ExcelFile();
            export.ExcelFilePath = fileName;
            export.openExcel();
            foreach (DataGridViewRow row in dataGridView1.Rows)
                export.addDataToExcel((string)row.Cells[0].Value, (string)row.Cells[1].Value);
            export.closeExcel();
        }
        public static void logWord(DataGridView dataGridView1, String fileName) {
            WordFile export = new WordFile();
            export.WordFilePath = fileName;
            export.openWord();
            foreach (DataGridViewRow row in dataGridView1.Rows)
                export.addDataToWord((string)row.Cells[0].Value, (string)row.Cells[1].Value);
            export.closeWord();
        }
    }
}
