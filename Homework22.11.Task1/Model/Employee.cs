namespace Homework22._11.Task1.Model
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string surname, DateTime birthday, double salary)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Salary = salary;
        }

        public static int GetEmployeeCount(Employee[] employees,DateTime Startdate, DateTime Enddate)
        {
            int count = 0;
            foreach (var employee in employees)
            {
                if (employee.Birthday >= Startdate && employee.Birthday <= Enddate && employee.Salary>2000)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
