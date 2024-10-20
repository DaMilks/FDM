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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartTX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStart = new System.Windows.Forms.Button();
            this.ChartTt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStop = new System.Windows.Forms.Button();
            this.TextBoxAmplitude = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Un = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChartTX1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TextBoxAmplitude1 = new System.Windows.Forms.TextBox();
            this.ChartTt1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxPrint = new System.Windows.Forms.CheckBox();
            this.checkBoxPrint1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Un.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTt1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartTX
            // 
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "T";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.Name = "ChartArea1";
            this.ChartTX.ChartAreas.Add(chartArea1);
            this.ChartTX.Location = new System.Drawing.Point(6, 21);
            this.ChartTX.Name = "ChartTX";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.ChartTX.Series.Add(series1);
            this.ChartTX.Size = new System.Drawing.Size(641, 300);
            this.ChartTX.TabIndex = 0;
            this.ChartTX.Text = "chart1";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(1309, 33);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(102, 38);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChartTt
            // 
            chartArea2.AxisX.Title = "t";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisY.Title = "T";
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea2.Name = "ChartArea1";
            this.ChartTt.ChartAreas.Add(chartArea2);
            this.ChartTt.Location = new System.Drawing.Point(653, 21);
            this.ChartTt.Name = "ChartTt";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            this.ChartTt.Series.Add(series2);
            this.ChartTt.Size = new System.Drawing.Size(616, 300);
            this.ChartTt.TabIndex = 2;
            this.ChartTt.Text = "chart1";
            // 
            // buttonStop
            // 
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(1309, 77);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(102, 38);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextBoxAmplitude
            // 
            this.TextBoxAmplitude.Location = new System.Drawing.Point(115, 330);
            this.TextBoxAmplitude.Name = "TextBoxAmplitude";
            this.TextBoxAmplitude.ReadOnly = true;
            this.TextBoxAmplitude.Size = new System.Drawing.Size(181, 26);
            this.TextBoxAmplitude.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxPrint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ChartTX);
            this.groupBox1.Controls.Add(this.TextBoxAmplitude);
            this.groupBox1.Controls.Add(this.ChartTt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1291, 364);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод сеток";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Амплитуда";
            // 
            // Un
            // 
            this.Un.Controls.Add(this.checkBoxPrint1);
            this.Un.Controls.Add(this.label5);
            this.Un.Controls.Add(this.label4);
            this.Un.Controls.Add(this.textBoxS);
            this.Un.Controls.Add(this.textBoxT);
            this.Un.Controls.Add(this.label2);
            this.Un.Controls.Add(this.ChartTX1);
            this.Un.Controls.Add(this.TextBoxAmplitude1);
            this.Un.Controls.Add(this.ChartTt1);
            this.Un.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Un.Location = new System.Drawing.Point(12, 382);
            this.Un.Name = "Un";
            this.Un.Size = new System.Drawing.Size(1291, 425);
            this.Un.TabIndex = 6;
            this.Un.TabStop = false;
            this.Un.Text = "Метод сеток неявный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Амплитуда";
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
            this.ChartTX1.Location = new System.Drawing.Point(6, 21);
            this.ChartTX1.Name = "ChartTX1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Series1";
            this.ChartTX1.Series.Add(series3);
            this.ChartTX1.Size = new System.Drawing.Size(641, 300);
            this.ChartTX1.TabIndex = 0;
            this.ChartTX1.Text = "chart1";
            // 
            // TextBoxAmplitude1
            // 
            this.TextBoxAmplitude1.Location = new System.Drawing.Point(115, 330);
            this.TextBoxAmplitude1.Name = "TextBoxAmplitude1";
            this.TextBoxAmplitude1.ReadOnly = true;
            this.TextBoxAmplitude1.Size = new System.Drawing.Size(181, 26);
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
            this.ChartTt1.Location = new System.Drawing.Point(653, 21);
            this.ChartTt1.Name = "ChartTt1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Name = "Series1";
            this.ChartTt1.Series.Add(series4);
            this.ChartTt1.Size = new System.Drawing.Size(616, 300);
            this.ChartTt1.TabIndex = 2;
            this.ChartTt1.Text = "chart1";
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(364, 333);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(181, 26);
            this.textBoxT.TabIndex = 8;
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(364, 365);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.ReadOnly = true;
            this.textBoxS.Size = new System.Drawing.Size(181, 26);
            this.textBoxS.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "t";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "s";
            // 
            // checkBoxPrint
            // 
            this.checkBoxPrint.AutoSize = true;
            this.checkBoxPrint.Location = new System.Drawing.Point(302, 333);
            this.checkBoxPrint.Name = "checkBoxPrint";
            this.checkBoxPrint.Size = new System.Drawing.Size(155, 24);
            this.checkBoxPrint.TabIndex = 6;
            this.checkBoxPrint.Text = "Отрисовывать";
            this.checkBoxPrint.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrint1
            // 
            this.checkBoxPrint1.AutoSize = true;
            this.checkBoxPrint1.Location = new System.Drawing.Point(10, 356);
            this.checkBoxPrint1.Name = "checkBoxPrint1";
            this.checkBoxPrint1.Size = new System.Drawing.Size(155, 24);
            this.checkBoxPrint1.TabIndex = 7;
            this.checkBoxPrint1.Text = "Отрисовывать";
            this.checkBoxPrint1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 836);
            this.Controls.Add(this.Un);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ChartTX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Un.ResumeLayout(false);
            this.Un.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTX;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTt;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox TextBoxAmplitude;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Un;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTX1;
        private System.Windows.Forms.TextBox TextBoxAmplitude1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTt1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.CheckBox checkBoxPrint;
        private System.Windows.Forms.CheckBox checkBoxPrint1;
    }
}

