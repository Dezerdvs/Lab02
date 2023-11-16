using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string name = textBox6.Text;
                double minimumWage = double.Parse(textBox5.Text);
                int numberOfProjects = int.Parse(textBox7.Text);

                Engineer engineer = new Engineer(name, minimumWage, numberOfProjects);

                double k = double.Parse(textBox4.Text);

                double income = engineer.Income(k);
                MessageBox.Show($"Зарплата Інженера:{income} тубриков");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double minimumWage = double.Parse(textBox2.Text);

            Employee employee = new Employee(name, minimumWage);

            double k = double.Parse(textBox3.Text);

            double income = employee.Income(k);
            MessageBox.Show($"Зарплата Робітника:{income} тубриков");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
