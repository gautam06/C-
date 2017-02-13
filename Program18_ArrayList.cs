using System;

namespace ConsoleApplication1
{
		// ArrayList Demo

    using System.Collections;
    public class Employee
    {
        String ename;
        String desg;
        int salary;

        public void enterEmployeeDetails()
        {
            Console.WriteLine("Enter Employee Name: ");
            ename = Console.ReadLine();
            Console.WriteLine("Enter Employee desg: ");
            desg = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            bool bsalary	= true;
		do
        {
                try { salary = Convert.ToInt32(Console.ReadLine()); }
                catch (Exception e)
                {
                    bsalary = false;
                    Console.WriteLine("Invalid Salary Entered ! Re-enter...");
                }
            }while(bsalary==false);
        }

        public void displayEmployeeData()
        {
            	Console.WriteLine("---------------------------");
                Console.WriteLine("Employee Name: "+ename);
                Console.WriteLine("Employee Designation: "+desg);
                Console.WriteLine("Employee Salary: "+salary);
                Console.WriteLine("---------------------------");
            
        }
    }

    class ArrayListDemo1
    {
        public static void Main(String[] args)
        {

            ArrayList al = new ArrayList();
        int choice = 0;
		do{
		Console.WriteLine("\n\t-: Menu :-");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("1 Insert New Employee Data");
        Console.WriteLine("2 View All Employee Data");
        Console.WriteLine("0 Exit");
        Console.WriteLine("---------------------------------\n");

        Console.WriteLine("Enter your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());
			
			switch(choice){
				case 1:
					Employee e = new Employee();
                    e.enterEmployeeDetails();
					al.Add(e);
					break;				
				case 2:
					Console.WriteLine("\nEmployeeName \tDesignation\t    Salary");
                    Console.WriteLine("\n------------------------------------------------------------");

			        foreach (Employee el in al)
			        {
                        el.displayEmployeeData();
                    }
                    Console.WriteLine("\n------------------------------------------------------------");
					break;
				case 0:
					Console.WriteLine("Have a nice day!");
			        break;
			}
			
		}while(choice!=0);
	
	}
}

    /*Output
    
            -: Menu :-
    --------------------------------
    1 Insert New Employee Data
    2 View All Employee Data
    0 Exit
    ---------------------------------

    Enter your choice:
    1
    Enter Employee Name:
    Gautam
    Enter Employee desg:
    Software Developer
    Enter Employee Salary:
    25000

            -: Menu :-
    --------------------------------
    1 Insert New Employee Data
    2 View All Employee Data
    0 Exit
    ---------------------------------

    Enter your choice:
    1
    Enter Employee Name:
    Shiv
    Enter Employee desg:
    Accountant
    Enter Employee Salary:
    21000

            -: Menu :-
    --------------------------------
    1 Insert New Employee Data
    2 View All Employee Data
    0 Exit
    ---------------------------------

    Enter your choice:
    0
*/
}