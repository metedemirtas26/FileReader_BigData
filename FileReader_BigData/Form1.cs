using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReader_BigData
{
    public partial class BigDataReader : Form
    {
        public BigDataReader()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            btnRight.Enabled = false;
            btnYazdır.Enabled = false;
            btnKopyala.Enabled = false;
        }

        public string dosyaYolu;
        int currentSatir = 0;
        int satirAraligi = 100;
        string line;
        int sonSatir;
        int diziSayaci = 0;
        List<string> lines = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblDosyaUzantisi.Text = openFileDialog1.FileName;
                dosyaYolu = lblDosyaUzantisi.Text;
                lblDosyaOnay.Text = "Dosya Seçildi";
                progressBar1.Value = 0;
                btnYazdır.Enabled = true;
            }
        }

        private void btnYazdır_Click_1(object sender, EventArgs e)
        {
            txtIcerik.Text = "";
            IlkYazdirmaIslemi();
            YazdirmaIslemi();
            btnRight.Enabled = true;
            btnYazdır.Enabled = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            TextBoxDoldur();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblIslem.Text = "işlem bitti..";
            progressBar1.Value = 0;
            btnRight.Enabled = true;
            txtBoxBaslangicSatiri.Text = currentSatir.ToString();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            satirAraligi = Convert.ToInt32(maskedTextBox1.Text);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                txtIcerik.Text = "";
                currentSatir += satirAraligi;
                YazdirmaIslemi();
            }
            catch (Exception)
            {
                MessageBox.Show("Satır Aralığını Aştınız");
            }

        }

        private void IlkYazdirmaIslemi()
        {
            btnKopyala.Enabled = true;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker2.WorkerReportsProgress = true;
            backgroundWorker2.RunWorkerAsync();
        }

        private void DiziyeAktar() {
            StreamReader file = new StreamReader(dosyaYolu);
            sonSatir = satirAraligi + currentSatir;

            while (file.ReadLine() != null)
            {
                diziSayaci++;
                lines.Add(file.ReadLine());
                lblDiziSayaci.Text = diziSayaci.ToString();
            }
            lblSatirSayisi.Text = lines.Count().ToString();
            file.Close();
        }

        private void YazdirmaIslemi()
        {
            backgroundWorker1.RunWorkerAsync();
            lblIslem.Text = "İşlem Devam Ediyor..";
            btnYazdır.Enabled = false;
            btnRight.Enabled = false;
        }

        private void TextBoxDoldur()
        {
            txtIcerik.Text = "";
            int pToplam = 0;
            sonSatir = currentSatir + satirAraligi;
            for (int i = currentSatir, j = 0; i < sonSatir; i++, j++)
            {
                txtIcerik.Text += lines[i];
                pToplam += (100 / lines.Count);
                backgroundWorker1.ReportProgress(pToplam);
                //progressBar1.Value = pToplam;
                lblSayac.Text = j.ToString();
            }
        }

        private void txtBoxBaslangicSatiri_TextChanged(object sender, EventArgs e)
        {
            currentSatir = Convert.ToInt32(txtBoxBaslangicSatiri.Text);
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtIcerik.Text);
            AutoClosingMessageBox.Show("İçerik Kopyalandı..", "! Mesaj", 1000);
        }

        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            DiziyeAktar();
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            diziSayaci = 0;
            lblSatirSayisi.Text = lines.Count().ToString();
        }

       

    }
}
