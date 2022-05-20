namespace EmployeeWages
{
    public class Program
    {
        public int EmpPresent = 1;
        public int EmpHour = 8;
        public int WagesPerHour = 20;
        public void CheckEmppresentAbsent()
        {
            Random Check = new Random();
            int CheckEmp = Check.Next(0, 2);

            if (EmpPresent == CheckEmp)
            {
                Console.WriteLine("Employee is Present");
                int DailywageperHour = EmpHour * WagesPerHour;
                Console.WriteLine("DailyWages is " + DailywageperHour);
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
