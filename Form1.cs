using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        public double f(double x, double y)
        {
            return Math.Sin(x)-y;
        }

        // Кнопки
        private void buttonBuild_Click(object sender, EventArgs e)
        {
            chart.Series["Метод Эйлера"].Points.Clear();
            chart.Series["Метод Рунге–Кутты Мерсона"].Points.Clear();
            chart.Series["Метод Рунге–Кутты Мерсона точки"].Points.Clear();
            chart.Series["Исправленный метод Эйлера"].Points.Clear();
            chart.Series["Метод Адамса 4-го порядка"].Points.Clear();
            chart.Series["Точное решение"].Points.Clear();


            chart.Series["Метод Эйлера"].Enabled = false;
            chart.Series["Метод Рунге–Кутты Мерсона"].Enabled = false;
            chart.Series["Исправленный метод Эйлера"].Enabled = false;
            chart.Series["Метод Адамса 4-го порядка"].Enabled = false;
            chart.Series["Точное решение"].Enabled = false;

            double x0 = 2, y0 = 10;

            if (checkBoxMethodOfEiler.Checked)
            {
                chart.Series["Метод Эйлера"].Enabled = true;
                MethodOfEiler(x0, y0, 0.01, Convert.ToDouble(textBoxEndX.Text));
            }

            if (checkBoxMethodOfRungeKuttaMerson.Checked)
            {
                chart.Series["Метод Рунге–Кутты Мерсона"].Enabled = true;
                MethodOfRungeKuttaMerson(x0, y0, 0.01, Convert.ToDouble(textBoxAccuracy.Text), Convert.ToDouble(textBoxEndX.Text));
            }

            if (checkBoxMethodOfEilerCorrect.Checked)
            {
                chart.Series["Исправленный метод Эйлера"].Enabled = true;
                MethodOfEilerCorrect(x0, y0, 0.01, Convert.ToDouble(textBoxEndX.Text));
            }

            if (checkBoxMethodOfAdams4Order.Checked)
            {
                chart.Series["Метод Адамса 4-го порядка"].Enabled = true;
                MethodOfAdams4Order(x0, y0, 0.01, Convert.ToDouble(textBoxEndX.Text));
            }

            if (checkBoxExactSolution.Checked)
            {
                chart.Series["Точное решение"].Enabled = true;
                exactSolution(x0, y0, 0.01, Convert.ToDouble(textBoxEndX.Text));
            }
        }

        // Методы
        private void MethodOfEiler(double x0, double y0, double h, double xn)
        {
            double y = y0;
            double y_next;

            for (double i = x0; i < xn; i += h)
            {
                chart.Series["Метод Эйлера"].Points.AddXY(i, y);
                y_next = y + h * f(i, y);
                y = y_next;
            }
        }

        private void MethodOfRungeKuttaMerson(double x0, double y0, double h, double ε, double xn)
        {
            double y = y0;
            double y_next;
            double[] k = new double[5];
            double σ;
            for (double i = x0; i < xn; i += h)
            {
                // step 1
            step1:
                k[0] = h * f(i, y);
                k[1] = h * f(i + h/3, y + k[0]/3);
                k[2] = h * f(i + h / 3, y + k[0] / 6 + k[1] / 6);
                k[3] = h * f(i + h / 2, y + k[0] / 8 + k[2] * 3.0 / 8.0);
                k[4] = h * f(i + h, y + k[0] / 2 - k[2] * 3.0 / 2.0 + 2 * k[3]);

                //step 2
                σ = (2 * k[0] - 9 * k[2] + 8 * k[3] - k[4]) / 30;

                //step 3
                if (Math.Abs(σ) >= ε*Math.Abs(y))
                {
                    h /= 2;
                    goto step1;
                }

                //step 4
                chart.Series["Метод Рунге–Кутты Мерсона"].Points.AddXY(i, y);
                chart.Series["Метод Рунге–Кутты Мерсона точки"].Points.AddXY(i, y);
                y_next = y + k[0] / 6 + k[3] * 2 / 3 + k[4] / 6;
                y = y_next;
                
                //step 5
                 if (Math.Abs(σ) <= ε*Math.Abs(y)/32)
                 {
                     h *= 2;
                 }

                //step 6
            }

        }

        private void MethodOfEilerCorrect(double x0, double y0, double h, double xn)
        {
            double y = y0;
            double y_next;

            for (double i = x0; i < xn; i += h)
            {
                chart.Series["Исправленный метод Эйлера"].Points.AddXY(i, y);
                y_next = y + h * (f(i, y) + f(i + h, y + h * f(i, y))) / 2;
                y = y_next;
            }
        }

        private void MethodOfAdams4Order(double x0, double y0, double h, double xn)
        {
            // приближения в 4 первых точках (метод Эйлера)

            double y1 = y0 + h * f(x0, y0),
            y2 = y1 + h * f(x0 + h, y1),
                   y3 = y2 + h * f(x0 + 2 * h, y2);
                 // y4 = y3 + h * f(x0 + 3 * h, y3);
            Console.Write($"{x0} {y0} \n");
            Console.Write($"{x0 + h} {y1} \n");
            Console.Write($"{x0 + 2 * h} {y2} \n");
            Console.Write($"{x0 + 3 * h} {y3} \n");
            chart.Series["Метод Адамса 4-го порядка"].Points.AddXY(x0, y0);
            chart.Series["Метод Адамса 4-го порядка"].Points.AddXY(x0 + h, y1);
            chart.Series["Метод Адамса 4-го порядка"].Points.AddXY(x0 + 2 * h, y2);
         // chart.Series["Метод Адамса 4-го порядка"].Points.AddXY(x0 + 3 * h, y3);
          //chart.Series["Метод Адамса 4-го порядка"].Points.AddXY(x0 + 4 * h, y4);
            double y = y3;
            double y_next;

            for (double i = x0 + 3 * h; i < xn; i += h)
            {
                chart.Series["Метод Адамса 4-го порядка"].Points.AddXY(i, y);
                y_next = y + h * (55 * f(i, y3) - 59 * f(i - h, y2) + 37 * f(i - 2 * h, y1) - 9 * f(i - 3 * h, y0)) / 24;
                Console.Write($"{i} {y} \n");
                y0 = y1;
                y1 = y2;
                y2 = y3;
                y3 = y;
                y = y_next;
            }
        }

        public void exactSolution(double x0, double y0, double h, double xn)
        {
            double y = y0;

            for (double i = x0; i < xn; i += h)
            {
                y = 5 * Math.Exp(-0.5 * i * (i - 2));
                chart.Series["Точное решение"].Points.AddXY(i, y);
            }
            
        }

        // Проверка корректности введенных данных
        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {
            double h, ε, xn;

            if (double.TryParse(textBoxAccuracy.Text, out ε) && double.TryParse(textBoxEndX.Text, out xn))
            {
                buttonBuild.Enabled = true;
            }
            else
            {
                buttonBuild.Enabled = false;
            }
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
