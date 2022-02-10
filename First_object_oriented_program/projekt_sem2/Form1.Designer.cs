
namespace projekt_sem2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            radioButton8 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            radioButton9 = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            radioButton10 = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            radioButton11 = new System.Windows.Forms.RadioButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            radioButton12 = new System.Windows.Forms.RadioButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            radioButton13 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            checkBox1 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            checkBox4 = new System.Windows.Forms.CheckBox();
            checkBox5 = new System.Windows.Forms.CheckBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            radioButton1 = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label6 = new System.Windows.Forms.Label();
            checkBox6 = new System.Windows.Forms.CheckBox();
            checkBox7 = new System.Windows.Forms.CheckBox();
            checkBox8 = new System.Windows.Forms.CheckBox();
            checkBox9 = new System.Windows.Forms.CheckBox();
            checkBox10 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(52, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Otwórz plik z danymi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(52, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Przygotuj dane*";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(62, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(268, 381);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(-2, 693);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "* Dane zostaną przetworzone w ten sposób aby zrobić z nich histogram";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(517, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Edytuj wygląd histogramu:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(762, 635);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 60);
            this.button3.TabIndex = 7;
            this.button3.Text = "Generuj wykres";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(52, 607);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(296, 60);
            this.button4.TabIndex = 8;
            this.button4.Text = "Zapisz dane ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(510, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rodzaj wyświetlanych danych:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(510, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kolor słupków:";
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.BackColor = System.Drawing.Color.Transparent;
            radioButton8.Checked = true;
            radioButton8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            radioButton8.Location = new System.Drawing.Point(517, 289);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new System.Drawing.Size(80, 25);
            radioButton8.TabIndex = 18;
            radioButton8.TabStop = true;
            radioButton8.Text = "Fuksja";
            radioButton8.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(629, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(629, 335);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.BackColor = System.Drawing.Color.Transparent;
            radioButton9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            radioButton9.Location = new System.Drawing.Point(517, 335);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new System.Drawing.Size(78, 25);
            radioButton9.TabIndex = 20;
            radioButton9.Text = "Aqua";
            radioButton9.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(629, 381);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.BackColor = System.Drawing.Color.Transparent;
            radioButton10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            radioButton10.Location = new System.Drawing.Point(517, 381);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new System.Drawing.Size(71, 25);
            radioButton10.TabIndex = 22;
            radioButton10.Text = "Złoty";
            radioButton10.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(840, 381);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.BackColor = System.Drawing.Color.Transparent;
            radioButton11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            radioButton11.Location = new System.Drawing.Point(686, 381);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new System.Drawing.Size(92, 25);
            radioButton11.TabIndex = 28;
            radioButton11.Text = "Różowy";
            radioButton11.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(840, 335);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.BackColor = System.Drawing.Color.Transparent;
            radioButton12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            radioButton12.Location = new System.Drawing.Point(686, 335);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new System.Drawing.Size(143, 25);
            radioButton12.TabIndex = 26;
            radioButton12.Text = "Karmazynowy";
            radioButton12.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(840, 289);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // radioButton13
            // 
            radioButton13.AutoSize = true;
            radioButton13.BackColor = System.Drawing.Color.Transparent;
            radioButton13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            radioButton13.Location = new System.Drawing.Point(686, 289);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new System.Drawing.Size(99, 25);
            radioButton13.TabIndex = 24;
            radioButton13.Text = "Limonka";
            radioButton13.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(510, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Opis wykresu:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = System.Drawing.Color.Transparent;
            checkBox1.Checked = true;
            checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            checkBox1.Location = new System.Drawing.Point(517, 181);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(103, 26);
            checkBox1.TabIndex = 32;
            checkBox1.Text = "dane  1";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = System.Drawing.Color.Transparent;
            checkBox2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            checkBox2.Location = new System.Drawing.Point(686, 181);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(103, 26);
            checkBox2.TabIndex = 33;
            checkBox2.Text = "dane  2";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = System.Drawing.Color.Transparent;
            checkBox3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            checkBox3.Location = new System.Drawing.Point(855, 181);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(103, 26);
            checkBox3.TabIndex = 34;
            checkBox3.Text = "dane  3";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = System.Drawing.Color.Transparent;
            checkBox4.Checked = true;
            checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            checkBox4.Location = new System.Drawing.Point(512, 578);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new System.Drawing.Size(56, 26);
            checkBox4.TabIndex = 35;
            checkBox4.Text = "on";
            checkBox4.UseVisualStyleBackColor = false;
            checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = System.Drawing.Color.Transparent;
            checkBox5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            checkBox5.Location = new System.Drawing.Point(644, 578);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new System.Drawing.Size(56, 26);
            checkBox5.TabIndex = 36;
            checkBox5.Text = "off";
            checkBox5.UseVisualStyleBackColor = false;
            checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Location = new System.Drawing.Point(1089, 335);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = System.Drawing.Color.Transparent;
            radioButton1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            radioButton1.Location = new System.Drawing.Point(901, 335);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(168, 25);
            radioButton1.TabIndex = 37;
            radioButton1.Text = "Niestandardowy";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(510, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Wyświetl przedziały ocen:";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.BackColor = System.Drawing.Color.Transparent;
            checkBox6.Checked = true;
            checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            checkBox6.Location = new System.Drawing.Point(513, 472);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new System.Drawing.Size(60, 26);
            checkBox6.TabIndex = 40;
            checkBox6.Text = "0-1";
            checkBox6.UseVisualStyleBackColor = false;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.BackColor = System.Drawing.Color.Transparent;
            checkBox7.Checked = true;
            checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            checkBox7.Location = new System.Drawing.Point(601, 472);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new System.Drawing.Size(60, 26);
            checkBox7.TabIndex = 41;
            checkBox7.Text = "1-2";
            checkBox7.UseVisualStyleBackColor = false;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.BackColor = System.Drawing.Color.Transparent;
            checkBox8.Checked = true;
            checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            checkBox8.Location = new System.Drawing.Point(686, 472);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new System.Drawing.Size(60, 26);
            checkBox8.TabIndex = 42;
            checkBox8.Text = "2-3";
            checkBox8.UseVisualStyleBackColor = false;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.BackColor = System.Drawing.Color.Transparent;
            checkBox9.Checked = true;
            checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            checkBox9.Location = new System.Drawing.Point(762, 472);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new System.Drawing.Size(60, 26);
            checkBox9.TabIndex = 43;
            checkBox9.Text = "3-4";
            checkBox9.UseVisualStyleBackColor = false;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.BackColor = System.Drawing.Color.Transparent;
            checkBox10.Checked = true;
            checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            checkBox10.Location = new System.Drawing.Point(840, 472);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new System.Drawing.Size(60, 26);
            checkBox10.TabIndex = 44;
            checkBox10.Text = "4-5";
            checkBox10.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1152, 761);
            this.Controls.Add(checkBox10);
            this.Controls.Add(checkBox9);
            this.Controls.Add(checkBox8);
            this.Controls.Add(checkBox7);
            this.Controls.Add(checkBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(radioButton1);
            this.Controls.Add(checkBox5);
            this.Controls.Add(checkBox4);
            this.Controls.Add(checkBox3);
            this.Controls.Add(checkBox2);
            this.Controls.Add(checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(radioButton11);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(radioButton12);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(radioButton13);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(radioButton10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(radioButton9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(radioButton8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Histogram";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label6;
        public static System.Windows.Forms.CheckBox checkBox6;
        public static System.Windows.Forms.CheckBox checkBox7;
        public static System.Windows.Forms.CheckBox checkBox8;
        public static System.Windows.Forms.CheckBox checkBox9;
        public static System.Windows.Forms.CheckBox checkBox10;
        public static System.Windows.Forms.RadioButton radioButton1;
        public static System.Windows.Forms.CheckBox checkBox1;
        public static System.Windows.Forms.CheckBox checkBox2;
        public static System.Windows.Forms.CheckBox checkBox3;
        public static System.Windows.Forms.CheckBox checkBox4;
        public static System.Windows.Forms.CheckBox checkBox5;
        public static System.Windows.Forms.RadioButton radioButton8;
        public static System.Windows.Forms.RadioButton radioButton9;
        public static System.Windows.Forms.RadioButton radioButton10;
        public static System.Windows.Forms.RadioButton radioButton11;
        public static System.Windows.Forms.RadioButton radioButton12;
        public static System.Windows.Forms.RadioButton radioButton13;
    }
}

