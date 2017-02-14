using System;
using System.Collections;

namespace ConsoleApplication3
{
        class Program
        {
            static void Main(string[] args)
            {
                SortedList sl = new SortedList();

                int ch = 0;
                int rno;
                string name;
                do
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("1 For Insert New Record");
                    Console.WriteLine("2 For Display Record");
                    Console.WriteLine("3 For Check Student Exist");
                    Console.WriteLine("0 For Exit");
                    Console.WriteLine("-----------------------");
                    ch = Convert.ToInt32(Console.ReadLine());

                    switch (ch)
                    {
                            case 1:
                                Console.Write("Enter RollNo: ");
                                rno = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Name: ");
                                name = Console.ReadLine();
                                sl.Add(rno,name);                            
                                break;
                            case 2:
                                ICollection key = sl.Keys;
                                Console.WriteLine("\nAll Records");
                                Console.WriteLine("---------------------------");
                                foreach (int k in key)
                                {
                                    Console.WriteLine(k+" : "+sl[k]);
                                }
                                Console.WriteLine("---------------------------");
                        break;
                            case 3:
                                Console.Write("Enter Rollno: ");
                                rno = Convert.ToInt32(Console.ReadLine());

                                if (sl.Contains(rno)) Console.WriteLine(rno+" Exist "); 
                                else Console.WriteLine(rno+" Not Exist");
                                
                                break;
                            case 0:
                                Console.WriteLine("Have a nice day !");
                                break;
                    }
            } while (ch != 0);
            }
        }
}
    /* Output
			Menu
            -----------------------
            1 For Insert New Record
            2 For Display Record
            3 For Check Student Exist
            0 For Exit
            -----------------------
            1
            Enter RollNo: 1
            Enter Name: Gautam
            Menu
            -----------------------
            1 For Insert New Record
            2 For Display Record
            3 For Check Student Exist
            0 For Exit
            -----------------------
            1
            Enter RollNo: 2
            Enter Name: Shyam
            Menu
            -----------------------
            1 For Insert New Record
            2 For Display Record
            3 For Check Student Exist
            0 For Exit
            -----------------------
            2

            All Records
            ---------------------------
            1 : Gautam
            2 : Shyam
            ---------------------------
            Menu
            -----------------------
            1 For Insert New Record
            2 For Display Record
            3 For Check Student Exist
            0 For Exit
            -----------------------
            3
            Enter Rollno: 1
            1 Exist
            Menu
            -----------------------
            1 For Insert New Record
            2 For Display Record
            3 For Check Student Exist
            0 For Exit
            -----------------------
            0
    */