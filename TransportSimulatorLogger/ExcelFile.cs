using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace TransportSimulatorLogger
{
    public class ExcelFile
    {

        private string excelFilePath = string.Empty;
        private int rowNumber = 1; // define first row number to enter data in excel
        object misValue = System.Reflection.Missing.Value;
        Excel.Application myExcelApplication;
        Excel.Workbook myExcelWorkbook;
        Excel.Worksheet myExcelWorkSheet;

        public string ExcelFilePath
        {
            get { return excelFilePath; }
            set { excelFilePath = value; }
        }

        public int Rownumber
        {
            get { return rowNumber; }
            set { rowNumber = value; }
        }

        public void openExcel()
        {
            myExcelApplication = null;

            myExcelApplication = new Excel.Application(); // create Excell App
            myExcelApplication.DisplayAlerts = false; // turn off alerts
            myExcelApplication.Visible = true;

        //    myExcelWorkbook = (Excel.Workbook)(myExcelApplication.Workbooks._Open(excelFilePath, System.Reflection.Missing.Value,
         //      System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
          //     System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
           //    System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
            //   System.Reflection.Missing.Value, System.Reflection.Missing./Value)); // open the existing excel file
            //myExcelWorkbook= myExcelApplication.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            myExcelWorkbook = myExcelApplication.Workbooks.Add(misValue);
            myExcelWorkSheet = (Excel.Worksheet)myExcelWorkbook.Worksheets.get_Item(1);// define in which worksheet, do you want to add data
           // myExcelWorkSheet.Name = "WorkSheet 1"; // define a name for the worksheet (optinal)

           
        }

        public void addDataToExcel(string source,string ev)
        {

            myExcelWorkSheet.Cells[rowNumber, 1] = source;
            myExcelWorkSheet.Cells[rowNumber, 2] = ev;
          
            rowNumber++;  // if you put this method inside a loop, you should increase rownumber by one or wat ever is your logic

        }

        public void closeExcel()
        {
            myExcelWorkbook.SaveAs(ExcelFilePath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            Marshal.ReleaseComObject(myExcelWorkSheet);
            Marshal.ReleaseComObject(myExcelWorkbook);
            Marshal.ReleaseComObject(myExcelApplication);

        }
    }
}
