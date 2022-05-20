namespace EmpWageCompu
{
    public class Program
    {

        public void EmpWage()
        {

        }
        public static void Main(string[] args)
        {
            EmployeeWageComputation empWageComputation = new EmployeeWageComputation();
            empWageComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            empWageComputation.AddCompany("MAHINDRA", 20, 8, 4, 100, 20);
            empWageComputation.CalculateEmpWage("tata");
            empWageComputation.CalculateEmpWage("mahindra");
        }
    }
}