using System;
using System.Windows.Forms;
//using Word = Microsoft.Office.Interop.Word;
//using Excel = Microsoft.Office.Interop.Excel;

namespace AnalyseEtControleFEC
{
    class ExportFile
    {
        /*public bool ExportDataGridviewToWord(DataGridView dgv, bool isShowWord)
        {
            Word.Document mydoc = new Word.Document();
            Word.Table mytable;//declare a table in word
            Word.Selection mysel;//declare a region in word
            Object myobj;
            if (dgv.Rows.Count == 0)
                return false;
            //create an object word
            Word.Application word = new Word.Application();
            myobj = System.Reflection.Missing.Value;
            mydoc = word.Documents.Add(ref myobj, ref myobj, ref myobj, ref myobj);
            word.Visible = isShowWord;
            mydoc.Select();
            mysel = word.Selection;
            //create a word table 
            mytable = mydoc.Tables.Add(mysel.Range, dgv.RowCount, dgv.ColumnCount, ref myobj, ref myobj);
            //width
            mytable.Columns.SetWidth(80, Word.WdRulerStyle.wdAdjustNone);
            //export the headers
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                mytable.Cell(1, i + 1).Range.InsertAfter(dgv.Columns[i].HeaderText);
            }
            //export the information in the DataGridView
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    mytable.Cell(i + 2, j + 1).Range.InsertAfter(dgv[j, i].Value.ToString());
                }
            }
            return true;
        }

        public bool ExportDataGridviewToExcel(DataGridView dgv, bool isShowExcle)
        {
            if (dgv.Rows.Count == 0)
                return false;
            //create an object excel
            Excel.Application excel = new Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Visible = isShowExcle;
            //create the headers
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                excel.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }
            //fill the donne
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dgv[j, i].ValueType == typeof(string))
                    {
                        excel.Cells[i + 2, j + 1] = "'" + dgv[j, i].Value.ToString();
                    }
                    else
                    {
                        excel.Cells[i + 2, j + 1] = dgv[j, i].Value.ToString();
                    }
                }
            }
            return true;
        }*/
    }
}
