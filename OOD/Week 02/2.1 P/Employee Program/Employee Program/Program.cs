using Employee_Program;

namespace EmployeeProgram
{
    internal class EmployeeProgram
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Kamal", 1000.0);

            emp.setName("Shekaina");
            emp.setSalary(250000);

            Console.WriteLine("Name: " + emp.getName() +
                "\nCurrent Salary: " + emp.getSalary());

            emp.raiseSalary(10);
            Console.WriteLine("Deducted Tax: " + emp.Tax().ToString("C"));

            Console.WriteLine("-------------------------------------------------------------");

            emp.setName("Sudhari");
            emp.setSalary(18000);

            Console.WriteLine("Name: " + emp.getName() +
                "\nCurrent Salary: " + emp.getSalary());

            emp.raiseSalary(10);
            Console.WriteLine("Deducted Tax: " + emp.Tax().ToString("C"));


            Console.ReadLine();
        }
    }
}