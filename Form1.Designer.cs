namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAccuracy = new System.Windows.Forms.TextBox();
            this.checkBoxMethodOfEiler = new System.Windows.Forms.CheckBox();
            this.checkBoxMethodOfRungeKuttaMerson = new System.Windows.Forms.CheckBox();
            this.checkBoxMethodOfEilerCorrect = new System.Windows.Forms.CheckBox();
            this.checkBoxMethodOfAdams4Order = new System.Windows.Forms.CheckBox();
            this.checkBoxExactSolution = new System.Windows.Forms.CheckBox();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.textBoxEndX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea4.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea4);
            legend4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            legend4.Position.Auto = false;
            legend4.Position.Height = 14.84375F;
            legend4.Position.Width = 28.66109F;
            legend4.Position.X = 68.33891F;
            legend4.Position.Y = 3F;
            this.chart.Legends.Add(legend4);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series19.Legend = "Legend1";
            series19.Name = "Метод Эйлера";
            series19.YValuesPerPoint = 2;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Legend = "Legend1";
            series20.Name = "Точное решение";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Legend = "Legend1";
            series21.Name = "Метод Рунге–Кутты Мерсона";
            series22.BorderWidth = 3;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series22.Legend = "Legend1";
            series22.Name = "Метод Рунге–Кутты Мерсона точки";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Legend = "Legend1";
            series23.Name = "Исправленный метод Эйлера";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Legend = "Legend1";
            series24.Name = "Метод Адамса 4-го порядка";
            series24.YValuesPerPoint = 2;
            this.chart.Series.Add(series19);
            this.chart.Series.Add(series20);
            this.chart.Series.Add(series21);
            this.chart.Series.Add(series22);
            this.chart.Series.Add(series23);
            this.chart.Series.Add(series24);
            this.chart.Size = new System.Drawing.Size(524, 399);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Точность:";
            // 
            // textBoxAccuracy
            // 
            this.textBoxAccuracy.Location = new System.Drawing.Point(664, 11);
            this.textBoxAccuracy.Name = "textBoxAccuracy";
            this.textBoxAccuracy.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccuracy.TabIndex = 4;
            this.textBoxAccuracy.Text = "0,01";
            this.textBoxAccuracy.TextChanged += new System.EventHandler(this.textBoxValue_TextChanged);
            // 
            // checkBoxMethodOfEiler
            // 
            this.checkBoxMethodOfEiler.AutoSize = true;
            this.checkBoxMethodOfEiler.Location = new System.Drawing.Point(551, 74);
            this.checkBoxMethodOfEiler.Name = "checkBoxMethodOfEiler";
            this.checkBoxMethodOfEiler.Size = new System.Drawing.Size(57, 17);
            this.checkBoxMethodOfEiler.TabIndex = 5;
            this.checkBoxMethodOfEiler.Text = "Эйлер";
            this.checkBoxMethodOfEiler.UseVisualStyleBackColor = true;
            // 
            // checkBoxMethodOfRungeKuttaMerson
            // 
            this.checkBoxMethodOfRungeKuttaMerson.AutoSize = true;
            this.checkBoxMethodOfRungeKuttaMerson.Location = new System.Drawing.Point(551, 107);
            this.checkBoxMethodOfRungeKuttaMerson.Name = "checkBoxMethodOfRungeKuttaMerson";
            this.checkBoxMethodOfRungeKuttaMerson.Size = new System.Drawing.Size(118, 17);
            this.checkBoxMethodOfRungeKuttaMerson.TabIndex = 6;
            this.checkBoxMethodOfRungeKuttaMerson.Text = "Рунг–Кутт Мерсон";
            this.checkBoxMethodOfRungeKuttaMerson.UseVisualStyleBackColor = true;
            // 
            // checkBoxMethodOfEilerCorrect
            // 
            this.checkBoxMethodOfEilerCorrect.AutoSize = true;
            this.checkBoxMethodOfEilerCorrect.Location = new System.Drawing.Point(551, 139);
            this.checkBoxMethodOfEilerCorrect.Name = "checkBoxMethodOfEilerCorrect";
            this.checkBoxMethodOfEilerCorrect.Size = new System.Drawing.Size(176, 17);
            this.checkBoxMethodOfEilerCorrect.TabIndex = 7;
            this.checkBoxMethodOfEilerCorrect.Text = "Исправленный метод Эйлера";
            this.checkBoxMethodOfEilerCorrect.UseVisualStyleBackColor = true;
            // 
            // checkBoxMethodOfAdams4Order
            // 
            this.checkBoxMethodOfAdams4Order.AutoSize = true;
            this.checkBoxMethodOfAdams4Order.Location = new System.Drawing.Point(551, 172);
            this.checkBoxMethodOfAdams4Order.Name = "checkBoxMethodOfAdams4Order";
            this.checkBoxMethodOfAdams4Order.Size = new System.Drawing.Size(113, 17);
            this.checkBoxMethodOfAdams4Order.TabIndex = 8;
            this.checkBoxMethodOfAdams4Order.Text = "Адамс 4 порядка";
            this.checkBoxMethodOfAdams4Order.UseVisualStyleBackColor = true;
            // 
            // checkBoxExactSolution
            // 
            this.checkBoxExactSolution.AutoSize = true;
            this.checkBoxExactSolution.Location = new System.Drawing.Point(551, 205);
            this.checkBoxExactSolution.Name = "checkBoxExactSolution";
            this.checkBoxExactSolution.Size = new System.Drawing.Size(109, 17);
            this.checkBoxExactSolution.TabIndex = 9;
            this.checkBoxExactSolution.Text = "Точное решение";
            this.checkBoxExactSolution.UseVisualStyleBackColor = true;
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(551, 239);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(213, 57);
            this.buttonBuild.TabIndex = 10;
            this.buttonBuild.Text = "Построить";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // textBoxEndX
            // 
            this.textBoxEndX.Location = new System.Drawing.Point(664, 37);
            this.textBoxEndX.Name = "textBoxEndX";
            this.textBoxEndX.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndX.TabIndex = 13;
            this.textBoxEndX.Text = "10";
            this.textBoxEndX.TextChanged += new System.EventHandler(this.textBoxValue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Конечная точка (Xn):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 421);
            this.Controls.Add(this.textBoxEndX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.checkBoxExactSolution);
            this.Controls.Add(this.checkBoxMethodOfAdams4Order);
            this.Controls.Add(this.checkBoxMethodOfEilerCorrect);
            this.Controls.Add(this.checkBoxMethodOfRungeKuttaMerson);
            this.Controls.Add(this.checkBoxMethodOfEiler);
            this.Controls.Add(this.textBoxAccuracy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Главное окно";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAccuracy;
        private System.Windows.Forms.CheckBox checkBoxMethodOfEiler;
        private System.Windows.Forms.CheckBox checkBoxMethodOfRungeKuttaMerson;
        private System.Windows.Forms.CheckBox checkBoxMethodOfEilerCorrect;
        private System.Windows.Forms.CheckBox checkBoxMethodOfAdams4Order;
        private System.Windows.Forms.CheckBox checkBoxExactSolution;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.TextBox textBoxEndX;
        private System.Windows.Forms.Label label3;
    }
}

