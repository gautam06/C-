// CompositionDemo

using System;

namespace ConsoleApplication1
{
	class Job
    {

        private String role;
        private long salary;
        private int id;

        public String getRole() { return role; }

        public void setRole(String role) { this.role = role; }

        public long getSalary() { return salary; }

        public void setSalary(long salary) { this.salary = salary; }

        public int getId() { return id; }

        public void setId(int id) { this.id = id; }

    }

    class Person
    {

        //composition has-a relationship 
        private Job job;

        public Person()
        {
            this.job = new Job();
            job.setSalary(10000);
        }

        public long getSalary() { return job.getSalary(); }

    }

    public class CompositionDemo
    {

        public static void Main(String[] args)
        {
            Person person = new Person();
            long salary = person.getSalary();
            Console.WriteLine("Person Salary: " + salary);
            Console.ReadKey();
        }
    }

    /*Output
        Person Salary: 10000
    */
}