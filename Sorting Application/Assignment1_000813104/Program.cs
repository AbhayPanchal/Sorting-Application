using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

/// <summary>
///  I, Abhay Panchal, 000813104 certify that this material is my original work.  
///  No other person's work has been used without due acknowledgement.(SEP : 2020)
/// </summary>

namespace Assignment1_000813104
{   
    /// <summary>
    /// Program class which has various methods which help application to execute properly.
    /// It has Read method which read the data from Employee.csv file and also handle the exceptions.
    /// Various SelectionSort methods which sort the data in many ways.
    /// 
    /// </summary>
    class Program
    {   
        /// <summary>
        /// Main method output data to console and take input from user.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Employee[] employees = Read("Employee.csv"); //Read() method with Employee array 

            bool running = true;
            while (running)//while loop
            {
                Console.WriteLine("[1] Sort by Employee Name: \n" +
                                  "[2] Sort by Employee Number: \n" +
                                  "[3] Sort by Employee Pay Rate: \n" +
                                  "[4] Sort by Employee Hours: \n" +
                                  "[5] Sort by Employee Gross Pay: \n\n" +
                                  "[6] Exit: \n"); 

                Console.WriteLine("ENTER OPTION: ");


                try
                {
                    int input = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case 1:

                            Console.WriteLine("Employee           Number   Rate     Hours   Gross Pay                Nick's Company");
                            Console.WriteLine("==============     ======   =====    =====   =========                --------------");

                            SelectionSortName(employees); // SelectionSortName method sort employees with names(ascending)
                            foreach (Employee e in employees)
                            {
                                Console.WriteLine(e);
                            }
                            Console.WriteLine("\n");
                            break;
                        case 2:
                            Console.WriteLine("Employee           Number   Rate     Hours   Gross Pay                Nick's Company");
                            Console.WriteLine("==============     ======   =====    =====   =========                --------------");

                            SelectionSortNumber(employees);// SelectionSortNumber method sort employees with number(ascending)
                            foreach (Employee e in employees)
                            {
                                Console.WriteLine(e);
                            }
                            Console.WriteLine("\n");
                            break;
                        case 3:
                            Console.WriteLine("Employee           Number   Rate     Hours   Gross Pay                Nick's Company");
                            Console.WriteLine("==============     ======   =====    =====   =========                --------------");

                            SelectionSortPayRate(employees);// SelectionSortPayRate method sort employees with rate(decending)
                            foreach (Employee e in employees)
                            {
                                Console.WriteLine(e);
                            }
                            Console.WriteLine("\n");
                            break;
                        case 4:

                            Console.WriteLine("Employee           Number   Rate     Hours   Gross Pay                Nick's Company");
                            Console.WriteLine("==============     ======   =====    =====   =========                --------------");

                            SelectionSortHours(employees);// SelectionSortHours method sort employees with hours(decending)
                            foreach (Employee e in employees)
                            {
                                Console.WriteLine(e);
                            }

                            Console.WriteLine("\n");
                            break;
                        case 5:

                            Console.WriteLine("Employee           Number   Rate     Hours   Gross Pay                Nick's Company");
                            Console.WriteLine("==============     ======   =====    =====   =========                --------------");

                            SelectionSortGross(employees);// SelectionSortGross method sort employees with grosspay(decending)
                            foreach (Employee e in employees)
                            {
                                Console.WriteLine(e);
                            }
                            Console.WriteLine("\n");

                            break;
                        case 6:
                            running = false;
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.Error.WriteLine("*** INVALID CHOICE - TRY AGAIN ***\n\n");
                }
            }
        }

        /// <summary>
        /// Read method which read the data from text file
        /// </summary>
        /// <param name="filename">name of file </param>
        /// <returns>null</returns>
        public static Employee[] Read(string filename)
        {
            Employee[] employees = new Employee[100]; //Employee array 
            int employeeCount = 0;

            try
            {
                StreamReader reader = new StreamReader(filename);
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] employeeName = line.Split(',');//split with (,)

                    employees[employeeCount] = new Employee(employeeName[0], int.Parse(employeeName[1]), decimal.Parse(employeeName[2]), double.Parse(employeeName[3]));

                    employeeCount++;
                }
                Array.Resize(ref employees, employeeCount);// truncate the array in correct size
                return employees;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            return null;
        }

        /// <summary>
        /// SelectionSortName method which sort the data in acending order with name
        /// In this method during first for loop it takes first value from array and the it enters to the second for loop and compare that first value 
        /// with all value of the array during this if it find any value lower than the firstvalue it swap in between and the loop countinues and at the and 
        /// the array get sorted according to the conditions (acending or decending)
        /// 
        /// Cite: https://www.tutorialspoint.com/selection-sort-program-in-chash
        /// </summary>
        /// <param name="employees"> Employees's name</param>
        public static void SelectionSortName(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (employees[j].GetName().ToLower().CompareTo(employees[min].GetName().ToLower()) < 0)
                    {
                        min = j;
                        
                    }
                }
                Employee temp = employees[i];
                employees[i] = employees[min];
                employees[min] = temp;
            }
        }
        /// <summary>
        /// Sort method which sort the data in acending order with numbers
        /// </summary>
        /// <param name="employees"> Employees' number</param>
        public static void SelectionSortNumber(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (employees[j].GetNumber().CompareTo(employees[min].GetNumber()) < 0)
                    {
                        min = j;

                    }
                }

                Employee temp = employees[i];
                employees[i] = employees[min];
                employees[min] = temp;
            }
        }

        /// <summary>
        /// Sort method which sort the data in decending order with employee's pay rate 
        /// </summary>
        /// <param name="employees"> Employee's pay rate</param>
        public static void SelectionSortPayRate(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (employees[j].GetRate().CompareTo(employees[min].GetRate()) > 0)
                    {
                        min = j;

                    }
                }

                Employee temp = employees[i];
                employees[i] = employees[min];
                employees[min] = temp;
            }
        }

        /// <summary>
        /// Sort method which sort the data in decending order with employee's working hours
        /// </summary>
        /// <param name="employees"> Employee's worked hours</param>
        public static void SelectionSortHours(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (employees[j].GetHours().CompareTo(employees[min].GetHours()) > 0)
                    {
                        min = j;

                    }
                }

                Employee temp = employees[i];
                employees[i] = employees[min];
                employees[min] = temp;
            }
        }

        /// <summary>
        /// Sort method which sort the data in decending order with employee's gross pay 
        /// </summary>
        /// <param name="employees"> Employee's gross paye</param>

        public static void SelectionSortGross(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (employees[j].GetGross().CompareTo(employees[min].GetGross()) > 0)
                    {
                        min = j;

                    }
                }

                Employee temp = employees[i];
                employees[i] = employees[min];
                employees[min] = temp;
            }
        }

    }
}
