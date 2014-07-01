Ayishay_ExcelWriter
===================
C# Excel Writer! one or multi-sheets Excel Writer!
Convert datatables to Excel spreadsheets


Features
========
* Save C# datatable / datatables to an Excel sheet
* Can save one datatable to one sheet 
  or datatables to multi-sheets on one Excel file
* can save as .xls or .xlsx file


How to use
==========
1. Add "Microsoft.Office.Interop.Excel.dll" to Reference (which is in "Ayishay_ExcelWriter / Ayishay_writerX /")
2. Add "AyishayWriter.cs" to your project
3. Do the followings

<pre>AyishayWriter ewriter = new AyishayWriter(fileName);
ewriter.DatatableToExcel(table1, sheetName1);
ewriter.DatatableToExcel(table2, sheetName2);
ewriter.saveExcel();
</pre>

