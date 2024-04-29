using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_14_tabul_wind_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обробник події кліка по кнопці
        private void button1_Click(object sender, EventArgs e)
        {
            //xResults.Items.Clear();
            // Спроба зчитати вхідні дані з текстових полів
            if (!double.TryParse(txtXMin.Text, out double x_min) ||
                !double.TryParse(txtXMax.Text, out double x_max) ||
                !double.TryParse(txtDx.Text, out double dx) ||
                !double.TryParse(txtB.Text, out double b))
            {
                MessageBox.Show("Перевірте, що всі поля заповнені коректними числовими значеннями.");
                return;
            }

            // Перевірка коректності значеннь параметрів
            if (dx <= 0 )
            {
                MessageBox.Show("Переконайтесь, що dx > 0.");
                return;
            }
            if ( x_min >= x_max)
            {
                MessageBox.Show("Переконайтесь, що x_min < x_max.");
                return;
            }

            StringBuilder results = new StringBuilder();
            ResultsForm resultsForm = new ResultsForm();

            

            // Цикл обчислення функції для кожного значення x
            for (double x = x_min; x <= x_max + dx; x += dx)
            {
                try
                {
                    // Виклик функції обчислення
                    double y = CalculateFunction(x, b);
                    //MessageBox.Show($"Для x = {x:F2}, y = {y:F5}");  // Виведення результату для кожного значення 'x'
                    resultsForm.AddToListBox($"Для x = {x:F2}, y = {y:F5}");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show($"Для x = {x:F2}, Помилка: {ex.Message}");  // Виведення помилки для значення 'x'                
                    resultsForm.AddToListBox($"Для x = {x:F2}, Помилка: {ex.Message}");
                }                
            }
            resultsForm.ShowDialog();
        }

        // Функція для обчислення значення функції
        private double CalculateFunction(double x, double b)
        {

            // Перевірка умови, при якій логарифм не може бути обчислений
            if (b - x <= 0)
            {
                throw new Exception("Логарифмічний термін стає невизначеним, бо b-x ≤ 0.");
            }
            // Перевірка умови, при якій функція не може бути обчислена
            if (b - x == 1)
            {
                throw new Exception("Логарифм з одиниці рівний нулю, що призводить до ділення на нуль.");
            }

            // Обчислення двох частин функції
            double part1 = Math.Pow(Math.Sin(b * x) + Math.Cos(x), 1.0 / 3.0); // Обчислення кубічного кореня
            double part2 = (Math.Tan(b * x)) / Math.Log(b - x); // Обчислення дробу з тангенсом та натуральним логарифмом

            return part1 + part2;
        }
    }
}