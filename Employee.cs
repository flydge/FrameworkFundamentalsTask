﻿using System;

namespace Task6
{
    public class Employee: IComparable<Employee>
    {
        private string name;
        private string position;
        private int salaryValue;

        public Employee()
        {
        }

        public Employee(string name, string position, int salaryValue)
        {
            this.name = name;
            this.position = position;
            this.salaryValue = salaryValue;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Position
        {
            get => position;
            set => position = value;
        }

        public int SalaryValue
        {
            get => salaryValue;
            set => salaryValue = value;
        }
        
        

        public static int CompareBySalary(Employee em1, Employee em2)
        {
            return em1.salaryValue - em2.salaryValue;
        }
        
        public static int CompareByName(Employee em1, Employee em2)
        {
            return String.Compare( em1.name, em2.name, StringComparison.Ordinal);
        }
        
        public static int CompareByPosition(Employee em1, Employee em2)
        {
            return String.Compare( em1.position, em2.position, StringComparison.Ordinal);
        }
        
        
        

        public override string ToString()
        {
            return String.Format("name:{0,-15} position:{1,-15} salary:{2,-10}",name,position,salaryValue);
        }


        public int CompareTo(Employee other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var nameComparison = string.Compare(name, other.name, StringComparison.Ordinal);
            if (nameComparison != 0) return nameComparison;
            var positionComparison = string.Compare(position, other.position, StringComparison.Ordinal);
            if (positionComparison != 0) return positionComparison;
            return salaryValue.CompareTo(other.salaryValue);
        }
    }
}