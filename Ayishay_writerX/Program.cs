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
        }

        private DataTable TableOneGenerator()
        {
            DataTable table1 = new DataTable();
            table1.Columns.Add("Column1");
            table1.Columns.Add("Column2");
            table1.Columns.Add("Column3");

            table1.Rows.Add(new object[] { "Value1", "Value2", "Value3" });
            table1.Rows.Add(new object[] { "Value21", "Value22", "Value23" });
            table1.Rows.Add(new object[] { "Value31", "Value32", "Value33" });

            return table1;
        }
    }
}
