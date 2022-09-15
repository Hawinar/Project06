using System;
using System.Windows.Forms;

namespace Project06
{
    /// <summary>
    /// 3.2 Лабораторная работа № 2. Тема: «Стиль программирования» Вариант № 22 https://github.com/Hawinar
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            int[] numbers = new int[20];
            int[] intervals = new int[10];
            Random rnd = new Random();

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 11);
            }

            for(int j = 0; j < intervals.Length;)
            {
                for(int k = 0; k < numbers.Length; k += 2)
                {
                    if(numbers[k] <= numbers[k + 1])
                    {
                        intervals[j] = numbers[k + 1] - numbers[k];
                        j++;
                    }
                    else
                    {
                        intervals[j] = numbers[k] - numbers[k + 1];
                        j++;
                    }
                }
            }
            float avgNumber = 0;
            for(int l = 0; l<intervals.Length; l++)
            {
                avgNumber += intervals[l];
            }
            avgNumber /= intervals.Length;
            lbAvgNum.Text = $"Среднее число: {avgNumber}";
            Array.Sort(intervals);
            for(int i = 0; i < intervals.Length; i++)
            {
                chart1.Series[0].Points.Add(intervals[i]);
            }
        }
    }
}
