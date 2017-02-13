using System;

namespace ConsoleApplication1
{
    // Example of Structure

    public struct Employee
    {
        public int eno;
        public string ename;
        public int salary;

        public void EnterEmployeeDetails()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Enter Employee Number: ");
            eno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            ename = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        
        public void displayValues()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine(eno);
            Console.WriteLine(ename);
            Console.WriteLine(salary);
            Console.WriteLine("------------------------------");
        }
    };

    public class TestEmployee
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("How many records you want to insert: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Employee[] E = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                E[i] = new Employee();

                E[i].EnterEmployeeDetails();
            }

            Console.WriteLine("Display Employee Records");

            foreach (Employee x in E)
            {
                x.displayValues();
            }

            Console.ReadKey();
        }
         
    }


    /*Output

    How many records you want to insert:
    2
    ------------------------------
    Enter Employee Number:
    1
    Enter Employee Name:
    Gautam
    Enter Employee Salary:
    25000
    ------------------------------
    Enter Employee Number:
    2
    Enter Employee Name:
    Chintan
    Enter Employee Salary:
    28000
    Display Employee Records
    ------------------------------
    1
    Gautam
    25000
    ------------------------------
    ------------------------------
    2
    Chintan
    28000
    ------------------------------
    */
	
	}
}