namespace EmployeeWages
{
    public class Program
    {
        public int EmpHour = 0;
        public int WagesPerHour = 20;
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;

        public int EmpWage()
        {
            Random Check = new Random();
            int CheckEmp = Check.Next(0, 3);

            switch (CheckEmp)
            {
                case IS_PART_TIME:
                    EmpHour = 4;
                    break;
                case IS_FULL_TIME:
                    EmpHour = 8;
                    break;
                default:
                    EmpHour = 0;
                    break;
            }
            int empwage = EmpHour * WagesPerHour;
            return empwage;
        }
        public static void Main(string[] args)
        {
            Program prg = new Program();
            prg.EmpWage();

        }
    }
}