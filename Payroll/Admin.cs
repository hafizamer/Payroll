﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//for the admin among staffs
namespace Payroll
{
    class Admin : Staff
    {
        private const float overtimeRate = 15.5f;
        private const float adminHourlyRate = 30f;

        public float Overtime { get; private set; }

        public Admin (string name): base (name, adminHourlyRate) { }

        public override void CalculatePay() //calculate payment
        {
            base.CalculatePay();


            if (HoursWorked > 160)
                Overtime = overtimeRate * (HoursWorked - 160);
        }

        public override string ToString()
        {
            return "\nNameOfStaff = " + NameOfStaff + "\nadminiHourlyRate =" + adminHourlyRate + "\nHoursWorked =" + HoursWorked + "\nBasicPay = " + BasicPay + "\nOvertime =" + Overtime + "\n\nTotalPat =" + TotalPay;
        }

    }
}
