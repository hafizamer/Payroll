using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// About each staff and their pay

namespace Payroll
{
    class Staff
    {
        private float hourlyRate; //pay per hour
        private int hWorked; //how long working

        public string NameOfStaff { get; private set; } //staff name
        public float BasicPay { get; private set; } //basic payment
        public float TotalPay { get; protected set; } //total payment

        public int HoursWorked // calculate working hour
        { 
            get 
            {
               return hWorked; 
            } 
            set 
            {
              if (value >0)
              hWorked=value;
              else
              hWorked = 0;
            } 
        }

        public Staff(string name, float rate) //staff name and their rate
        {
            NameOfStaff = name;
            hourlyRate = rate;
        }

        public virtual void CalculatePay() //calculate payment
        {
            Console.WriteLine("Calculating Pay....");

            BasicPay = hWorked * hourlyRate;
            TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return "\nNameOfStaff = " + NameOfStaff + "\nhourlyRate =" + hourlyRate + "\nhWorked =" + hWorked + "\nBasicPay = " + BasicPay + "\n\nTotalPay =" + TotalPay;
        }

    }
}
