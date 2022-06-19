using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    internal class Menu
    {
        public int NumberWorked = 1;
        public static void Main(string[] args)
        {
            Menu menu = new Menu();

            Console.WriteLine("Welcome to the Worked Payroll");
            payments Payments = new payments();

            int Option = 1;

            do
            {
                Console.WriteLine("1) To add a worked");
                Console.WriteLine("2) Exit the program");
                Option = int.Parse(Console.ReadLine());

                switch (Option)
                {
                    case 1:
                        {
                            Console.WriteLine("Worked:" + menu.NumberWorked);
                            Payments.Calculatepayroll();
                            Payments.Print();
                            
                            break;

                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Completed program");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Insert a correct number");
                            break;
                        }
                        Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°\n\n");
                        Console.Clear();
                }
                menu.NumberWorked++;
            } while (Option != 2);
        }



    }
    
}
