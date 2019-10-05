using System;
using System.Collections.Generic;

namespace ERP.PMS.Business.Helper
{
    public class ExcelIterator
    {
        private ExcelReader excelReader;

        public ExcelIterator(string path)
        {
            excelReader = new ExcelReader();
            excelReader.Open(path);
            excelReader.LoadSheet(1);
        }


        public List<string> GetHeader()
        {
            int col = 1;
            List<string> cells = new List<string>();
            while (true)
            {
                var val = excelReader.ReadCell(1, col++);
                if (String.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val)) break;
                cells.Add(val);
            }

            return cells;
        }
    }
}