
namespace _5SayınınKaresi
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
            this.txtHesapla = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lstHesap = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHesapla
            // 
            this.txtHesapla.Location = new System.Drawing.Point(56, 88);
            this.txtHesapla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHesapla.Name = "txtHesapla";
            this.txtHesapla.Size = new System.Drawing.Size(242, 26);
            this.txtHesapla.TabIndex = 0;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(56, 128);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(244, 48);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lstHesap
            // 
            this.lstHesap.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstHesap.FormattingEnabled = true;
            this.lstHesap.ItemHeight = 20;
            this.lstHesap.Location = new System.Drawing.Point(365, 0);
            this.lstHesap.Name = "lstHesap";
            this.lstHesap.Size = new System.Drawing.Size(218, 357);
            this.lstHesap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "1.Sayıyı Gir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstHesap);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtHesapla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHesapla;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ListBox lstHesap;
        private System.Windows.Forms.Label label1;
    }
}

