using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace KullanicilarLinq
{
    public partial class UrunEkle : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();
        public UrunEkle()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int urunKontrol = 0;
            urunKontrol= bll.UrunKontrol(textBox1.Text, comboBox1.Text, comboBox1.Text, comboBox2.Text, comboBox4.Text, comboBox3.Text, comboBox5.Text);
            if (urunKontrol>0)
            {
                MessageBox.Show("Kayıt Eklendi");
                
               
            }
            else
            {
                MessageBox.Show("Kayıt Eklenemedi");
            }

        }
    }
}
