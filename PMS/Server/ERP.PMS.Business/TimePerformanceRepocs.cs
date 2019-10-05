using ERP.PMS.Common.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.PMS.Business.Helper;
using Excel = Microsoft.Office.Interop.Excel;

//using Excel = Microsoft.Office.Interop.Excel;

namespace ERP.PMS.Business
{
    public partial class PMSBusiness
    {
        public void AddTimePerformanceByExcel(string path)
        {
            //ExcelReader excelReader = new ExcelReader();
            //excelReader.Open(path,1);
            //var cell1 = excelReader.ReadCell(1, 1);
//            Excel.Application xlApp = new Excel.Application();
//            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
//            var xlWorkbookSheet = xlWorkbook.Sheets[1];
//            Excel.Range xlRange =  xlWorkbookSheet.UsedRange;
//            int rowCount = xlRange.Rows.Count;
//            int colCount = xlRange.Columns.Count;
//            string s = "";
//            //iterate over the rows and columns and print to the console as it appears in the file
//            //excel is not zero based!!
//            for (int i = 1; i <= rowCount; i++)
//            {
//                for (int j = 1; j <= colCount; j++)
//                {
//                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j] != null)
//                        s += xlRange.Cells[i, j].ToString();
//                }
//            }
        }
    }
}
