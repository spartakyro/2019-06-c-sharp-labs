using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Xceed.Words.NET;
using Microsoft.Office.Interop.Excel;
namespace lab_55_CSV_word_Excel
{
    class Program
    {

        static void Main(string[] args)
        {
            /*File.Delete("output.csv");
            File.AppendAllText("output.csv", "Seconds,Rabbit population\n");
            for(int i = 0; i < 10; i++)
            {
                File.AppendAllText("output.csv", $"{i},{Math.Pow(2,i)}\n");
            }
            Process.Start("output.csv");*/


            //============================================DOCX======================================================

            var rabbitPopulation = 1;
            var limit = 500;
            var seconds = 0;
            //build word document
            /*var document = DocX.Create("RabbitPopulationExplosion.docx");
           
            document.InsertParagraph("this is a document about the explosion of the rabbit population in sparta london");
            document.InsertParagraph(" ");
            document.InsertParagraph($"seconds\trabbitPopulation");


            while (rabbitPopulation < limit)
            {

                seconds++;
                rabbitPopulation *= 2; //doubling
                document.InsertParagraph($"{seconds}\t\t\t{rabbitPopulation}");
            }

            document.Save();
            Process.Start("WinWord.exe", "RabbitPopulationExplosion.docx");*/


            //================================================Population rabbit count===================================================
             var populationCount = 1_000_000;
             var counter = 0;
             double rabbitpop = 0;


             while(rabbitpop<populationCount)
             {
                 rabbitpop = Math.Pow(2,counter);


                 Console.WriteLine($"there are {rabbitpop} rabbits after {counter} seconds");

                 counter++;
                 System.Threading.Thread.Sleep(100);

             }

             Console.WriteLine($"population is {rabbitpop} after {counter} seconds");


            //============================================EXCEL==========================================================

            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;

            object misvalue = System.Reflection.Missing.Value;
            try
            {
                //Start Excel and get Application object.
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "First Name";
                oSheet.Cells[1, 2] = "Last Name";
                oSheet.Cells[1, 3] = "Full Name";
                oSheet.Cells[1, 4] = "Salary";

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "D1").Font.Bold = true;
                oSheet.get_Range("A1", "D1").VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                string[,] saNames = new string[5, 2];

                saNames[0, 0] = "John";
                saNames[0, 1] = "Smith";
                saNames[1, 0] = "Tom";

                saNames[4, 1] = "Johnson";

                //Fill A2:B6 with an array of values (First and Last Names).
                oSheet.get_Range("A2", "B6").Value2 = saNames;

                //Fill C2:C6 with a relative formula (=A2 & " " & B2).
                oRng = oSheet.get_Range("C2", "C6");
                oRng.Formula = "=A2 & \" \" & B2";

                //Fill D2:D6 with a formula(=RAND()*100000) and apply format.
                oRng = oSheet.get_Range("D2", "D6");
                oRng.Formula = "=RAND()*100000";
                oRng.NumberFormat = "$0.00";

                //AutoFit columns A:D.
                oRng = oSheet.get_Range("A1", "D1");
                oRng.EntireColumn.AutoFit();

                //test
                oSheet.Cells[7, 1] = "Rabbit population";
                oSheet.Cells[9, 1] = "seconds";
                oSheet.Cells[9, 2] = "population";

                //redo lab
                //reset population
                rabbitPopulation = 1;
                seconds = 0;
                oSheet.Cells[10, 1] = "0";
                oSheet.Cells[10, 2] = "1";
                
                while(rabbitPopulation<limit)
                {
                    oSheet.Cells[10+seconds, 1] = $"{seconds}";
                    oSheet.Cells[10+seconds, 2] = $"{rabbitPopulation}";

                    rabbitPopulation *= 2;
                    seconds++;
                }







                //oXL.Visible = false;
                //oXL.UserControl = false;
                // saves in My Documents
                oWB.SaveAs("test505.xls", XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                    false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                oWB.Close();
                System.Threading.Thread.Sleep(1000);

            }
            catch (Exception e)
            {

            }

            //Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\test505.xls");


            



        }
    }
}
