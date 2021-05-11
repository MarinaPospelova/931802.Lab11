
namespace Лаб9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prob1 = new System.Windows.Forms.NumericUpDown();
            this.prob4 = new System.Windows.Forms.NumericUpDown();
            this.prob3 = new System.Windows.Forms.NumericUpDown();
            this.prob2 = new System.Windows.Forms.NumericUpDown();
            this.prob5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.go = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.check = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Chi_squared = new System.Windows.Forms.TextBox();
            this.Variance = new System.Windows.Forms.TextBox();
            this.Average = new System.Windows.Forms.TextBox();
            this.error_variance = new System.Windows.Forms.TextBox();
            this.error_average = new System.Windows.Forms.TextBox();
            this.check1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prob 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prob 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prob 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prob 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prob 3";
            // 
            // prob1
            // 
            this.prob1.DecimalPlaces = 2;
            this.prob1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.prob1.Location = new System.Drawing.Point(128, 23);
            this.prob1.Name = "prob1";
            this.prob1.Size = new System.Drawing.Size(120, 26);
            this.prob1.TabIndex = 5;
            // 
            // prob4
            // 
            this.prob4.DecimalPlaces = 2;
            this.prob4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.prob4.Location = new System.Drawing.Point(128, 181);
            this.prob4.Name = "prob4";
            this.prob4.Size = new System.Drawing.Size(120, 26);
            this.prob4.TabIndex = 7;
            // 
            // prob3
            // 
            this.prob3.DecimalPlaces = 2;
            this.prob3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.prob3.Location = new System.Drawing.Point(128, 127);
            this.prob3.Name = "prob3";
            this.prob3.Size = new System.Drawing.Size(120, 26);
            this.prob3.TabIndex = 8;
            // 
            // prob2
            // 
            this.prob2.DecimalPlaces = 2;
            this.prob2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.prob2.Location = new System.Drawing.Point(128, 75);
            this.prob2.Name = "prob2";
            this.prob2.Size = new System.Drawing.Size(120, 26);
            this.prob2.TabIndex = 9;
            // 
            // prob5
            // 
            this.prob5.Location = new System.Drawing.Point(128, 231);
            this.prob5.Name = "prob5";
            this.prob5.Size = new System.Drawing.Size(100, 26);
            this.prob5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(353, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number of experements";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(408, 62);
            this.number.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(120, 26);
            this.number.TabIndex = 12;
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.DodgerBlue;
            this.go.ForeColor = System.Drawing.Color.LightCyan;
            this.go.Location = new System.Drawing.Point(649, 23);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(120, 74);
            this.go.TabIndex = 13;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 263);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "freq";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(864, 464);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check.ForeColor = System.Drawing.Color.DarkBlue;
            this.check.Location = new System.Drawing.Point(798, 43);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(28, 29);
            this.check.TabIndex = 15;
            this.check.Text = "q";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Average";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Chi_squared";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Variance";
            // 
            // Chi_squared
            // 
            this.Chi_squared.Location = new System.Drawing.Point(442, 198);
            this.Chi_squared.Name = "Chi_squared";
            this.Chi_squared.Size = new System.Drawing.Size(100, 26);
            this.Chi_squared.TabIndex = 19;
            // 
            // Variance
            // 
            this.Variance.Location = new System.Drawing.Point(442, 165);
            this.Variance.Name = "Variance";
            this.Variance.Size = new System.Drawing.Size(100, 26);
            this.Variance.TabIndex = 20;
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(442, 129);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(100, 26);
            this.Average.TabIndex = 21;
            // 
            // error_variance
            // 
            this.error_variance.Location = new System.Drawing.Point(618, 165);
            this.error_variance.Name = "error_variance";
            this.error_variance.Size = new System.Drawing.Size(100, 26);
            this.error_variance.TabIndex = 22;
            // 
            // error_average
            // 
            this.error_average.Location = new System.Drawing.Point(618, 129);
            this.error_average.Name = "error_average";
            this.error_average.Size = new System.Drawing.Size(100, 26);
            this.error_average.TabIndex = 23;
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(614, 204);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(17, 20);
            this.check1.TabIndex = 24;
            this.check1.Text = "c";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1180, 756);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.error_average);
            this.Controls.Add(this.error_variance);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Variance);
            this.Controls.Add(this.Chi_squared);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.check);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.go);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prob5);
            this.Controls.Add(this.prob2);
            this.Controls.Add(this.prob3);
            this.Controls.Add(this.prob4);
            this.Controls.Add(this.prob1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown prob1;
        private System.Windows.Forms.NumericUpDown prob4;
        private System.Windows.Forms.NumericUpDown prob3;
        private System.Windows.Forms.NumericUpDown prob2;
        private System.Windows.Forms.TextBox prob5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label check;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Chi_squared;
        private System.Windows.Forms.TextBox Variance;
        private System.Windows.Forms.TextBox Average;
        private System.Windows.Forms.TextBox error_variance;
        private System.Windows.Forms.TextBox error_average;
        private System.Windows.Forms.Label check1;
    }
}

