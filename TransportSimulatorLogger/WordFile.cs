using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Word;
namespace TransportSimulatorLogger
{
    public class WordFile
    {

        private string wordFilePath = string.Empty;
        private int rowNumber = 1; // define first row number to enter data in excel
        object missing = System.Reflection.Missing.Value;
        Microsoft.Office.Interop.Word.Application myWordApplication;
        Microsoft.Office.Interop.Word.Document document ;

        public string WordFilePath
        {
            get { return wordFilePath; }
            set { wordFilePath = value; }
        }

        public int Rownumber
        {
            get { return rowNumber; }
            set { rowNumber = value; }
        }

        public void openWord()
        {
            myWordApplication = null;

            myWordApplication  = new Microsoft.Office.Interop.Word.Application(); // create Excell App
            myWordApplication.Visible = true;
            document = myWordApplication.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
            {
                //Get the header range and add the header details.
                Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                headerRange.Font.Size = 10;
                headerRange.Text = "Transport simulator log file";
            }

           
           
        }

        public void addDataToWord(string source,string ev)
        {

            document.Content.SetRange(0, 0);
            document.Content.Text += source+"  "+ev + Environment.NewLine;

            rowNumber++;  // if you put this method inside a loop, you should increase rownumber by one or wat ever is your logic

        }

        public void closeWord()
        {
            document.SaveAs2(WordFilePath);    
            

        }
    }
}
