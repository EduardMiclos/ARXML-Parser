using System;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using GemBox.Spreadsheet;
using System.Linq;

namespace XmlParser
{
    class Excel
    {
        private string path;
        private ExcelFile workBook;
        private ExcelWorksheet workSheet;

        private int FILE_columnIndex = -1, FROM_columnIndex = -1, TO_columnIndex = -1;

        private int currentRowIndex = -1;

        internal static string currentFile = " ";
        internal static string currentFrom = " ";
        internal static string currentTo = " ";

        internal static string EmptyRow = " ";

        public Excel(string inputPath)
        {
            this.init(inputPath);
            this.workSheet = this.workBook.Worksheets[0];
        }

        public Excel(string inputPath, int inputWorkSheet)
        {
            this.init(inputPath);
            this.workSheet = this.workBook.Worksheets[inputWorkSheet];
        }

        private void init(string inputPath)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            this.path = inputPath;
            this.workBook = ExcelFile.Load(this.path);
        }

        public bool findTable()
        {
            int rowCount = 0, columnCount;

            foreach(ExcelRow row in this.workSheet.Rows)
            {
                columnCount = 0;
                foreach(ExcelCell cell in row.AllocatedCells)
                {
                    string cellValue = cell.Value?.ToString() ?? "";

                    if(cellValue == "FILE")
                    {
                        this.FILE_columnIndex = columnCount;
                        this.FROM_columnIndex = columnCount + 1;
                        this.TO_columnIndex = columnCount + 2;

                        this.currentRowIndex = rowCount + 1;
                        return true;
                    }

                    columnCount++;
                }
                rowCount++;
            }

            return false;
        }

        public string extractNextRow()
        {
            if(this.currentRowIndex < 0 || this.FILE_columnIndex < 0 || this.FROM_columnIndex < 0 || this.TO_columnIndex < 0)
            {
                return Excel.EmptyRow;
            }
            
            ExcelRow row = this.workSheet.Rows[this.currentRowIndex];
            ExcelCell FILE_cell = row.AllocatedCells[this.FILE_columnIndex];
            ExcelCell FROM_cell = row.AllocatedCells[this.FROM_columnIndex];
            ExcelCell TO_cell = row.AllocatedCells[this.TO_columnIndex];

            if(FILE_cell.Value != null)
            {
                Excel.currentFile = FILE_cell.Value.ToString();
            }

            if(Excel.currentFile == " " || FROM_cell.Value == null || TO_cell.Value == null)
            {
                return Excel.EmptyRow;
            }

            this.currentRowIndex++;

            Excel.currentFrom = FROM_cell.Value.ToString();
            Excel.currentTo = TO_cell.Value.ToString();

            return Excel.currentFile + Excel.currentFrom + Excel.currentTo;
        }
    }
}
