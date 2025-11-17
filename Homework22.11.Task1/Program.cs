using Homework22._11.Task1.Model;

namespace Homework22._11.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Employee[] employees =
            //    {
            //        new Employee("John", "Doe", new DateTime(1990, 5, 15), 2500),
            //        new Employee("Jane", "Smith", new DateTime(1985, 8, 22), 1800),
            //        new Employee("Alice", "Johnson", new DateTime(1992, 3, 10), 3000),
            //        new Employee("Bob", "Brown", new DateTime(1978, 12, 5), 2200),
            //        new Employee("Charlie", "Davis", new DateTime(2000, 7, 30), 1500)
            //    };

            //    DateTime startDate = new DateTime(1980, 1, 1);
            //    DateTime endDate = new DateTime(2000, 12, 31);

            //Console.WriteLine(Employee.GetEmployeeCount(employees, startDate, endDate));

            Console.WriteLine("How many employees you would like to enter?: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Employee[] employees = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter details for employee {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Surname: ");
                string surname = Console.ReadLine();
                Console.Write("Birthday (yyyy-MM-dd): ");
                DateTime birthday = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                employees[i] = new Employee(name, surname, birthday, salary);
            }

            Console.WriteLine("\nEnter the start date (yyyy-MM-dd): ");
            DateTime startDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the end date (yyyy-MM-dd): ");
            DateTime endDate = Convert.ToDateTime(Console.ReadLine());
            int count = Employee.GetEmployeeCount(employees, startDate, endDate);
            Console.WriteLine($"\nNumber of employees born between {startDate.ToShortDateString()} and {endDate.ToShortDateString()} with salary greater than 2000 is {count}");

        }
    }
}
