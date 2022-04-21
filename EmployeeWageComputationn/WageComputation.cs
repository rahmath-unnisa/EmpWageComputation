﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationn
{
    public class WageComputation
    {
        const int IS_PRESENT = 0, IS_PART_TIME = 1, IS_FULL_TIME = 2;

        public void EmployeeAttendence()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");

        }
        public  int Company(string company, int empRatePerHr, int NUM_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH )
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {

                totalWorkingDays++;
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs:" + empHrs);
            }
                int totalEmpWage = totalEmpHrs * empRatePerHr;
                Console.WriteLine("Total Emp Wage for company:" + company + " is :" + totalEmpWage);
                return totalEmpHrs;
        }
    }

}