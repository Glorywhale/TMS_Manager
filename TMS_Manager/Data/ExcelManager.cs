using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.OleDb;

namespace TMS_Manager
{
    public class ExcelManager
    {
        Excel.Application exApp = null;
        Excel.Workbook wb = null;
        Excel.Worksheet ws = null;

        public void SaveToExcel(System.Data.DataTable dt, string savePath)
        {
            try
            {
                exApp = new Excel.Application();
                wb = exApp.Workbooks.Add();
                ws = wb.Worksheets.get_Item(1) as Excel.Worksheet;

                //// Column Width 조절
                ws.Columns[6].ColumnWidth = 13;
                ws.Columns[7].ColumnWidth = 13;
                ws.Columns[8].ColumnWidth = 13;
                ws.Columns[9].ColumnWidth = 15;
                ws.Columns[10].ColumnWidth = 11;
                ws.Columns[11].ColumnWidth = 11;
                ws.Columns[12].ColumnWidth = 13;
                ws.Columns[14].ColumnWidth = 13;
                ws.Columns[15].ColumnWidth = 15;
                ws.Columns[15].ColumnWidth = 15;
                ws.Columns[16].ColumnWidth = 7;
                ws.Columns[17].ColumnWidth = 7;
                ws.Columns[18].ColumnWidth = 7;
                ws.Columns[19].ColumnWidth = 7;
                ws.Columns[20].ColumnWidth = 13;
                ws.Columns[22].ColumnWidth = 13;
                ws.Columns[24].ColumnWidth = 13;

                //// Column Write
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    DataColumn dc = dt.Columns[i];
                    ws.Cells[1, i + 1] = dc.ColumnName;
                }

                Excel.Range columnHeadingRange = ws.Range[ws.Cells[1, 1], ws.Cells[dt.Rows.Count + 1, 25]];
                //columnHeadingRange.Interior.Color = Color.LightBlue;
                columnHeadingRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                columnHeadingRange.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                //// Row Write
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    DataRow dr = dt.Rows[j];

                    for (int k = 0; k < dt.Columns.Count; k++)
                    {
                        ws.Cells[j + 2, k + 1] = dr[k];
                    }
                }

                wb.SaveAs(savePath, Excel.XlFileFormat.xlWorkbookNormal);
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
            finally
            {
                wb.Close();
                exApp.Quit();

                ReleaseExcelObject(ws);
                ReleaseExcelObject(wb);
                ReleaseExcelObject(exApp);
            }
        }

        private static void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

        // Excel 2007 이후 .xlsx
        string szConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=No'";
        /// <summary>
        /// 엑셀 파일로부터 데이터를 읽어서 DataTable로 리턴
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public DataTable ReadFromExcel(string filePath)
        {
            DataTable dt = null;
            try
            {
                string targetPath = string.Format(szConn, filePath);
                OleDbConnection conn = new OleDbConnection(targetPath);
                conn.Open();

                // 엑셀로부터 데이타 읽기
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", conn);
                OleDbDataAdapter adpt = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);

                dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    string data = string.Format("F1:{0}, F2:{1}, F3:{2}", dr[0], dr[1], dr[2]);                    
                }
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
            return dt;
        }
    }
}