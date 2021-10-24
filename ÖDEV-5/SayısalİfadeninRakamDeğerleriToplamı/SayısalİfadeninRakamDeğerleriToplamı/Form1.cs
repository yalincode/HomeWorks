using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayısalİfadeninRakamDeğerleriToplamı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi = 0;
        int kalan=0;
        int toplamkalan = 0;
        int sonuc = 0;
        
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            sayi = Convert.ToInt32(textBox1.Text);

            while (sayi!=0)
            {
                
                kalan = sayi % 10;
                listBox1.Items.Add(kalan);
                toplamkalan += kalan;
                sonuc = sayi / 10;
                sayi = sonuc;
            }
            if (sayi == 0)
            {
                listBox1.Items.Add(listBox1.Items[0]+ "+"+ listBox1.Items[1]+ "+" + listBox1.Items[2] + " Rakamlarının Toplamı=> "+ toplamkalan);
            }      
        }
    }
}
