using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıTahminEtmeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int sayiTahmin = 0;
        int sayiRandom = 0;
        int i = 0;
  
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            
            i++;
            sayiTahmin =Convert.ToInt32( txtTahmin.Text);
            
            if (sayiTahmin>sayiRandom)
            {
                listBox1.Items.Add(sayiTahmin);
                listBox1.Items.Add(i + ". tahmin");
                listBox1.Items.Add("Tahminini Azaltmalısın");
            }
            else if (sayiTahmin < sayiRandom)
            {
                listBox1.Items.Add(sayiTahmin);
                listBox1.Items.Add(i + ". tahmin");
                listBox1.Items.Add("Tahminini Arttırmalısın");
            }
            else if (sayiRandom==sayiTahmin)
            {
                listBox1.Items.Add(sayiTahmin);
                listBox1.Items.Add($"{i}. seferde sayıyı doğru tahmin ettiniz TEBRİKLER!!");
                btnTahmin.Enabled = false;
            }
            txtTahmin.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtTahmin.Text = "";
            btnTahmin.Enabled = true;
            listBox1.Items.Add("Tahmin Yapmaya başlayabilirsin");
            sayiRandom = rnd.Next(0, 101);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTahmin.Enabled = false;
        }
    }
}
