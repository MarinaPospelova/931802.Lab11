using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб9
{
    public partial class Form1 : Form
    {
        Statistical_processing SP = new Statistical_processing();
        public Form1()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {
            if ((prob1.Value + prob2.Value + prob3.Value + prob4.Value) > 1M)
            {
                check.Text = "Ошибка нормировки";
            }
            else
            {
                check.Text = "Все прошло успешно";
                SP.SetData((int)number.Value, prob1.Value, prob2.Value, prob3.Value, prob4.Value);
                chart1.Series[0].Points.Clear();
                decimal[] pointsY = SP.GetData();
                for (int i = 0; i < pointsY.Length; i++)
                { 
                    chart1.Series[0].Points.AddXY(i + 1, pointsY[i]);
                }
                prob5.Text = Convert.ToString(1M - (prob1.Value + prob2.Value + prob3.Value + prob4.Value));

                decimal average = 0;
                decimal variance = 0;
                decimal E = 0;
                decimal D = 0;
                decimal error_ave;
                decimal error_var;
                decimal chi_squared = 0;

                for (int i = 0; i < SP.size; i++)
                {
                    average += pointsY[i] * (i + 1);
                    variance += pointsY[i] * (i + 1) * (i + 1);
                    E += SP.prob[i] * (i + 1);
                    D += SP.prob[i] * (i + 1) * (i + 1);
                    chi_squared += (SP.statistics[i] * SP.statistics[i]) / (SP.N * SP.prob[i]);
                }
                D -= E * E;
                variance -= average * average;
                error_var = Decimal.Round(Math.Abs((variance - D) / E) * 100);
                error_ave = Decimal.Round(Math.Abs((average - E) / D) * 100);
                chi_squared -= SP.N;
                Average.Text = average.ToString();
                Variance.Text = variance.ToString();
                error_average.Text = Convert.ToString(error_ave);
                error_variance.Text = Convert.ToString(error_var);
                if (chi_squared > 9.488M)
                {
                    Chi_squared.Text = Convert.ToString(Decimal.Round(chi_squared, 2)) + "> 9,488";
                    check1.Text = "Гипотеза неверна";
                }
                else
                {
                    Chi_squared.Text = Convert.ToString(Decimal.Round(chi_squared, 2)) + "< 9,488";
                    check1.Text = "Гипотеза верна";
                }
            }
        }
       
    }
    public class Statistical_processing
    {
        Random rnd = new Random();
        public int N;
        public int[] statistics;
        public decimal[] prob;
        public int size;
        public void SetData(int N, params decimal[] m)
        {
            size = m.Length + 1;
            prob = new decimal[m.Length + 1];
            this.N = N;
            statistics = new int[m.Length + 1];
            statistics[m.Length] = 0;
            for (int i = 0; i < m.Length; i++)
            {
                prob[i] = m[i];
                statistics[i] = 0;
            }
            prob[m.Length] = 1 - prob[0] - prob[1] - prob[2] - prob[3];
        }
        public decimal[] GetData()
        {
            decimal A;
            int k = -1;
            decimal[] freq = new decimal[statistics.Length];
            for (int i = 0; i < N; i++)
            {
                A = (decimal)rnd.NextDouble();
                for (k = -1; A > 0; k++)
                {
                    A -= prob[k + 1];
                }
                statistics[k]++;
            }
            for (int i = 0; i < statistics.Length; i++)
            {
                freq[i] = (decimal)statistics[i] / N;
            }
            return freq;
        }
    }
}
