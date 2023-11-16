using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class Engineer : Employee
    {
        private int n; // кількість розроблених проектів

        public Engineer(string name, double p, int n) : base(name, p)
        {
            this.n = n;
        }

        public int GetN()
        {
            return n;
        }

        public override double Income(double k)
        {
            return base.Income(k) * (1 + n / 10.0);
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Projects: {n}");
        }
    }
}