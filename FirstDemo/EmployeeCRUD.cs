using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    // Model class for Employee
    class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary:C}";
        }
    }

    // Business Logic class for CRUD operations on Employee
    class EmployeeManager
    {
        private List<Employees> employees = new List<Employees>();

        public void AddEmployee(Employees employee)
        {
            employees.Add(employee);
            Console.WriteLine("Employee added successfully!");
        }

        public void UpdateEmployee(int id, Employees updatedEmployee)
        {
            int index = employees.FindIndex(emp => emp.Id == id);
            if (index != -1)
            {
                employees[index] = updatedEmployee;
                Console.WriteLine("Employee updated successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
        }

        public void DeleteEmployee(int id)
        {
            Employees employee = employees.Find(emp => emp.Id == id);
            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine("Employee deleted successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
        }

        public void DisplayEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees to display.");
            }
            else
            {
                Console.WriteLine("Employee Details:");
                foreach (Employees employee in employees)
                {
                    Console.WriteLine(employee);
                }
            }
        }
    }
    public class EmployeeCRUD
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            while (true)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Display Employees");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Employee Id: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Employee Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Employee Salary: ");
                        double salary = double.Parse(Console.ReadLine());
                        employeeManager.AddEmployee(new Employees(id, name, salary));
                        break;
                    case 2:
                        Console.Write("Enter Employee Id to update: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Updated Employee Name: ");
                        string updatedName = Console.ReadLine();
                        Console.Write("Enter Updated Employee Salary: ");
                        double updatedSalary = double.Parse(Console.ReadLine());
                        employeeManager.UpdateEmployee(updateId, new Employees(updateId, updatedName, updatedSalary));
                        break;
                    case 3:
                        Console.Write("Enter Employee Id to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        employeeManager.DeleteEmployee(deleteId);
                        break;
                    case 4:
                        employeeManager.DisplayEmployees();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
