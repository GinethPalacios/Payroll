using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Payroll
{
    internal class payments
    {
        Data mydata = new Data();
        public void Calculatepayroll()

        {
            try
            {
                Console.WriteLine("enter the worker's name");
                mydata.Name1 = (Console.ReadLine());
                Console.WriteLine("enter the worker's last name");
                mydata.Lastname1 = (Console.ReadLine());
                Console.WriteLine("enter the document");
                mydata.Document1 = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the days worked");
                mydata.Workeddays1 = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the worker's salary");
                mydata.Salary1 = double.Parse(Console.ReadLine());
            }

            catch (FormatException e)
            {
                Console.WriteLine("Invalid enter valid data");
                Console.ReadKey();
            }

            mydata.Accrued1 = mydata.Salary1 / 30;
            mydata.Accrued1 = mydata.Accrued1 * mydata.Workeddays1;


            mydata.Transportationassistance1 = 117172 / 30;
            mydata.Transportationassistance1 = mydata.Transportationassistance1 * mydata.Workeddays1;

            mydata.Healt1 = mydata.Accrued1 * 0.04;
            mydata.Pension1 = mydata.Accrued1 * 0.04;

            if (mydata.Salary1 <= 2000000)
            {
                mydata.Accrued1 = mydata.Accrued1 + mydata.Transportationassistance1;

            }

            else
            {
                mydata.Accrued1 = mydata.Salary1;
            }
        }
        public void Print()
        {

            StreamWriter Write = File.AppendText("C:\\Payroll.txt");
            Write.WriteLine("Name Worked: " + mydata.Name1);
            Write.WriteLine("Lastname Worked: " + mydata.Lastname1);
            Write.WriteLine("Document Worked: " + mydata.Document1);
            Write.WriteLine("Salary Worked: " + mydata.Salary1);
            Write.WriteLine("Workeddays Worked: " + mydata.Workeddays1);
            Write.WriteLine("Accrued Worked: " + mydata.Accrued1);
            Write.WriteLine("Healt Worked: " + mydata.Healt1);
            Write.WriteLine("Pension Worked: " + mydata.Pension1);
            Write.WriteLine("");
            Write.WriteLine("--------------------New Worked------------------------");
            Write.WriteLine("");
            Write.Close();

        }
    }
}
