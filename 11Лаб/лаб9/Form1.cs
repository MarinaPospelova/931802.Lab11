using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаб9
{
    public partial class Form1 : Form
    {
        Calculate calculate = new Calculate();

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_count_Click(object sender, EventArgs e)
        {
            if ((1 - ed_Prob1.Value) < ed_Prob2.Value)
            {
                error.SetError(ed_Prob2, "Проверьте введеные значения, их сумма должна быть <=1");
            }
            else
            {
                error.SetError(ed_Prob2, null);
            }
            if ((1 - ed_Prob1.Value- ed_Prob2.Value) < ed_Prob3.Value)
            {
                error.SetError(ed_Prob3, "Проверьте введеные значения, их сумма должна быть <=1");
            }
            else
            {
                error.SetError(ed_Prob3, null);
            }
            if ((1 - ed_Prob1.Value - ed_Prob2.Value - ed_Prob3.Value) < ed_Prob4.Value)
            {
                error.SetError(ed_Prob4, "Проверьте введеные значения, их сумма должна быть <=1");
                return;
            }
            else
            {
                error.SetError(ed_Prob4, null);
            }
            calculate.CreateArray((int)ed_quantity.Value, ed_Prob1.Value, ed_Prob2.Value, ed_Prob3.Value, ed_Prob4.Value);
            tx_prob5.Text = Convert.ToString(calculate.probability[4]);
            ch_frequency.Series[0].Points.Clear();
            decimal[] pointsY = calculate.GetFrequency();
            for (int i = 0; i < pointsY.Length; i++)
            ch_frequency.Series[0].Points.AddXY(i+1, pointsY[i]);
        }
    }

    public class Calculate
    {
        Random rnd = new Random();
        int N;
        public int[] statistic;
        public decimal[] probability;      

        public void CreateArray (int N, params decimal[] p)
        {
            int size = p.Length + 1;
            probability = new decimal[size];
            this.N = N;
            statistic = new int[size];
            for (int i = 0; i < size-1; i++)
            {
                probability[i] = p[i];
                statistic[i] = 0;
            }
            statistic[size-1] = 0;
            probability[size - 1] = 1 - probability[0]- probability[1]- probability[2]- probability[3];
        }


        private int GenerateEvent()
        {
            decimal a = rnd.Next(0, 10);
            a /= 10;
            int k = -1;
            do
            {
                k++;
                a -= probability[k];
            } while (a >= 0.001m);
            return k;
        }

        public decimal[] GetFrequency()
        {
            decimal[] frequency = new decimal[statistic.Length];
            for (int i = 0; i < N; i++)
            {
                statistic[GenerateEvent()]++;
            }
            for (int i = 0; i < statistic.Length; i++)
            {
                frequency[i] = (decimal)statistic[i] / N;
            }
            return frequency;
        }
    }
 }
