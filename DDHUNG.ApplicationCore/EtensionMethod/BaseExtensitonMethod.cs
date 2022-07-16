using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DDHUNG.ApplicationCore.EtensionMethod
{
    public static class BaseExtensitonMethod
    {

        public static DataTable ToDataTable<T>(this IList<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //get all property
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach(PropertyInfo prop in Props)
            {
                // defining type of data column gives proper data table

                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);

                //setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }

            foreach(T item in items)
            {
                var values = new object[Props.Length];
                for(int i = 0; i < Props.Length; i++)
                {
                    // inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

    }
}
