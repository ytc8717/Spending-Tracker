using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;

namespace GenericMethodForTableFilter
{
    public static class DTfilter
    {
        public static DataTable exFilter(this DataTable dtSource, string strSearchString)
        {
            DataTable newDataTable = new DataTable();

            //Creating Filter Query
            string FilterQuery = "";
            for (int v = 0; v <= dtSource.Columns.Count - 1; v++)
            {
                newDataTable.Columns.Add(dtSource.Columns[v].ColumnName);

                if (string.IsNullOrEmpty(FilterQuery))
                {
                    FilterQuery = "[" + dtSource.Columns[v].ColumnName + "] Like '%" + strSearchString + "%' ";
                }
                else
                {
                    FilterQuery += " or [" + dtSource.Columns[v].ColumnName + "] like '%" + strSearchString + "%' ";
                }
            }



            //coping data from source table to newly created table(where all the columns are typed String)
            newDataTable.Load(dtSource.CreateDataReader(), System.Data.LoadOption.OverwriteChanges);


            //Performing filter using DataView
            DataView dv = newDataTable.DefaultView;
            dv.RowFilter = FilterQuery;

            
            return dv.ToTable();
        }
    }
}
