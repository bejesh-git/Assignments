using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic.FileIO;

namespace StaticMethos
{
    internal class EmployeeManagement
    {
        public commonServices service;
        public Employee Employee;
        List<Employee> emp = new List<Employee>();

        public EmployeeManagement() 
        {
            service = new commonServices();

            emp.Add(new Employee("Bejesh", 100, "Developer"));
            emp.Add(new Employee("Anbu", 200, "Tester"));
            emp.Add(new Employee("Ajay", 300, "ProjectHead"));

        }
        public void task1()
        {
            string[] menu = { "Display Employees","Add Employee", "Update Employee Detail", "Delete Employee" };
            while(true)
            {    
                string option = service.DisplayMenu(menu);
                

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        DisplayEmployees();
                        break;
                    case "2":
                        Console.Clear();
                        AddEmployee();
                        break;
                    case "3":
                        Console.Clear();
                        UpdateEmployee();
                        break;
                    case "4":
                        Console.Clear();
                        DeleteEmployee();
                        break;
                    case "q":
                        Console.Clear();
                        Console.WriteLine("Closing the Aplication ");
                        goto end;
                    default:
                        Console.WriteLine("Select a valid option or q to close");
                        break;
                }
            }
        end:;
        }

        public void DisplayEmployees()
        {
            if(emp.Count == 0)
            {
                Console.WriteLine("No employee Record Found");
                return;
            }
            for(int i=0; i<emp.Count; i++) 
            {
                Console.Write($"\nEmployee {i + 1} => ");
                Console.Write($"{emp[i].EmpName} {emp[i].EmployeeID} {emp[i].EmpDesignation}");
            }
        }



        private void AddEmployee()
        {
            string name, desig;
            int id;

            name = service.GetInputInTitleCase("Employee Name ");
            id = Convert.ToInt32(service.GetInput("Employee Id "));
            desig = service.GetInputInTitleCase("Employee Designation ");

            Employee = new Employee(name, id, desig);



            if (getIndexById(id) == -1 || emp.Count == 0)
            { 
                emp.Add(Employee);
                Console.WriteLine("\nEmployee Added Successfully");
            }
            else
            {
                Console.WriteLine("\nEmployee Id already Exists");
            }
        }



        public void UpdateEmployee()
        {
            string[] options = { "Name", "Id", "Go back" };
            DisplayEmployees();
        again:
            
            string option = service.DisplayMenu(options, "Search Employee by ");

            if (option.Equals("1"))
            {
                string name = service.GetInputInTitleCase("\nName to search ");
                string desig;
                int id;

                int index = getIndexByName(name);
                if (index == -1)
                {
                    Console.Clear();
                    Console.WriteLine("\nUnable to find the Employee, Try Again (^o^)");
                    goto again;
                }
                else
                {
                    ChangeEmployeeByIndex(index);
                }
            }
            else if(option.Equals("2"))
            {
                int id = Convert.ToInt32(service.GetInputInTitleCase("\nId to search "));

                int index = getIndexById(id);
                if (index == -1)
                {
                    Console.WriteLine("\nUnable to find the Employee, Try Again (^o^)");
                    goto again;
                }
                else
                {
                    ChangeEmployeeByIndex(index);
                }
            }
            else if(option.Equals("3"))
            {
                return;
            }
            else
            {
                Console.WriteLine("\nInvalid Option, Try Again (^o^)\n");
                goto again;
            }
        }



        public void DeleteEmployee()
        {
            string[] options = { "Name", "Id", "Go back" };
            DisplayEmployees();
        again:

            string option = service.DisplayMenu(options, "Delete Employee by ");

            if (option.Equals("1"))
            {
                string name = service.GetInputInTitleCase("\nName to search ");

                int index = getIndexByName(name);

                if (index == -1)
                {
                    Console.Clear();
                    Console.WriteLine("\nUnable to find the Employee, Try Again (^o^)");
                    goto again;
                }
                else
                {
                    DeleteEmployeeByIndex(index);
                }
            }
            else if (option.Equals("2"))
            {
                int id = Convert.ToInt32(service.GetInputInTitleCase("\nId to search "));

                int index = getIndexById(id);
                if (index == -1)
                {
                    Console.WriteLine("\nUnable to find the Employee, Try Again (^o^)");
                    goto again;
                }
                else
                {
                    DeleteEmployeeByIndex(index);
                }
            }
            else if (option.Equals("3"))
            {
                return;
            }
            else
            {
                Console.WriteLine("\nInvalid Option, Try Again (^o^)\n");
                goto again;
            }
        }



        public int getIndexByName(string name)
        {
            for(int i=0; i<emp.Count(); i++)
            {
                if (name.Equals(emp[i].EmpName)){
                    return i;
                }
            }
            return -1;
        }
        public int getIndexById(int id)
        {
            for (int i = 0; i < emp.Count(); i++)
            {
                if (id == emp[i].EmployeeID){
                    return i;
                }
            }
            return -1;
        }

        public void ChangeEmployeeByIndex(int index)
        {
        again:;
            Console.WriteLine("");
            string name = service.GetInputInTitleCase($"Change {emp[index].EmpName} to ");
            int id = Convert.ToInt32(
                service.GetInput($"Change {emp[index].EmployeeID} to ")
                );
            string desig = service.GetInputInTitleCase($"Change {emp[index].EmpDesignation} to ");

            if(getIndexById(id) == -1)
                emp[index] = new Employee(name, id, desig);
            else
            {
                Console.WriteLine("\nId ALready Exists\n");
                string opt = service.GetInput("Try Again (^o^) ? (y/n) ");
                if (opt.Equals("y", StringComparison.OrdinalIgnoreCase))
                    goto again;
                else
                    return;
            }

            Console.WriteLine("\nUpdated Successfully");
        }
        public void DeleteEmployeeByIndex(int index)
        {
            Console.Write($"\nEmployee {index + 1} => ");
            Console.Write($"{emp[index].EmpName} {emp[index].EmployeeID} {emp[index].EmpDesignation}");
            string option = service.GetInput(" Are you sure (y/n): ");
            if (option.Equals("y", StringComparison.OrdinalIgnoreCase))
                emp.RemoveAt(index);
            else
                return;
            Console.WriteLine("\nRemoved Successfully :) ");
        }



    }
}
