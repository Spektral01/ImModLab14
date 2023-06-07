using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImModelLab14_Last
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int busyOps = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            Model.Run((double)ArrivalEd.Value, (double)ParamOfServEd.Value, (int)NumOfOperEd.Value);
            chart1.Series[0].Points.AddXY(0, 0);
            busyOps = Model.getBusyOperatorsSize();
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Enabled = Model.Iter();
            if (busyOps < Model.getBusyOperatorsSize())
            {
                chart1.Series[0].Points.AddXY(Model.Time, busyOps);
                busyOps++;
                chart1.Series[0].Points.AddXY(Model.Time, busyOps);
            }
            else
            {
                chart1.Series[0].Points.AddXY(Model.Time, busyOps);
                busyOps--;
                chart1.Series[0].Points.AddXY(Model.Time, busyOps);
            }
            PrQueLbl.Text = Model.queueSize().ToString();
            NonPrQueLbl.Text = Model.queueSizeNonPr().ToString();
            AllCustomLbl.Text = Model.CAmount.ToString();
            LeftCustomLbl.Text = Model.getLeftCustom().ToString();
        }
    }
}
