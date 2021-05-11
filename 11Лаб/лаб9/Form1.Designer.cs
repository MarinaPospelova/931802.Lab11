
namespace лаб9
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lb_Prob1 = new System.Windows.Forms.Label();
            this.lb_Prob2 = new System.Windows.Forms.Label();
            this.lb_Prob3 = new System.Windows.Forms.Label();
            this.lb_Prob4 = new System.Windows.Forms.Label();
            this.lb_Prob5 = new System.Windows.Forms.Label();
            this.ed_Prob1 = new System.Windows.Forms.NumericUpDown();
            this.ed_Prob2 = new System.Windows.Forms.NumericUpDown();
            this.ed_Prob3 = new System.Windows.Forms.NumericUpDown();
            this.ed_Prob4 = new System.Windows.Forms.NumericUpDown();
            this.lb_quantity = new System.Windows.Forms.Label();
            this.ed_quantity = new System.Windows.Forms.NumericUpDown();
            this.bt_count = new System.Windows.Forms.Button();
            this.ch_frequency = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tx_prob5 = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ed_Prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed_Prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed_Prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed_Prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Prob1
            // 
            this.lb_Prob1.AutoSize = true;
            this.lb_Prob1.Location = new System.Drawing.Point(31, 38);
            this.lb_Prob1.Name = "lb_Prob1";
            this.lb_Prob1.Size = new System.Drawing.Size(46, 17);
            this.lb_Prob1.TabIndex = 0;
            this.lb_Prob1.Text = "Prob1";
            // 
            // lb_Prob2
            // 
            this.lb_Prob2.AutoSize = true;
            this.lb_Prob2.Location = new System.Drawing.Point(31, 81);
            this.lb_Prob2.Name = "lb_Prob2";
            this.lb_Prob2.Size = new System.Drawing.Size(46, 17);
            this.lb_Prob2.TabIndex = 1;
            this.lb_Prob2.Text = "Prob2";
            // 
            // lb_Prob3
            // 
            this.lb_Prob3.AutoSize = true;
            this.lb_Prob3.Location = new System.Drawing.Point(31, 125);
            this.lb_Prob3.Name = "lb_Prob3";
            this.lb_Prob3.Size = new System.Drawing.Size(46, 17);
            this.lb_Prob3.TabIndex = 2;
            this.lb_Prob3.Text = "Prob3";
            // 
            // lb_Prob4
            // 
            this.lb_Prob4.AutoSize = true;
            this.lb_Prob4.Location = new System.Drawing.Point(31, 169);
            this.lb_Prob4.Name = "lb_Prob4";
            this.lb_Prob4.Size = new System.Drawing.Size(46, 17);
            this.lb_Prob4.TabIndex = 3;
            this.lb_Prob4.Text = "Prob4";
            // 
            // lb_Prob5
            // 
            this.lb_Prob5.AutoSize = true;
            this.lb_Prob5.Location = new System.Drawing.Point(31, 208);
            this.lb_Prob5.Name = "lb_Prob5";
            this.lb_Prob5.Size = new System.Drawing.Size(46, 17);
            this.lb_Prob5.TabIndex = 4;
            this.lb_Prob5.Text = "Prob5";
            // 
            // ed_Prob1
            // 
            this.ed_Prob1.DecimalPlaces = 2;
            this.ed_Prob1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ed_Prob1.Location = new System.Drawing.Point(98, 38);
            this.ed_Prob1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed_Prob1.Name = "ed_Prob1";
            this.ed_Prob1.Size = new System.Drawing.Size(120, 22);
            this.ed_Prob1.TabIndex = 5;
            this.ed_Prob1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed_Prob1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // ed_Prob2
            // 
            this.ed_Prob2.DecimalPlaces = 2;
            this.ed_Prob2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ed_Prob2.Location = new System.Drawing.Point(98, 79);
            this.ed_Prob2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed_Prob2.Name = "ed_Prob2";
            this.ed_Prob2.Size = new System.Drawing.Size(120, 22);
            this.ed_Prob2.TabIndex = 6;
            this.ed_Prob2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed_Prob2.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // ed_Prob3
            // 
            this.ed_Prob3.DecimalPlaces = 2;
            this.ed_Prob3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ed_Prob3.Location = new System.Drawing.Point(98, 125);
            this.ed_Prob3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed_Prob3.Name = "ed_Prob3";
            this.ed_Prob3.Size = new System.Drawing.Size(120, 22);
            this.ed_Prob3.TabIndex = 7;
            this.ed_Prob3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed_Prob3.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // ed_Prob4
            // 
            this.ed_Prob4.DecimalPlaces = 2;
            this.ed_Prob4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ed_Prob4.Location = new System.Drawing.Point(98, 169);
            this.ed_Prob4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed_Prob4.Name = "ed_Prob4";
            this.ed_Prob4.Size = new System.Drawing.Size(120, 22);
            this.ed_Prob4.TabIndex = 8;
            this.ed_Prob4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed_Prob4.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // lb_quantity
            // 
            this.lb_quantity.AutoSize = true;
            this.lb_quantity.Location = new System.Drawing.Point(31, 254);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(194, 17);
            this.lb_quantity.TabIndex = 10;
            this.lb_quantity.Text = "Количество эксперементов:";
            // 
            // ed_quantity
            // 
            this.ed_quantity.Location = new System.Drawing.Point(34, 293);
            this.ed_quantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ed_quantity.Name = "ed_quantity";
            this.ed_quantity.Size = new System.Drawing.Size(184, 22);
            this.ed_quantity.TabIndex = 11;
            this.ed_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed_quantity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // bt_count
            // 
            this.bt_count.Location = new System.Drawing.Point(34, 360);
            this.bt_count.Name = "bt_count";
            this.bt_count.Size = new System.Drawing.Size(184, 49);
            this.bt_count.TabIndex = 12;
            this.bt_count.Text = "ПОСЧИТАТЬ";
            this.bt_count.UseVisualStyleBackColor = true;
            this.bt_count.Click += new System.EventHandler(this.bt_count_Click);
            // 
            // ch_frequency
            // 
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.Name = "ChartArea1";
            this.ch_frequency.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_frequency.Legends.Add(legend1);
            this.ch_frequency.Location = new System.Drawing.Point(325, 38);
            this.ch_frequency.MinimumSize = new System.Drawing.Size(0, 1);
            this.ch_frequency.Name = "ch_frequency";
            this.ch_frequency.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "0.00";
            series1.Legend = "Legend1";
            series1.Name = "Frequency";
            this.ch_frequency.Series.Add(series1);
            this.ch_frequency.Size = new System.Drawing.Size(714, 371);
            this.ch_frequency.TabIndex = 13;
            this.ch_frequency.Text = "frequency";
            title1.Name = "Title1";
            this.ch_frequency.Titles.Add(title1);
            // 
            // tx_prob5
            // 
            this.tx_prob5.Location = new System.Drawing.Point(98, 208);
            this.tx_prob5.Multiline = true;
            this.tx_prob5.Name = "tx_prob5";
            this.tx_prob5.ReadOnly = true;
            this.tx_prob5.Size = new System.Drawing.Size(120, 25);
            this.tx_prob5.TabIndex = 14;
            this.tx_prob5.Text = "auto";
            this.tx_prob5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 458);
            this.Controls.Add(this.tx_prob5);
            this.Controls.Add(this.ch_frequency);
            this.Controls.Add(this.bt_count);
            this.Controls.Add(this.ed_quantity);
            this.Controls.Add(this.lb_quantity);
            this.Controls.Add(this.ed_Prob4);
            this.Controls.Add(this.ed_Prob3);
            this.Controls.Add(this.ed_Prob2);
            this.Controls.Add(this.ed_Prob1);
            this.Controls.Add(this.lb_Prob5);
            this.Controls.Add(this.lb_Prob4);
            this.Controls.Add(this.lb_Prob3);
            this.Controls.Add(this.lb_Prob2);
            this.Controls.Add(this.lb_Prob1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ed_Prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed_Prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed_Prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed_Prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Prob1;
        private System.Windows.Forms.Label lb_Prob2;
        private System.Windows.Forms.Label lb_Prob3;
        private System.Windows.Forms.Label lb_Prob4;
        private System.Windows.Forms.Label lb_Prob5;
        private System.Windows.Forms.NumericUpDown ed_Prob1;
        private System.Windows.Forms.NumericUpDown ed_Prob2;
        private System.Windows.Forms.NumericUpDown ed_Prob3;
        private System.Windows.Forms.NumericUpDown ed_Prob4;
        private System.Windows.Forms.Label lb_quantity;
        private System.Windows.Forms.NumericUpDown ed_quantity;
        private System.Windows.Forms.Button bt_count;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_frequency;
        private System.Windows.Forms.TextBox tx_prob5;
        private System.Windows.Forms.ErrorProvider error;
    }
}

