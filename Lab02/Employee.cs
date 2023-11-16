using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class Employee
    {
        private string name;
        private double p; // мінімальна заробітна плата

        public Employee(string name, double p)
        {
            this.name = name;
            this.p = p;
        }

        public string GetName()
        {
            return name;
        }

        public double GetP()
        {
            return p;
        }

        public virtual double Income(double k)
        {
            return k * p;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Minimum Wage: {p}");
        }
    }
}