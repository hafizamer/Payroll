﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Staff> myStaff = new List<Staff>();
            FileReader fr = new FileReader();
            int month = 0;
            int year = 0;

            while (year == 0)
            {
                Console.Write("\nPlease enter year: ");

                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "Please Try Again ");
                }
            }

            while (month == 0)
            {
                Console.Write("\nPlease enter month (in number format): ");

                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Invalid Month, try again, make sure in number");
                    month = 0;
                }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "Please Try Again ");
                }
            }

            myStaff = fr.ReadFile();

            for (int i=0; i <myStaff.Count; i++)
            {
                try
                {
                    Console.Write("\nEnter hours worked for {0}: ",
                    myStaff[i].NameOfStaff);
                    myStaff[i].HoursWorked = Convert.ToInt32(Console.ReadLine());
                    myStaff[i].CalculatePay();
                    Console.WriteLine(myStaff[i].ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }

            PaySlip ps = new PaySlip(month, year);
            ps.GeneratePaySlip(myStaff);
            ps.GenerateSummary(myStaff);

            Console.Read();

        }
    }
}
