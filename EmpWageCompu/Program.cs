namespace EmployeeWages
{
    public class Program
    {
        public int EmpPresent = 1;
        public int EmpHour = 8;
        public int WagesPerHour = 20;
        public int PartTimeEmpHr = 4;
        public int FullTimeEmp = 1;
        public void CheckEmppresentAbsent()
        {
            Random Check = new Random();
            int CheckEmp = Check.Next(0, 2);

            if (EmpPresent == CheckEmp)
            {
                Console.WriteLine("Employee is Present");

                Random TimeCheck = new Random();
                int CheckTimeEmp = TimeCheck.Next(0, 2);

                if (FullTimeEmp == CheckTimeEmp)
                {
                    int DailywageperHour = EmpHour * WagesPerHour;
                    Console.WriteLine("DailyWages is " + DailywageperHour);

                }
                else
                {
                    int DailywageperHour1 = PartTimeEmpHr * WagesPerHour;
                    Console.WriteLine("DailyWages is " + DailywageperHour1);
                }

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public static void Main(string[] args)
        {
            Program prg = new Program();
            prg.CheckEmppresentAbsent();

        }
    }
}