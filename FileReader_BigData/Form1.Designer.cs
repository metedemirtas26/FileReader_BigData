namespace FileReader_BigData
{
    partial class BigDataReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BigDataReader));
            this.button1 = new System.Windows.Forms.Button();
            this.txtIcerik = new System.Windows.Forms.RichTextBox();
            this.lblDosyaUzantisi = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblDosyaOnay = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblIslem = new System.Windows.Forms.Label();
            this.lblSayac = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSatirSayisi = new System.Windows.Forms.Label();
            this.txtBoxBaslangicSatiri = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lblDiziSayaci = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dosya Seçiniz..";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIcerik
            // 
            this.txtIcerik.AcceptsTab = true;
            this.txtIcerik.AutoWordSelection = true;
            this.txtIcerik.BackColor = System.Drawing.SystemColors.Control;
            this.txtIcerik.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtIcerik.Location = new System.Drawing.Point(0, 53);
            this.txtIcerik.Margin = new System.Windows.Forms.Padding(2);
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(863, 351);
            this.txtIcerik.TabIndex = 1;
            this.txtIcerik.Text = "";
            // 
            // lblDosyaUzantisi
            // 
            this.lblDosyaUzantisi.AutoSize = true;
            this.lblDosyaUzantisi.Location = new System.Drawing.Point(9, 37);
            this.lblDosyaUzantisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDosyaUzantisi.Name = "lblDosyaUzantisi";
            this.lblDosyaUzantisi.Size = new System.Drawing.Size(0, 13);
            this.lblDosyaUzantisi.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblDosyaOnay
            // 
            this.lblDosyaOnay.AutoSize = true;
            this.lblDosyaOnay.Location = new System.Drawing.Point(127, 14);
            this.lblDosyaOnay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDosyaOnay.Name = "lblDosyaOnay";
            this.lblDosyaOnay.Size = new System.Drawing.Size(0, 13);
            this.lblDosyaOnay.TabIndex = 3;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(584, 28);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(57, 19);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = ">>";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(584, 6);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Mask = "000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.Text = "000000100";
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Satır Aralığı:";
            // 
            // btnYazdır
            // 
            this.btnYazdır.Location = new System.Drawing.Point(662, 28);
            this.btnYazdır.Margin = new System.Windows.Forms.Padding(2);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(52, 19);
            this.btnYazdır.TabIndex = 8;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.UseVisualStyleBackColor = true;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click_1);
            // 
            // btnKopyala
            // 
            this.btnKopyala.Location = new System.Drawing.Point(718, 28);
            this.btnKopyala.Margin = new System.Windows.Forms.Padding(2);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(50, 19);
            this.btnKopyala.TabIndex = 9;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(662, 5);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(172, 19);
            this.progressBar1.TabIndex = 10;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblIslem
            // 
            this.lblIslem.AutoSize = true;
            this.lblIslem.Location = new System.Drawing.Point(773, 26);
            this.lblIslem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIslem.Name = "lblIslem";
            this.lblIslem.Size = new System.Drawing.Size(0, 13);
            this.lblIslem.TabIndex = 11;
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Location = new System.Drawing.Point(809, 36);
            this.lblSayac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(0, 13);
            this.lblSayac.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Toplam Satır:";
            // 
            // lblSatirSayisi
            // 
            this.lblSatirSayisi.AutoSize = true;
            this.lblSatirSayisi.Location = new System.Drawing.Point(435, 10);
            this.lblSatirSayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSatirSayisi.Name = "lblSatirSayisi";
            this.lblSatirSayisi.Size = new System.Drawing.Size(80, 13);
            this.lblSatirSayisi.TabIndex = 14;
            this.lblSatirSayisi.Text = "Hesaplanmadı..";
            // 
            // txtBoxBaslangicSatiri
            // 
            this.txtBoxBaslangicSatiri.Location = new System.Drawing.Point(438, 31);
            this.txtBoxBaslangicSatiri.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxBaslangicSatiri.Mask = "000000000";
            this.txtBoxBaslangicSatiri.Name = "txtBoxBaslangicSatiri";
            this.txtBoxBaslangicSatiri.Size = new System.Drawing.Size(77, 20);
            this.txtBoxBaslangicSatiri.TabIndex = 15;
            this.txtBoxBaslangicSatiri.Text = "000000000";
            this.txtBoxBaslangicSatiri.TextChanged += new System.EventHandler(this.txtBoxBaslangicSatiri_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Başlangıç Satırı:";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // lblDiziSayaci
            // 
            this.lblDiziSayaci.AutoSize = true;
            this.lblDiziSayaci.Location = new System.Drawing.Point(257, 34);
            this.lblDiziSayaci.Name = "lblDiziSayaci";
            this.lblDiziSayaci.Size = new System.Drawing.Size(0, 13);
            this.lblDiziSayaci.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Okunan Satır:";
            // 
            // BigDataReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(863, 404);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDiziSayaci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxBaslangicSatiri);
            this.Controls.Add(this.lblSatirSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.lblIslem);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lblDosyaOnay);
            this.Controls.Add(this.lblDosyaUzantisi);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BigDataReader";
            this.Text = "Big Data Reader";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtIcerik;
        private System.Windows.Forms.Label lblDosyaUzantisi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblDosyaOnay;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblIslem;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSatirSayisi;
        private System.Windows.Forms.MaskedTextBox txtBoxBaslangicSatiri;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label lblDiziSayaci;
        private System.Windows.Forms.Label label4;
    }
}

