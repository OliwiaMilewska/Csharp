using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace projekt_sem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] tab1 = new int[5];
        int[] tab2 = new int[5];
        int[] tab3 = new int[5];
        public static double p01, p12, p23, p34, p45;
        int click = 0;
        public static int kolor;
        OpenFileDialog dane = new OpenFileDialog();
        String przetworzone;

        private void button1_Click(object sender, EventArgs e)
        {
            ///////////////// Odczyt pliku
            dane.Filter = "Pliki tekstowe|*.txt";
            if (dane.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(dane.FileName);
                button2.Enabled = true;
                MessageBox.Show("Otwarto: " + dane.SafeFileName, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                MessageBox.Show("Coś poszło nie tak :c", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button2.Enabled = false;
            button1.Enabled = true;
            ///////////////// Załadowanie danych z pliku do tablicy int'ów
            string[] liczbyString = new string[100];
            double[] liczbyDouble = new double[100];
            try
            {
                liczbyString = File.ReadAllLines(dane.FileName);
                for (int i = 0; i < 100; i++)
                {
                    liczbyDouble[i] = Double.Parse(liczbyString[i]);
                }
                ///////////////// Policzenie ilości elementów w przedziałach 
                for (int i = 0; i < 100; i++)
                {
                    if (click == 0)
                    {
                        if (liczbyDouble[i] >= 0 && liczbyDouble[i] <= 1)
                        {
                            tab1[0] += 1;
                        }
                        if (liczbyDouble[i] > 1 && liczbyDouble[i] <= 2)
                        {
                            tab1[1] += 1;
                        }
                        if (liczbyDouble[i] > 2 && liczbyDouble[i] <= 3)
                        {
                            tab1[2] += 1;
                        }
                        if (liczbyDouble[i] > 3 && liczbyDouble[i] <= 4)
                        {
                            tab1[3] += 1;
                        }
                        if (liczbyDouble[i] > 4 && liczbyDouble[i] <= 5)
                        {
                            tab1[4] += 1;
                        }
                    }
                    if (click == 1)
                    {
                        if (liczbyDouble[i] >= 0 && liczbyDouble[i] <= 1)
                        {
                            tab2[0] += 1;
                        }
                        if (liczbyDouble[i] > 1 && liczbyDouble[i] <= 2)
                        {
                            tab2[1] += 1;
                        }
                        if (liczbyDouble[i] > 2 && liczbyDouble[i] <= 3)
                        {
                            tab2[2] += 1;
                        }
                        if (liczbyDouble[i] > 3 && liczbyDouble[i] <= 4)
                        {
                            tab2[3] += 1;
                        }
                        if (liczbyDouble[i] > 4 && liczbyDouble[i] <= 5)
                        {
                            tab2[4] += 1;
                        }
                    }
                    if (click == 2)
                    {
                        if (liczbyDouble[i] >= 0 && liczbyDouble[i] <= 1)
                        {
                            tab3[0] += 1;
                        }
                        if (liczbyDouble[i] > 1 && liczbyDouble[i] <= 2)
                        {
                            tab3[1] += 1;
                        }
                        if (liczbyDouble[i] > 2 && liczbyDouble[i] <= 3)
                        {
                            tab3[2] += 1;
                        }
                        if (liczbyDouble[i] > 3 && liczbyDouble[i] <= 4)
                        {
                            tab3[3] += 1;
                        }
                        if (liczbyDouble[i] > 4 && liczbyDouble[i] <= 5)
                        {
                            tab3[4] += 1;
                        }
                        button1.Enabled = false;
                    }
                }
                click++;
                p01 = tab1[0] + tab2[0] + tab3[0];
                p12 = tab1[1] + tab2[1] + tab3[1];
                p23 = tab1[2] + tab2[2] + tab3[2];
                p34 = tab1[3] + tab2[3] + tab3[3];
                p45 = tab1[4] + tab2[4] + tab3[4];
            }
            catch
            {
                p01 = 0;
                p12 = 0;
                p23 = 0;
                p34 = 0;
                p45 = 0;
                MessageBox.Show("Coś poszło nie tak :c", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            przetworzone = "Rozkład ocen: \n 0-1: " + p01 + " \n 1-2: " + p12 + " \n 2-3: " + p23 + " \n 3-4: " + p34 + " \n 4-5: " + p45 + "";
            textBox1.Text = przetworzone;

            ////////////////// Guziczki serii, ilości danych
            if (click == 1)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            if (click == 2)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = false;
            }
            if (click == 3)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ///////////////// Zapisanie do pliku z wynikami i wyświetlenie na ekranie
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Plik tekstowy|*.txt";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BinaryWriter bw = new BinaryWriter(File.Create(sfd.FileName));
                bw.Write(przetworzone);
                bw.Dispose();
                MessageBox.Show("Udało się zapisać plik! ", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button4.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
            {
                checkBox5.Checked = true;
                checkBox4.Checked = false;
            }
            else
            {
                checkBox5.Checked = false;
                checkBox4.Checked = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == false)
            {
                checkBox4.Checked = true;
                checkBox5.Checked = false;
            }
            else
            {
                checkBox4.Checked = false;
                checkBox5.Checked = true;
            }

        }

        private void radioButton1_CheckedChanged(Object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    kolor = colorDialog1.Color.ToArgb();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ////////////////// Przetworzenie danych
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                p01 = tab1[0];
                p12 = tab1[1];
                p23 = tab1[2];
                p34 = tab1[3];
                p45 = tab1[4];
            }
            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                p01 = tab2[0];
                p12 = tab2[1];
                p23 = tab2[2];
                p34 = tab2[3];
                p45 = tab2[4];
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                p01 = tab3[0];
                p12 = tab3[1];
                p23 = tab3[2];
                p34 = tab3[3];
                p45 = tab3[4];
            }
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                p01 = tab1[0] + tab2[0];
                p12 = tab1[1] + tab2[1];
                p23 = tab1[2] + tab2[2];
                p34 = tab1[3] + tab2[3];
                p45 = tab1[4] + tab2[4];
            }
            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                p01 = tab2[0] + tab3[0];
                p12 = tab2[1] + tab3[1];
                p23 = tab2[2] + tab3[2];
                p34 = tab2[3] + tab3[3];
                p45 = tab2[4] + tab3[4];
            }
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                p01 = tab1[0] + tab3[0];
                p12 = tab1[1] + tab3[1];
                p23 = tab1[2] + tab3[2];
                p34 = tab1[3] + tab3[3];
                p45 = tab1[4] + tab3[4];
            }
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                p01 = tab1[0] + tab2[0] + tab3[0];
                p12 = tab1[1] + tab2[1] + tab3[1];
                p23 = tab1[2] + tab2[2] + tab3[2];
                p34 = tab1[3] + tab2[3] + tab3[3];
                p45 = tab1[4] + tab2[4] + tab3[4];
            }
            ///Zabezpieczenie aby były zaznaczone chociaż po jednym checkBox'ie
            if ((checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true) && 
                (checkBox4.Checked == true || checkBox5.Checked == true) && 
                (checkBox6.Checked == true || checkBox7.Checked == true || checkBox8.Checked == true || 
                checkBox9.Checked == true || checkBox10.Checked == true))
            {
                Form2 wykres = new Form2();
                wykres.ShowDialog();
            }
            else if (checkBox1.Checked != true && checkBox2.Checked != true && checkBox3.Checked != true)
            {
                MessageBox.Show("Musisz zaznaczyć chociaż jedne dane.", "Zaznacz dane", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkBox4.Checked != true && checkBox5.Checked != true)
            {
                MessageBox.Show("Musisz zaznaczyć czy chesz aby wykres posiadał legendę i opis.", "Zaznacz dane", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Musisz zaznaczyć jaki zakres ocen ma się wyświetlić.", "Zaznacz dane", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult odp = MessageBox.Show("Czy na pewno chcesz wyjść z programu?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Hand);
            if(odp == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
