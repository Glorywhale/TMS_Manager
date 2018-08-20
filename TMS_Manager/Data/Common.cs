using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TMS_Manager
{
    public class Common
    {
        public static List<object> GetEnumList(Type type)
        {
            List<object> returnList = new List<object>();
            try
            {
                returnList = Enum.GetValues(type).Cast<object>().ToList();
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
            return returnList;
        }

        public static List<EnumDisease> GetDiseaseList()
        {
            List<EnumDisease> DiseaseList = new List<EnumDisease>();
            try
            {
                DiseaseList = Enum.GetValues(typeof(EnumDisease)).Cast<EnumDisease>().ToList();
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
            return DiseaseList;
        }

        public static List<EnumBug> GetBugList ()
        {
            List<EnumBug> bugList = new List<EnumBug>();
            try
            {
                bugList = Enum.GetValues(typeof(EnumBug)).Cast<EnumBug>().ToList();
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
            return bugList;
        }

        public static List<EnumPeriod> GetPeriodList()
        {
            List<EnumPeriod> pList = new List<EnumPeriod>();
            try
            {
                pList = Enum.GetValues(typeof(EnumPeriod)).Cast<EnumPeriod>().ToList();
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
            return pList;
        }

        public static List<EnumGrade> GetGradeList()
        {
            List<EnumGrade> gList = new List<EnumGrade>();
            try
            {
                gList = Enum.GetValues(typeof(EnumGrade)).Cast<EnumGrade>().ToList();
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
            return gList;
        }

        public static DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    // You could potentially name the column based on the DGV column name (beware of dupes)
                    // or assign a type based on the data type of the data bound to this DGV column.
                    dt.Columns.Add(column.HeaderText);
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }
    }
}
