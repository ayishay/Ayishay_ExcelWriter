using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using System.Diagnostics;

namespace Ayishay_writerX
{
    class Program
    {
        static void Main(string[] args)
        {

            DataTable table1 = new DataTable();
            table1.Columns.Add("Column1");
            table1.Columns.Add("Column2");
            table1.Columns.Add("Column3");
            table1.Rows.Add(new object[] { "Value1", "Value2", "Value3" });
            table1.Rows.Add(new object[] { "Value21", "Value22", "Value23" });
            table1.Rows.Add(new object[] { "Value31", "Value32", "Value33" });

            DataTable table2 = new DataTable();
            table2.Columns.Add("Column1");
            table2.Columns.Add("Column2");
            table2.Columns.Add("Column3");
            table2.Rows.Add(new object[] { "Value221", "Value222", "Value223" });
            table2.Rows.Add(new object[] { "Value2221", "Value2222", "Value2223" });
            table2.Rows.Add(new object[] { "Value2231", "Value2232", "Value2233" });

            string filename = "thisfile.xlsx";
            AyishayWriter writer = new AyishayWriter(filename);
            writer.DatatableToExcel(table1, "table1");
            writer.DatatableToExcel(table2, "table2");
            writer.saveExcel();
            Console.ReadKey();
        }
    }
}
