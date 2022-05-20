using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompu
{
    internal class EmpwagesArrayList
    {

        public int EmpWagePerHour;
        public int FullTime_WorkingHrs_PerDay;
        public int PartTime_WorkingHours_PerDay;
        public int MAX_WORKING_HRS;
        public int MAX_WORKING_DAYS;
        public String CompanyName;


        public EmpwagesArrayList (String CompanyName, int EmpWagePerHour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHours_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            this.CompanyName = CompanyName;
            this.EmpWagePerHour = EmpWagePerHour;
            this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;
            this.PartTime_WorkingHours_PerDay = PartTime_WorkingHours_PerDay;
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;
            this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;
        }

    }

    public interface ICompanyEmpWage
    {
        public void AddCompany(string CompanyName, int WagePerHr, int FullHrPerDay, int PartHrPerDay, int MaxWorkHrs, int MaxWorkDays);
        public void WageCalculation(string CompanyName);
    }
    class  EmployeeWageComputation
    {
        private const int IS_FULL_TIME = 1;
        private const int IS_PART_TIME = 2;
        public ArrayList Company_List;
        public int Company_Index = 0;
        public Dictionary<String, EmpwagesArrayList> Companies;

        public EmployeeWageComputation(int Number)
        {
            Companies = new Dictionary<string, EmpwagesArrayList>();
            Company_List = new ArrayList();  

        }

        public void AddCompany(String CompanyName, int EmpWagePerHour, int FullTime_WorkingHrs_perDay, int PartTime_WorkingHours_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            EmpwagesArrayList company = new EmpwagesArrayList (CompanyName.ToLower(), EmpWagePerHour, FullTime_WorkingHrs_perDay, PartTime_WorkingHours_PerDay, MAX_WORKING_HRS, MAX_WORKING_DAYS);
            Companies.Add(CompanyName.ToLower(), company);
            Company_List.Add (CompanyName);
        }

        public int IsEmployeePresent()
        {
            return new Random().Next(1, 3);
        }
        public void CalculateEmpWage(string CompanyName)
        {
            int HrPerDay = 0;
            int WagePerDay = 0;
            int PresentDays = 0;
            int TotalWorkingHrs = 0;
            int MontlyWage = 0;

            if (!Companies.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("Company dont exist");
            Companies.TryGetValue(CompanyName.ToLower(), out EmpwagesArrayList company);

            while (TotalWorkingHrs < company.MAX_WORKING_HRS && PresentDays <= company.MAX_WORKING_DAYS)
            {

                switch (IsEmployeePresent())
                {
                    case IS_PART_TIME:
                        HrPerDay = company.PartTime_WorkingHours_PerDay;
                        PresentDays++;
                        break;
                    case IS_FULL_TIME:
                        HrPerDay = company.FullTime_WorkingHrs_PerDay;
                        PresentDays++;
                        break;
                    default:
                        HrPerDay = 0;
                        break;

                }
                TotalWorkingHrs += HrPerDay;
                WagePerDay = (company.EmpWagePerHour * HrPerDay);
                MontlyWage += WagePerDay;

            }
            Company_List[Company_Index] = Convert.ToString(MontlyWage);
            Company_Index++;

        }
        public void ViewWage()
        {
            for (int i = 0; i < Company_List.Length; i += 2)
            {
                Console.WriteLine("Montly wage for {0} is {1}", Company_List[i], Company_List[i + 1]);
            }
        }



    }
}
