using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


//for the manager among staffs
namespace Payroll
{
    class Manager : Staff
    {
        private const float managerHourlyRate = 50;
        public int Allowance { get; private set; }
        public Manager (string name) : base(name, managerHourlyRate) { }

        public override void CalculatePay() //calculate payment
        {
            base.CalculatePay();
            Allowance = 1000;

            if (HoursWorked > 160)
                TotalPay = BasicPay + Allowance;
        }

        public override string ToString()
        {
            return "\nNameOfStaff = " + NameOfStaff + "\nmanagerHourlyRate =" + managerHourlyRate + "\nHoursWorked =" + HoursWorked + "\nBasicPay = " + BasicPay + "\n\nTotalPay =" + TotalPay;
        }
    }
}
