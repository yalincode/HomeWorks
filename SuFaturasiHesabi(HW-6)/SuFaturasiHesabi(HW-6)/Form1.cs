using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuFaturasiHesabi_HW_6_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string AdSoyad = "";
        double KullanilanSu = 0;
        double fiyat = 0;
        double artikSu = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            AdSoyad = txtAd.Text;
            
            KullanilanSu = (Convert.ToDouble(txtSonIn.Text) - Convert.ToDouble(txtIlkIn.Text));
            if (KullanilanSu>0)
            {
                lstAdSoyad.Items.Add(AdSoyad);
                lstSuMiktari.Items.Add($"{KullanilanSu} m3' tür.");
            }
            
            if (rbUmumi.Checked==true)
            {   
                rbMesken.Checked = false;
                fiyat = 0.3 * KullanilanSu;
                if (fiyat>0)
                {
                    lstFaturaTutari.Items.Add($"{fiyat} TL");
                }
                else
                {
                    MessageBox.Show("Düzgün sayı girişi yapılmalıdır.");
                }
            }
            else if (rbMesken.Checked==true)
            { 
                rbUmumi.Checked = false;
                artikSu = KullanilanSu * 30 / 100;
                fiyat = (0.7 * KullanilanSu)+(artikSu*0.2);
                if (fiyat > 0)
                {
                    lstFaturaTutari.Items.Add($"{fiyat} TL");
                }
                else
                {
                    MessageBox.Show("Düzgün sayı girişi yapılmalıdır.");
                }     
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnHesapla.Enabled = false;

        }
        private void rbUmumi_CheckedChanged(object sender, EventArgs e)
        {
            btnHesapla.Enabled = true;
        }
        private void rbMesken_CheckedChanged(object sender, EventArgs e)
        {
            btnHesapla.Enabled = true;
        }
        private void txtSonIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&& !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtIlkIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
