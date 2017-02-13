using System;

namespace ConsoleApplication1
{
	// Class Example
    public class Employee
    {
        public int id;
        public String name;
        public float salary;
        public void EnterDetails(int i, String n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void DisplayDetails()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
    class TestEmployee
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            e1.EnterDetails(101, "Gautam", 99000f);
            e2.EnterDetails(102, "Vimal", 97000f);
            e1.DisplayDetails();
            e2.DisplayDetails();
            Console.ReadKey();
        }
    }

    /* Output
        101 Gautam 99000
        102 Vimal 97000
    */
}