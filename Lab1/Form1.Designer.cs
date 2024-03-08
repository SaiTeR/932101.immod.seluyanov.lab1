using System.Windows.Forms.DataVisualization.Charting;

namespace Lab1
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edHeight = new System.Windows.Forms.NumericUpDown();
            this.edAngle = new System.Windows.Forms.NumericUpDown();
            this.edSpeed = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edSize = new System.Windows.Forms.NumericUpDown();
            this.edMass = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.labDistant = new System.Windows.Forms.Label();
            this.labDistance = new System.Windows.Forms.Label();
            this.labSpeed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labHigh = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.dtInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInput)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 94F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 126);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Blue;
            series1.EmptyPointStyle.MarkerSize = 1;
            series1.IsVisibleInLegend = false;
            series1.MarkerBorderWidth = 3;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series2.MarkerBorderColor = System.Drawing.Color.White;
            series2.MarkerBorderWidth = 3;
            series2.MarkerSize = 1;
            series2.Name = "Series2";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series3.Name = "Series3";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series4.Name = "Series4";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series5.Name = "Series5";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series6.Name = "Series6";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series7.Name = "Series7";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(980, 349);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Скорость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Угол";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Высота";
            // 
            // edHeight
            // 
            this.edHeight.Location = new System.Drawing.Point(75, 21);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(120, 20);
            this.edHeight.TabIndex = 4;
            // 
            // edAngle
            // 
            this.edAngle.Location = new System.Drawing.Point(75, 49);
            this.edAngle.Name = "edAngle";
            this.edAngle.Size = new System.Drawing.Size(120, 20);
            this.edAngle.TabIndex = 5;
            this.edAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // edSpeed
            // 
            this.edSpeed.Location = new System.Drawing.Point(75, 80);
            this.edSpeed.Name = "edSpeed";
            this.edSpeed.Size = new System.Drawing.Size(120, 20);
            this.edSpeed.TabIndex = 6;
            this.edSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(442, 21);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(199, 81);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Запустить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Размер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Масса";
            // 
            // edSize
            // 
            this.edSize.DecimalPlaces = 2;
            this.edSize.Location = new System.Drawing.Point(282, 21);
            this.edSize.Name = "edSize";
            this.edSize.Size = new System.Drawing.Size(120, 20);
            this.edSize.TabIndex = 10;
            this.edSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // edMass
            // 
            this.edMass.Location = new System.Drawing.Point(282, 51);
            this.edMass.Name = "edMass";
            this.edMass.Size = new System.Drawing.Size(120, 20);
            this.edMass.TabIndex = 11;
            this.edMass.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Шаг";
            // 
            // labDistant
            // 
            this.labDistant.AutoSize = true;
            this.labDistant.Location = new System.Drawing.Point(696, 51);
            this.labDistant.Name = "labDistant";
            this.labDistant.Size = new System.Drawing.Size(49, 13);
            this.labDistant.TabIndex = 19;
            this.labDistant.Text = "Distance";
            // 
            // labDistance
            // 
            this.labDistance.AutoSize = true;
            this.labDistance.Location = new System.Drawing.Point(853, 51);
            this.labDistance.Name = "labDistance";
            this.labDistance.Size = new System.Drawing.Size(13, 13);
            this.labDistance.TabIndex = 20;
            this.labDistance.Text = "0";
            // 
            // labSpeed
            // 
            this.labSpeed.AutoSize = true;
            this.labSpeed.Location = new System.Drawing.Point(853, 77);
            this.labSpeed.Name = "labSpeed";
            this.labSpeed.Size = new System.Drawing.Size(13, 13);
            this.labSpeed.TabIndex = 21;
            this.labSpeed.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(696, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Speed at the end point";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(696, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Max height";
            // 
            // labHigh
            // 
            this.labHigh.AutoSize = true;
            this.labHigh.Location = new System.Drawing.Point(853, 64);
            this.labHigh.Name = "labHigh";
            this.labHigh.Size = new System.Drawing.Size(13, 13);
            this.labHigh.TabIndex = 24;
            this.labHigh.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(696, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Time step";
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(853, 38);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(13, 13);
            this.labTime.TabIndex = 26;
            this.labTime.Text = "0";
            // 
            // dtInput
            // 
            this.dtInput.DecimalPlaces = 2;
            this.dtInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.dtInput.Location = new System.Drawing.Point(282, 82);
            this.dtInput.Name = "dtInput";
            this.dtInput.Size = new System.Drawing.Size(120, 20);
            this.dtInput.TabIndex = 27;
            this.dtInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 487);
            this.Controls.Add(this.dtInput);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labHigh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labSpeed);
            this.Controls.Add(this.edHeight);
            this.Controls.Add(this.labDistance);
            this.Controls.Add(this.edAngle);
            this.Controls.Add(this.labDistant);
            this.Controls.Add(this.edSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edMass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edSize);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edHeight;
        private System.Windows.Forms.NumericUpDown edAngle;
        private System.Windows.Forms.NumericUpDown edSpeed;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown edSize;
        private System.Windows.Forms.NumericUpDown edMass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labDistant;
        private System.Windows.Forms.Label labDistance;
        private System.Windows.Forms.Label labSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labHigh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.NumericUpDown dtInput;
    }
}

