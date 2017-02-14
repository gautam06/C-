using System;

namespace ConsoleApplication4
{
    class Employee
    {
        private int eno = 0;
        private string ename = "x";
        private long salary = 0;

        public int Eno
        {
            get { return eno; }
            set { eno = value; }
        }

        public string Ename
        {
            get { return ename; }
            set { ename = value; }
        }

        public long Salary
        {
            get { return salary; }
            set { salary = value;  }
        }

        public override string ToString()
        {
            return "eno = " + eno + " ename = " + ename + " salary = " + salary;
        }
    }

    class EmployeeDemo
    {
        static void Main()
        {
            Employee e = new Employee();

            e.Eno = 101;
            e.Ename = "Gautam";
            e.Salary = 15000;

            Console.WriteLine("Employee Info : "+e);

            e.Salary += 5000;

            Console.WriteLine("After Increasing Salary");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Employee Info : " + e);

            Console.ReadKey();
        }
    }
    /*Output
        Employee Info : eno = 101 ename = Gautam salary = 15000
        After Increasing Salary
        -------------------------------------
        Employee Info : eno = 101 ename = Gautam salary = 20000

    */
}	