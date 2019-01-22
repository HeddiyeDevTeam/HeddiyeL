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
using DataLinq;

namespace KullanicilarLinq
{
    public partial class UrunEkle : Form
    {
        HeddiyeDataContext dt = new HeddiyeDataContext();
        BusinessLogicLayer bll = new BusinessLogicLayer();
        public UrunEkle()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dt = new HeddiyeDataContext();


            var linqEkle = dt.SP_UrunEkle(textBox1.Text, comboBox1.Text, comboBox2.Text, comboBox4.Text, comboBox3.Text, comboBox5.Text,textBox2.Text);



            int urunKontrol = 0;
            urunKontrol = bll.UrunKontrol(textBox1.Text, comboBox1.Text, comboBox1.Text, comboBox2.Text, comboBox4.Text, comboBox3.Text, comboBox5.Text);
            if (urunKontrol > 0)
            {


                MessageBox.Show("Kayıt Eklendi");


            }
            else
            {
                MessageBox.Show("Kayıt Eklenemedi");
            }

        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            dt = new HeddiyeDataContext();

            var cinsiyet = from cins in dt.Cinsiyets select cins;
            comboBox1.DataSource=cinsiyet;
            comboBox1.DisplayMember = "CinsiyetAdi";
            comboBox1.ValueMember = "CinsiyetId";

            var amac = from a in dt.HediyeAmacis select a;
            comboBox2.DataSource = amac;
            comboBox2.DisplayMember = "HediyeAmaci1";
            comboBox2.ValueMember = "HediyeAmacId";

            var yas = from c in dt.YasAraligis select c;
            comboBox3.DataSource = yas;
            comboBox3.DisplayMember = "YasAraligi1";
            comboBox3.ValueMember = "YasId";

            var burc = from d in dt.Burcs select d;
            comboBox5.DataSource = burc;
            comboBox5.DisplayMember = "BurcAdi";
            comboBox5.ValueMember = "BurcId";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var yakin = from b in dt.YakinlikDerecesis select b;
            if (comboBox1.SelectedIndex==0)
            {
                yakin = from b in dt.YakinlikDerecesis where b.CinsiyetId==1 select b;
            }

            else
            {
                yakin = from b in dt.YakinlikDerecesis where b.CinsiyetId == 2 select b;
            }
            comboBox4.DataSource = yakin;
            comboBox4.DisplayMember = "YakinlikDerecesi1";
            comboBox4.ValueMember = "YakinlikId";
          
        }
    }
}
