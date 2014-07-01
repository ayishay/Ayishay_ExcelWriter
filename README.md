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
1. Add "Microsoft.Office.Interop.Excel.dll" to Reference
2. Add "AyishayWriter.cs" to your project
3. 

<code>AyishayWriter ewriter = new AyishayWriter(fileName);
   ewriter.DatatableToExcel(table1, sheetName1);
   ewriter.DatatableToExcel(table2, sheetName2);
   ewriter.saveExcel();
</code>
