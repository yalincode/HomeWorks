using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5SayınınKaresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi = 0;
        int Toplam = 0;
        int i = 0;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            i++;//Her buttona basıldığında i değeri artacak.
            while (i<=5)
            {
                label1.Text = (i+1) + ". Sayıyı gir";
                sayi = Convert.ToInt32(txtHesapla.Text);
                lstHesap.Items.Add(sayi*sayi+" "+i+". sayının karesi");

                Toplam += sayi*sayi;
                break;//Her seferinde buttona basılması için break koydum. 
            }

            if (i==5)
            {
                lstHesap.Items.Add("Sonuç=>"+Toplam);
                label1.Text = "Sonuç Hesaplandı";
            }
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
