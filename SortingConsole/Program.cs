using System;
using System.IO;

namespace SortingConsole
{
    class Program
    {
        const string DATAFILE = "employees.txt";
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[1000];          
            int numberOfPeople = 0;


            try
            {
                StreamReader reader = new StreamReader(DATAFILE);
                while (!reader.EndOfStream)
                {

                    string[] data = reader.ReadLine().Split(',');

                    string name = data[0];
                    int id = int.Parse(data[1].Trim());
                    decimal rate = decimal.Parse(data[2].Trim());
                    double hourly = double.Parse(data[3].Trim());
                    employee[numberOfPeople] = new Employee(name, id, rate, hourly);
                    numberOfPeople++;
                }
                for (int i = 0; i < numberOfPeople; i++)
                {
                    Console.WriteLine(employee[i]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error: " + ex.Message);
            }
            bool running = true;

            while (running)
            {
                Console.Clear();

                Console.Write("Employee          Number    Rate     Hours    Gross Pay             Kien's Company\n"+
                    "===============   ======    =====    =====    ==================    --------------\n"+
                    "1. Sort by Employee Name (ascending)\n"+
                    "2. Sort by Employee Number (ascending)\n"+
                    "3. Sort by Employee Pay Rate (descending)\n"+
                    "4. Sort by Employee Hours (descending)\n"+
                    "5. Sort by Employee Gross Pay (descending)\n"+ 
                    "6. Exit\n"+
                    "Enter choice: ");              
      
                string number = Console.ReadLine();
                double option = double.Parse(number);
                switch (option) 
                {
                    case 1:
                        Array.Sort(employee, new EmployeeNameComparer());
                        
                        break;
                    case 2:
                        Array.Sort(employee, new EmployeeNumberComparer());

                        break;
                    case 3:
                        Array.Sort(employee, new EmployeeRateComparer());
                        break;
                    case 4:
                        Array.Sort(employee, new EmployeeHoursComparer());
                        break;
                    case 5:
                        Array.Sort(employee, new EmployeeGrossComparer());
                        break;
                    case 6:
                        
                        running = false;
                        break;
                    default:
                        Console.Error.WriteLine("Invalid option entered");
                        break;
                }

                for (int i = 0; i < employee.Length; i++)
                {
                    if (employee[i] != null)
                    {
                        Console.WriteLine(employee[i]);
                    }
                }

                Console.Write("\nHit a key to continue ... ");
                Console.ReadKey();
            }
            Console.WriteLine("Bye");
        }
    }
}
