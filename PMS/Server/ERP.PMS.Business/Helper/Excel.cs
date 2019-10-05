using System;
using _Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace ERP.PMS.Business.Helper
{
    public class ExcelReader
    {
        _Excel.Application _excel = new _Excel.Application();
        private string path = String.Empty;
        private Workbook _workbook;
        private Worksheet _worksheet;

        public void Open(string path)
        {
            this.path = path;
            this._workbook = _excel.Workbooks.Open(path);
        }

        public void LoadSheet(int sheet)
        {
            this._worksheet = this._workbook.Sheets[sheet];
        }

        public string ReadCell(int row,int col)
        {
            return _worksheet.Cells[row, col]?.Value2 ?? String.Empty;
        }
    }
}