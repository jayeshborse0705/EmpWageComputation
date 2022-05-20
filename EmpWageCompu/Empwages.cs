using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompu
{
    internal class Empwages
    {

        public float EmpWagePerHour = 20;
        public int FullTime_WorkingHrs_PerDay = 8;
        public int PartTime_WorkingHours_PerDay = 4;
        public int MAX_WORKING_HRS = 100;
        public int MAX_WORKING_DAYS = 20;
        public String CompanyName;
    

        public Empwages (String CompanyName, int EmpWagePerHour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHours_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            this.CompanyName = CompanyName;
            this.EmpWagePerHour = EmpWagePerHour;
            this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;
            this.PartTime_WorkingHours_PerDay = PartTime_WorkingHours_PerDay;
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;
            this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;
        }

    }
    class EmployeeWageComputation
    {
        private const int IS_FULL_TIME = 1;
        private const int IS_PART_TIME = 2;
        private const int IS_ABSENT = 0;
        float EmpDailyWage = 0;
        private float TotalWage = 0;
        private Dictionary<String, Empwages> Companies = new Dictionary<String, Empwages>();

        public void AddCompany(String CompanyName, int EmpWagePerHour, int FullTime_WorkingHrs_perDay, int PartTime_WorkingHours_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            Empwages company = new Empwages(CompanyName.ToLower(), EmpWagePerHour, FullTime_WorkingHrs_perDay, PartTime_WorkingHours_PerDay, MAX_WORKING_HRS, MAX_WORKING_DAYS);
            Companies.Add(CompanyName.ToLower(), company);
        }
        private int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }
        public void CalculateEmpWage(string CompanyName)
        {
            int DayNumber = 1;
            int EmpWorkingHrs = 0;
            int TotalWorkingHrs = 0;

            if (!Companies.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("Company dont exist");
            Companies.TryGetValue(CompanyName.ToLower(), out Empwages company);

            while (DayNumber < company.MAX_WORKING_DAYS && TotalWorkingHrs <= company.MAX_WORKING_HRS)
            {

                switch (IsEmployeePresent())
                {
                    case IS_ABSENT:
                        EmpWorkingHrs = 0;
                        break;
                    case IS_PART_TIME:
                        EmpWorkingHrs = company.PartTime_WorkingHours_PerDay;
                        break;
                    case IS_FULL_TIME:
                        EmpWorkingHrs = company.FullTime_WorkingHrs_PerDay;
                        break;
                }
                EmpDailyWage = EmpWorkingHrs * company.EmpWagePerHour;
                TotalWage += EmpDailyWage;
                DayNumber++;
                TotalWorkingHrs += EmpWorkingHrs;
            }
            Console.WriteLine("The Name of the Company : " + CompanyName);
            Console.WriteLine("Total Working Days :" + DayNumber + "  " + "Total Working Hours :" + TotalWorkingHrs + " " + "Total Employee Wage :" + TotalWage);
        }


    }
}
