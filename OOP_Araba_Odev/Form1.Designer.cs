namespace OOP_Araba_Odev
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
            groupBox1 = new GroupBox();
            numericUpMotorGucu = new NumericUpDown();
            numericUpModel = new NumericUpDown();
            btnAraciOlustur = new Button();
            btnResimEkle = new Button();
            chcGarantisiVar = new CheckBox();
            label11 = new Label();
            btnResimGoster = new Button();
            cmbKasaTipi = new ComboBox();
            cmbYakitTuru = new ComboBox();
            cmbSanzimanTuru = new ComboBox();
            lblAracRengi = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cmbAracModeli = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmbAracMarkasi = new ComboBox();
            label2 = new Label();
            cmbAracTuru = new ComboBox();
            label1 = new Label();
            listArac = new ListBox();
            label10 = new Label();
            colorDialog1 = new ColorDialog();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpMotorGucu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpMotorGucu);
            groupBox1.Controls.Add(numericUpModel);
            groupBox1.Controls.Add(btnAraciOlustur);
            groupBox1.Controls.Add(btnResimEkle);
            groupBox1.Controls.Add(chcGarantisiVar);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btnResimGoster);
            groupBox1.Controls.Add(cmbKasaTipi);
            groupBox1.Controls.Add(cmbYakitTuru);
            groupBox1.Controls.Add(cmbSanzimanTuru);
            groupBox1.Controls.Add(lblAracRengi);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbAracModeli);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbAracMarkasi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbAracTuru);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 508);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Araçlar";
            // 
            // numericUpMotorGucu
            // 
            numericUpMotorGucu.Location = new Point(200, 270);
            numericUpMotorGucu.Name = "numericUpMotorGucu";
            numericUpMotorGucu.Size = new Size(53, 23);
            numericUpMotorGucu.TabIndex = 7;
            // 
            // numericUpModel
            // 
            numericUpModel.Location = new Point(55, 270);
            numericUpModel.Name = "numericUpModel";
            numericUpModel.Size = new Size(62, 23);
            numericUpModel.TabIndex = 7;
            // 
            // btnAraciOlustur
            // 
            btnAraciOlustur.Location = new Point(135, 349);
            btnAraciOlustur.Name = "btnAraciOlustur";
            btnAraciOlustur.Size = new Size(92, 26);
            btnAraciOlustur.TabIndex = 6;
            btnAraciOlustur.Text = "Oluştur";
            btnAraciOlustur.UseVisualStyleBackColor = true;
            btnAraciOlustur.Click += btnAraciOlustur_Click;
            // 
            // btnResimEkle
            // 
            btnResimEkle.Location = new Point(7, 349);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(92, 26);
            btnResimEkle.TabIndex = 6;
            btnResimEkle.Text = "Aracın Resmi";
            btnResimEkle.UseVisualStyleBackColor = true;
            btnResimEkle.Click += btnResimEkle_Click;
            // 
            // chcGarantisiVar
            // 
            chcGarantisiVar.AutoSize = true;
            chcGarantisiVar.Location = new Point(123, 312);
            chcGarantisiVar.Name = "chcGarantisiVar";
            chcGarantisiVar.Size = new Size(91, 19);
            chcGarantisiVar.TabIndex = 4;
            chcGarantisiVar.Text = "Garantisi Var";
            chcGarantisiVar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 313);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 3;
            label11.Text = "Garanti Durumu";
            // 
            // btnResimGoster
            // 
            btnResimGoster.AutoSize = true;
            btnResimGoster.Location = new Point(7, 381);
            btnResimGoster.Name = "btnResimGoster";
            btnResimGoster.Size = new Size(235, 121);
            btnResimGoster.TabIndex = 2;
            btnResimGoster.UseVisualStyleBackColor = true;
            // 
            // cmbKasaTipi
            // 
            cmbKasaTipi.FormattingEnabled = true;
            cmbKasaTipi.Location = new Point(103, 174);
            cmbKasaTipi.Name = "cmbKasaTipi";
            cmbKasaTipi.Size = new Size(139, 23);
            cmbKasaTipi.TabIndex = 1;
            // 
            // cmbYakitTuru
            // 
            cmbYakitTuru.FormattingEnabled = true;
            cmbYakitTuru.Location = new Point(102, 145);
            cmbYakitTuru.Name = "cmbYakitTuru";
            cmbYakitTuru.Size = new Size(139, 23);
            cmbYakitTuru.TabIndex = 1;
            // 
            // cmbSanzimanTuru
            // 
            cmbSanzimanTuru.FormattingEnabled = true;
            cmbSanzimanTuru.Location = new Point(102, 116);
            cmbSanzimanTuru.Name = "cmbSanzimanTuru";
            cmbSanzimanTuru.Size = new Size(139, 23);
            cmbSanzimanTuru.TabIndex = 1;
            // 
            // lblAracRengi
            // 
            lblAracRengi.BackColor = SystemColors.ActiveBorder;
            lblAracRengi.Location = new Point(102, 235);
            lblAracRengi.Name = "lblAracRengi";
            lblAracRengi.Size = new Size(124, 15);
            lblAracRengi.TabIndex = 0;
            lblAracRengi.Click += lblAracRengi_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(123, 272);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 0;
            label9.Text = "Motor Gücü";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 272);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 0;
            label8.Text = "Model";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 235);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 0;
            label7.Text = "Aracın Rengi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 177);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 0;
            label6.Text = "Kasa tipi";
            // 
            // cmbAracModeli
            // 
            cmbAracModeli.FormattingEnabled = true;
            cmbAracModeli.Location = new Point(102, 87);
            cmbAracModeli.Name = "cmbAracModeli";
            cmbAracModeli.Size = new Size(139, 23);
            cmbAracModeli.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 148);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 0;
            label5.Text = "Yakıt Türü";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 119);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 0;
            label4.Text = "Şanzıman Türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 90);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 0;
            label3.Text = "Aracın Modeli";
            // 
            // cmbAracMarkasi
            // 
            cmbAracMarkasi.FormattingEnabled = true;
            cmbAracMarkasi.Location = new Point(102, 58);
            cmbAracMarkasi.Name = "cmbAracMarkasi";
            cmbAracMarkasi.Size = new Size(139, 23);
            cmbAracMarkasi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 0;
            label2.Text = "Aracın Markası";
            // 
            // cmbAracTuru
            // 
            cmbAracTuru.FormattingEnabled = true;
            cmbAracTuru.Location = new Point(102, 29);
            cmbAracTuru.Name = "cmbAracTuru";
            cmbAracTuru.Size = new Size(139, 23);
            cmbAracTuru.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Araç Türü";
            // 
            // listArac
            // 
            listArac.FormattingEnabled = true;
            listArac.ItemHeight = 15;
            listArac.Location = new Point(284, 23);
            listArac.Name = "listArac";
            listArac.Size = new Size(199, 394);
            listArac.TabIndex = 2;
            listArac.SelectedIndexChanged += listArac_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(284, 5);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 0;
            label10.Text = "Araç İncele";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(502, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(404, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 550);
            Controls.Add(listArac);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpMotorGucu).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbAracModeli;
        private Label label3;
        private ComboBox cmbAracMarkasi;
        private Label label2;
        private ComboBox cmbAracTuru;
        private Label label1;
        private ComboBox cmbKasaTipi;
        private ComboBox cmbYakitTuru;
        private ComboBox cmbSanzimanTuru;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnResimEkle;
        private CheckBox chcGarantisiVar;
        private Label label11;
        private Button btnResimGoster;
        private ListBox listArac;
        private Label label10;
        private Button btnAraciOlustur;
        private Label lblAracRengi;
        private ColorDialog colorDialog1;
        private NumericUpDown numericUpMotorGucu;
        private NumericUpDown numericUpModel;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}