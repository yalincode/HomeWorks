
namespace SuFaturasiHesabi_HW_6_
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.aaa = new System.Windows.Forms.Label();
            this.bbb = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtIlkIn = new System.Windows.Forms.TextBox();
            this.txtSonIn = new System.Windows.Forms.TextBox();
            this.rbUmumi = new System.Windows.Forms.RadioButton();
            this.rbMesken = new System.Windows.Forms.RadioButton();
            this.lstAdSoyad = new System.Windows.Forms.ListBox();
            this.lstSuMiktari = new System.Windows.Forms.ListBox();
            this.lstFaturaTutari = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.KullanimYeri = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.KullanimYeri.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad ve Soyad";
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Location = new System.Drawing.Point(192, 77);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(70, 17);
            this.aaa.TabIndex = 1;
            this.aaa.Text = "Son Index";
            // 
            // bbb
            // 
            this.bbb.AutoSize = true;
            this.bbb.Location = new System.Drawing.Point(203, 116);
            this.bbb.Name = "bbb";
            this.bbb.Size = new System.Drawing.Size(58, 17);
            this.bbb.TabIndex = 2;
            this.bbb.Text = "Ilk Index";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(268, 33);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(319, 23);
            this.txtAd.TabIndex = 3;
            // 
            // txtIlkIn
            // 
            this.txtIlkIn.Location = new System.Drawing.Point(268, 110);
            this.txtIlkIn.Name = "txtIlkIn";
            this.txtIlkIn.Size = new System.Drawing.Size(319, 23);
            this.txtIlkIn.TabIndex = 4;
            this.txtIlkIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIlkIn_KeyPress);
            // 
            // txtSonIn
            // 
            this.txtSonIn.Location = new System.Drawing.Point(268, 71);
            this.txtSonIn.Name = "txtSonIn";
            this.txtSonIn.Size = new System.Drawing.Size(319, 23);
            this.txtSonIn.TabIndex = 5;
            this.txtSonIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSonIn_KeyPress);
            // 
            // rbUmumi
            // 
            this.rbUmumi.AutoSize = true;
            this.rbUmumi.Location = new System.Drawing.Point(17, 33);
            this.rbUmumi.Name = "rbUmumi";
            this.rbUmumi.Size = new System.Drawing.Size(69, 21);
            this.rbUmumi.TabIndex = 8;
            this.rbUmumi.TabStop = true;
            this.rbUmumi.Text = "Umumi";
            this.rbUmumi.UseVisualStyleBackColor = true;
            this.rbUmumi.CheckedChanged += new System.EventHandler(this.rbUmumi_CheckedChanged);
            // 
            // rbMesken
            // 
            this.rbMesken.AutoSize = true;
            this.rbMesken.Location = new System.Drawing.Point(104, 33);
            this.rbMesken.Name = "rbMesken";
            this.rbMesken.Size = new System.Drawing.Size(75, 21);
            this.rbMesken.TabIndex = 9;
            this.rbMesken.TabStop = true;
            this.rbMesken.Text = "Mesken";
            this.rbMesken.UseVisualStyleBackColor = true;
            this.rbMesken.CheckedChanged += new System.EventHandler(this.rbMesken_CheckedChanged);
            // 
            // lstAdSoyad
            // 
            this.lstAdSoyad.FormattingEnabled = true;
            this.lstAdSoyad.ItemHeight = 16;
            this.lstAdSoyad.Location = new System.Drawing.Point(11, 299);
            this.lstAdSoyad.Name = "lstAdSoyad";
            this.lstAdSoyad.Size = new System.Drawing.Size(188, 276);
            this.lstAdSoyad.TabIndex = 7;
            // 
            // lstSuMiktari
            // 
            this.lstSuMiktari.FormattingEnabled = true;
            this.lstSuMiktari.ItemHeight = 16;
            this.lstSuMiktari.Location = new System.Drawing.Point(216, 299);
            this.lstSuMiktari.Name = "lstSuMiktari";
            this.lstSuMiktari.Size = new System.Drawing.Size(188, 276);
            this.lstSuMiktari.TabIndex = 8;
            // 
            // lstFaturaTutari
            // 
            this.lstFaturaTutari.FormattingEnabled = true;
            this.lstFaturaTutari.ItemHeight = 16;
            this.lstFaturaTutari.Location = new System.Drawing.Point(417, 299);
            this.lstFaturaTutari.Name = "lstFaturaTutari";
            this.lstFaturaTutari.Size = new System.Drawing.Size(188, 276);
            this.lstFaturaTutari.TabIndex = 9;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(439, 224);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(148, 26);
            this.btnHesapla.TabIndex = 11;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // KullanimYeri
            // 
            this.KullanimYeri.Controls.Add(this.rbUmumi);
            this.KullanimYeri.Controls.Add(this.rbMesken);
            this.KullanimYeri.Location = new System.Drawing.Point(268, 139);
            this.KullanimYeri.Name = "KullanimYeri";
            this.KullanimYeri.Size = new System.Drawing.Size(319, 79);
            this.KullanimYeri.TabIndex = 12;
            this.KullanimYeri.TabStop = false;
            this.KullanimYeri.Text = "Kullanım Yeri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ad ve Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kullanım Suyu Miktarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fatura Tutarı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 586);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KullanimYeri);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lstFaturaTutari);
            this.Controls.Add(this.lstSuMiktari);
            this.Controls.Add(this.lstAdSoyad);
            this.Controls.Add(this.txtSonIn);
            this.Controls.Add(this.txtIlkIn);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.bbb);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KullanimYeri.ResumeLayout(false);
            this.KullanimYeri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.Label bbb;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtIlkIn;
        private System.Windows.Forms.TextBox txtSonIn;
        private System.Windows.Forms.RadioButton rbUmumi;
        private System.Windows.Forms.RadioButton rbMesken;
        private System.Windows.Forms.ListBox lstAdSoyad;
        private System.Windows.Forms.ListBox lstSuMiktari;
        private System.Windows.Forms.ListBox lstFaturaTutari;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox KullanimYeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

