using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            // Тестування базового класу Employee
            Employee employee = new Employee("John Doe", 1000);
            Console.WriteLine("Employee Information:");
            employee.DisplayInfo();
            Console.WriteLine($"Income with k=1.5: {employee.Income(1.5)}");
            Console.WriteLine();

            // Тестування похідного класу Engineer
            Engineer engineer = new Engineer("Jane Smith", 1200, 5);
            Console.WriteLine("Engineer Information:");
            engineer.DisplayInfo();
            Console.WriteLine($"Income with k=1.5: {engineer.Income(1.5)}");

            Console.ReadLine();
        }
    }
}
