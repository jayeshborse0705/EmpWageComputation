namespace EmployeeWages
{
    public class Program
    {
        public const float WagesPerHour = 20;
        public const int FullTime_WorkingHrs_PerDay = 8;
        public const int PartTime_WorkingHrs_PerDay = 4;
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int IS_ABSENT = 0;
        public const int Num_WorkingDays_PerMonth = 20;
        public float EmpMonthlyWage = 0;
        float EmpDailyWage = 0;

        public void MonthlyWage()
        {
            int DayNumber = 1;
            int EmpWorkinghrs = 0;
            while (DayNumber <= Num_WorkingDays_PerMonth)
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

                EmpMonthlyWage += EmpDailyWage;
                DayNumber++;

            }
            Console.WriteLine("Employee monthly wage : " + EmpMonthlyWage);

        }
        public static void Main(string[] args)
        {
            Program prg = new Program();
            prg.MonthlyWage();

        }
    }
}