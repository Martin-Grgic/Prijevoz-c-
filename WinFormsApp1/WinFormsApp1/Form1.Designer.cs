namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            mC_Kalendar = new MonthCalendar();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Udaljenost = new TextBox();
            textBox3 = new TextBox();
            Troskovnik = new TextBox();
            button1 = new Button();
            cbx_zaposlenik = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 63);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Zaposlenik:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 148);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Radni dani:";
            // 
            // mC_Kalendar
            // 
            mC_Kalendar.Location = new Point(75, 180);
            mC_Kalendar.MaxSelectionCount = 100000;
            mC_Kalendar.Name = "mC_Kalendar";
            mC_Kalendar.TabIndex = 4;
            mC_Kalendar.DateSelected += mC_Kalendar_DateSelected;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(562, 63);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 5;
            label3.Text = "Udaljenost (jedan smjer):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(562, 148);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 6;
            label4.Text = "Cijena po km:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(562, 233);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 7;
            label5.Text = "Troškovnik:";
            // 
            // Udaljenost
            // 
            Udaljenost.AllowDrop = true;
            Udaljenost.Location = new Point(562, 98);
            Udaljenost.Name = "Udaljenost";
            Udaljenost.Size = new Size(211, 27);
            Udaljenost.TabIndex = 8;
            Udaljenost.Text = "km";
            Udaljenost.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            textBox3.AllowDrop = true;
            textBox3.Location = new Point(562, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 27);
            textBox3.TabIndex = 9;
            textBox3.Text = "1€";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // Troskovnik
            // 
            Troskovnik.AllowDrop = true;
            Troskovnik.Location = new Point(562, 267);
            Troskovnik.Multiline = true;
            Troskovnik.Name = "Troskovnik";
            Troskovnik.ScrollBars = ScrollBars.Vertical;
            Troskovnik.Size = new Size(284, 120);
            Troskovnik.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(104, 437);
            button1.Name = "button1";
            button1.Size = new Size(159, 56);
            button1.TabIndex = 11;
            button1.Text = "Izračunaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbx_zaposlenik
            // 
            cbx_zaposlenik.FormattingEnabled = true;
            cbx_zaposlenik.Location = new Point(75, 97);
            cbx_zaposlenik.Name = "cbx_zaposlenik";
            cbx_zaposlenik.Size = new Size(234, 28);
            cbx_zaposlenik.TabIndex = 12;
            cbx_zaposlenik.SelectedIndexChanged += cbx_zaposlenik_SelectedIndexChanged;
            cbx_zaposlenik.Format += Full_name;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 553);
            Controls.Add(cbx_zaposlenik);
            Controls.Add(button1);
            Controls.Add(Troskovnik);
            Controls.Add(textBox3);
            Controls.Add(Udaljenost);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mC_Kalendar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Troškovnik:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MonthCalendar mC_Kalendar;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Udaljenost;
        private TextBox textBox3;
        private TextBox Troskovnik;
        private Button button1;
        private ComboBox cbx_zaposlenik;
    }
}