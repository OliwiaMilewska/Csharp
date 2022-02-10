using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_sem2
{
    public partial class Form2 : Form 
    {
        public Form2()
        {
            InitializeComponent();

            ///Załadowanie wyników
            if(Form1.checkBox6.Checked==true)
            {
                chart1.Series[0].Points.AddXY("0-1", Form1.p01);
            }
            if (Form1.checkBox7.Checked == true)
            {
                chart1.Series[0].Points.AddXY("1-2", Form1.p12);
            }
            if (Form1.checkBox8.Checked == true)
            {
                chart1.Series[0].Points.AddXY("2-3", Form1.p23);
            }
            if (Form1.checkBox9.Checked == true)
            {
                chart1.Series[0].Points.AddXY("3-4", Form1.p34);
            }
            if (Form1.checkBox10.Checked == true)
            {
                chart1.Series[0].Points.AddXY("4-5", Form1.p45);
            }

            ///Ustawienie kolorów
            if (Form1.radioButton8.Checked == true)
            {
                chart1.Series[0].Color = Color.FromArgb(250, 0, 250);
            }
            if (Form1.radioButton9.Checked == true)
            {
                chart1.Series[0].Color = Color.FromArgb(0, 255, 255);
            }
            if (Form1.radioButton10.Checked == true)
            {
                chart1.Series[0].Color = Color.FromArgb(255, 215, 0);
            }
            if (Form1.radioButton11.Checked == true)
            {
                chart1.Series[0].Color = Color.FromArgb(255, 20, 147);
            }
            if (Form1.radioButton12.Checked == true)
            {
               chart1.Series[0].Color = Color.FromArgb(220, 20, 60);
            }
            if (Form1.radioButton13.Checked == true)
            {
                chart1.Series[0].Color = Color.FromArgb(0, 255, 0);
            }
            if(Form1.radioButton1.Checked==true)
            {
                chart1.Series[0].Color = Color.FromArgb(Form1.kolor);
            }

            ///Ustawienia legendy
            if (Form1.checkBox4.Checked == true)
            {
                chart1.Legends[0].Enabled = true;
                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.Titles[0].Visible = true;
            }
            if (Form1.checkBox5.Checked == true)
            {
                chart1.Legends[0].Enabled = false;
                chart1.Series[0].IsValueShownAsLabel = false;
                chart1.Titles[0].Visible = false;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
