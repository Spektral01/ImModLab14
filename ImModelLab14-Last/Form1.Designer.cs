﻿
namespace ImModelLab14_Last
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumOfOperEd = new System.Windows.Forms.NumericUpDown();
            this.ParamOfServEd = new System.Windows.Forms.NumericUpDown();
            this.ArrivalEd = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PrQueLbl = new System.Windows.Forms.Label();
            this.AllCustomLbl = new System.Windows.Forms.Label();
            this.LeftCustomLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NonPrQueLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfOperEd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParamOfServEd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrivalEd)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(435, 33);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(783, 703);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of operators";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parameter of service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arrival process";
            // 
            // NumOfOperEd
            // 
            this.NumOfOperEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumOfOperEd.Location = new System.Drawing.Point(270, 12);
            this.NumOfOperEd.Name = "NumOfOperEd";
            this.NumOfOperEd.Size = new System.Drawing.Size(156, 28);
            this.NumOfOperEd.TabIndex = 4;
            this.NumOfOperEd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ParamOfServEd
            // 
            this.ParamOfServEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParamOfServEd.Location = new System.Drawing.Point(270, 71);
            this.ParamOfServEd.Name = "ParamOfServEd";
            this.ParamOfServEd.Size = new System.Drawing.Size(156, 28);
            this.ParamOfServEd.TabIndex = 5;
            this.ParamOfServEd.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ArrivalEd
            // 
            this.ArrivalEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrivalEd.Location = new System.Drawing.Point(270, 137);
            this.ArrivalEd.Name = "ArrivalEd";
            this.ArrivalEd.Size = new System.Drawing.Size(156, 28);
            this.ArrivalEd.TabIndex = 6;
            this.ArrivalEd.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(91, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 84);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(28, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "All customers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(28, 620);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Left customers";
            // 
            // PrQueLbl
            // 
            this.PrQueLbl.AutoSize = true;
            this.PrQueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrQueLbl.Location = new System.Drawing.Point(294, 397);
            this.PrQueLbl.Name = "PrQueLbl";
            this.PrQueLbl.Size = new System.Drawing.Size(23, 25);
            this.PrQueLbl.TabIndex = 11;
            this.PrQueLbl.Text = "0";
            // 
            // AllCustomLbl
            // 
            this.AllCustomLbl.AutoSize = true;
            this.AllCustomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllCustomLbl.Location = new System.Drawing.Point(294, 545);
            this.AllCustomLbl.Name = "AllCustomLbl";
            this.AllCustomLbl.Size = new System.Drawing.Size(23, 25);
            this.AllCustomLbl.TabIndex = 12;
            this.AllCustomLbl.Text = "0";
            // 
            // LeftCustomLbl
            // 
            this.LeftCustomLbl.AutoSize = true;
            this.LeftCustomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftCustomLbl.Location = new System.Drawing.Point(294, 620);
            this.LeftCustomLbl.Name = "LeftCustomLbl";
            this.LeftCustomLbl.Size = new System.Drawing.Size(23, 25);
            this.LeftCustomLbl.TabIndex = 13;
            this.LeftCustomLbl.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // NonPrQueLbl
            // 
            this.NonPrQueLbl.AutoSize = true;
            this.NonPrQueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NonPrQueLbl.Location = new System.Drawing.Point(294, 470);
            this.NonPrQueLbl.Name = "NonPrQueLbl";
            this.NonPrQueLbl.Size = new System.Drawing.Size(23, 25);
            this.NonPrQueLbl.TabIndex = 15;
            this.NonPrQueLbl.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(28, 470);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Customers in queue non-pr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Customers in queue ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 748);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NonPrQueLbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LeftCustomLbl);
            this.Controls.Add(this.AllCustomLbl);
            this.Controls.Add(this.PrQueLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ArrivalEd);
            this.Controls.Add(this.ParamOfServEd);
            this.Controls.Add(this.NumOfOperEd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfOperEd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParamOfServEd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrivalEd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumOfOperEd;
        private System.Windows.Forms.NumericUpDown ParamOfServEd;
        private System.Windows.Forms.NumericUpDown ArrivalEd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PrQueLbl;
        private System.Windows.Forms.Label AllCustomLbl;
        private System.Windows.Forms.Label LeftCustomLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label NonPrQueLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
    }
}

