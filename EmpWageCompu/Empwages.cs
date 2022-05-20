using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompu
{
    internal class Empwages
    {

        public const float WagesPerHour = 20;
        public const int FullTime_WorkingHrs_PerDay = 8;
        public const int PartTime_WorkingHrs_PerDay = 4;
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int IS_ABSENT = 0;
        public const int MAX_WORKING_HOURS = 100;
        public const int MAX_WORKING_DAYS = 20;
        public float TotalWage = 0;
        float EmpDailyWage = 0;

        public void EmpWage()
        {
            int DayNumber = 1;
            int EmpWorkinghrs = 0;
            int TotalWorkinghrs = 0;
            while (DayNumber <= MAX_WORKING_DAYS || TotalWorkinghrs <= MAX_WORKING_HOURS)
            {
                Random Check = new Random();
                int CheckEmp = Check.Next(0, 3);

                switch (CheckEmp)
                {
                    case IS_ABSENT:
                        EmpWorkinghrs = 0;
                        break;
                    case IS_PART_TIME:
                        EmpWorkinghrs = PartTime_WorkingHrs_PerDay;
                        break;
                    case IS_FULL_TIME:
                        EmpWorkinghrs = FullTime_WorkingHrs_PerDay;
                        break;
                }
                EmpDailyWage = EmpWorkinghrs * WagesPerHour;

                TotalWage += EmpDailyWage;
                DayNumber++;
                TotalWorkinghrs += EmpWorkinghrs;

            }
            Console.WriteLine("Total Working Days : " + (DayNumber - 1) + "\nTotal working hours :" + TotalWorkinghrs + "\nTotal employee wage :" + TotalWage);

        }
    }
}
