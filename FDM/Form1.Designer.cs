namespace FDM
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.Un = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChartTX1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TextBoxAmplitude1 = new System.Windows.Forms.TextBox();
            this.ChartTt1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TextBoxAmplitude = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Un.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTt1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(982, 27);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(76, 31);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(982, 63);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(76, 31);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // Un
            // 
            this.Un.Controls.Add(this.label1);
            this.Un.Controls.Add(this.TextBoxAmplitude);
            this.Un.Controls.Add(this.label5);
            this.Un.Controls.Add(this.label4);
            this.Un.Controls.Add(this.textBoxS);
            this.Un.Controls.Add(this.textBoxT);
            this.Un.Controls.Add(this.label2);
            this.Un.Controls.Add(this.ChartTX1);
            this.Un.Controls.Add(this.TextBoxAmplitude1);
            this.Un.Controls.Add(this.ChartTt1);
            this.Un.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Un.Location = new System.Drawing.Point(10, 11);
            this.Un.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Un.Name = "Un";
            this.Un.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Un.Size = new System.Drawing.Size(968, 345);
            this.Un.TabIndex = 6;
            this.Un.TabStop = false;
            this.Un.Text = "Метод сеток неявный";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "t";
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(490, 299);
            this.textBoxS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.ReadOnly = true;
            this.textBoxS.Size = new System.Drawing.Size(137, 23);
            this.textBoxS.TabIndex = 9;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(490, 271);
            this.textBoxT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(137, 23);
            this.textBoxT.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Амплитуда неявный";
            // 
            // ChartTX1
            // 
            chartArea3.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisX.Title = "X";
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisY.Title = "T";
            chartArea3.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea3.Name = "ChartArea1";
            this.ChartTX1.ChartAreas.Add(chartArea3);
            this.ChartTX1.Location = new System.Drawing.Point(4, 17);
            this.ChartTX1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChartTX1.Name = "ChartTX1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Name = "Series2";
            this.ChartTX1.Series.Add(series5);
            this.ChartTX1.Series.Add(series6);
            this.ChartTX1.Size = new System.Drawing.Size(481, 244);
            this.ChartTX1.TabIndex = 0;
            this.ChartTX1.Text = "chart1";
            // 
            // TextBoxAmplitude1
            // 
            this.TextBoxAmplitude1.Location = new System.Drawing.Point(165, 272);
            this.TextBoxAmplitude1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxAmplitude1.Name = "TextBoxAmplitude1";
            this.TextBoxAmplitude1.ReadOnly = true;
            this.TextBoxAmplitude1.Size = new System.Drawing.Size(137, 23);
            this.TextBoxAmplitude1.TabIndex = 4;
            // 
            // ChartTt1
            // 
            chartArea4.AxisX.Title = "t";
            chartArea4.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea4.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisY.Title = "T";
            chartArea4.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea4.Name = "ChartArea1";
            this.ChartTt1.ChartAreas.Add(chartArea4);
            this.ChartTt1.Location = new System.Drawing.Point(490, 17);
            this.ChartTt1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChartTt1.Name = "ChartTt1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Name = "Series2";
            this.ChartTt1.Series.Add(series7);
            this.ChartTt1.Series.Add(series8);
            this.ChartTt1.Size = new System.Drawing.Size(462, 244);
            this.ChartTt1.TabIndex = 2;
            this.ChartTt1.Text = "chart1";
            // 
            // TextBoxAmplitude
            // 
            this.TextBoxAmplitude.Location = new System.Drawing.Point(165, 299);
            this.TextBoxAmplitude.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxAmplitude.Name = "TextBoxAmplitude";
            this.TextBoxAmplitude.ReadOnly = true;
            this.TextBoxAmplitude.Size = new System.Drawing.Size(137, 23);
            this.TextBoxAmplitude.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Амплитуда явный";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 364);
            this.Controls.Add(this.Un);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Un.ResumeLayout(false);
            this.Un.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox Un;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTX1;
        private System.Windows.Forms.TextBox TextBoxAmplitude1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTt1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxAmplitude;
    }
}

