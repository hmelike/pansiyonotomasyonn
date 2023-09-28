using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace PansiyonUygulaması.Formlar
{
    public partial class Stoklar : Form
    {
        public Stoklar()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2MT46KC;Initial Catalog=Pansiyon;Integrated Security=True");
        private void Stoklar_Load(object sender, EventArgs e)
        {
            // veriler();
        }
        private void veriler()
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select*from Stoklar", baglanti);
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gıda"].ToString();
                ekle.SubItems.Add(oku["İçecek"].ToString());
                ekle.SubItems.Add(oku["Çerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void giderler()
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select*from Giderler", baglanti);
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Elektrik"].ToString();
                ekle.SubItems.Add(oku["Su"].ToString());
                ekle.SubItems.Add(oku["Dogalgaz"].ToString());
                ekle.SubItems.Add(oku["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void temizle()
        {
            TxtAtistirmalik.Text = " ";
            TxtGidaTutar.Text = " ";
            TxtİcecekTutar.Text = " ";
}
        private void temizle2()
        {
            txtelektrik.Text = "";
            Txtsu.Text = "";
            TxtDogalgaz.Text = "";
            Txtinternet.Text = "";
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand kmt = new SqlCommand("insert into Stoklar (Gıda,İçecek,Çerezler) values ('" + TxtGidaTutar.Text + "','" + TxtİcecekTutar.Text + "','" + TxtAtistirmalik.Text + "')", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
            temizle();
            veriler();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Kaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("insert into Giderler (Elektrik,Su,Dogalgaz,İnternet) values ('" + txtelektrik.Text + "','" + Txtsu.Text + "','" + TxtDogalgaz.Text + "','"+Txtinternet.Text+"')", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
            temizle2();
            giderler();
        }
    }
}
