using System;
using System.Collections.Generic;

namespace Task6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            List<Employee> listOfEmployees = new List<Employee>();

            for (int i = 0; i < 5; i++)
            {
                
                listOfEmployees.Add(new Employee("Name"+i,"Worker",200+i));
                listOfEmployees.Add(new Employee("Name"+(i^2+i),"SuperWorker",200+2*i));
                
            }
            //listOfEmployees.Sort((employee, employee1) => employee.CompareTo(employee1));    //with lambda
            listOfEmployees.Sort();  
            //listOfEmployees.Sort(Employee.CompareByPosition);    //compare by position
            // listOfEmployees.Sort(Employee.CompareBySalary); //compare by solary value
            //listOfEmployees.Sort(Employee.CompareByName);    //compare by name

         
            foreach (var employee in listOfEmployees)
            {
                Console.WriteLine(employee);
            }



            

        }
    }
}