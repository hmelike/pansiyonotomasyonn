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
    public partial class Müsteriler : Form
    {
        public Müsteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2MT46KC;Initial Catalog=Pansiyon;Integrated Security=True");
        private void Müsteriler_Load(object sender, EventArgs e)
        {

        }
        private void verigöster()
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select * from TBL_Müsteri_Kaydet", baglanti);
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = oku["Müsteriid"].ToString();
                add.SubItems.Add(oku["Adı"].ToString());
                add.SubItems.Add(oku["Soyad"].ToString());
                add.SubItems.Add(oku["Cinsiyet"].ToString());
                add.SubItems.Add(oku["Telefon"].ToString());
                add.SubItems.Add(oku["Mail"].ToString());
                add.SubItems.Add(oku["TC"].ToString());
                add.SubItems.Add(oku["OdaNo"].ToString());
                add.SubItems.Add(oku["Ücret"].ToString());
                add.SubItems.Add(oku["GirişTarih"].ToString());
                add.SubItems.Add(oku["ÇıkışTarih"].ToString());

                listView1.Items.Add(add);

            }

            baglanti.Close();

        }
        private void temizle()
        {
            TxrAd.Text = "";
            TxtSoyad.Text = "";
            TxtMail.Text = "";
            CombxCinsiyet.Text = "";
            TxtTC.Text = "";
            MskdTelefon.Text = "";
            TxtOdaNo.Text = "";
            TxtUcret.Text = "";
            GirisTarih.Text = "";
            dateTimePicker2.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verigöster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxrAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CombxCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskdTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTC.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            GirisTarih.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dateTimePicker2.Text  = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
           
            if(TxtOdaNo.Text=="101")
            {
                baglanti.Open();
                SqlCommand kmt = new SqlCommand("delete from Oda101",baglanti);
                kmt.ExecuteNonQuery();
                baglanti.Close();
            }
            

            //102
            
            if (TxtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand kmt = new SqlCommand("delete from Oda102", baglanti);
                kmt.ExecuteNonQuery();

                baglanti.Close();

            }

            //103
            if (TxtOdaNo.Text == "103")
                
            
            {
                baglanti.Open();
                SqlCommand kmt = new SqlCommand("delete from Oda103", baglanti);
                kmt.ExecuteNonQuery();
                baglanti.Close();

            }
            
            //104
          
            if (TxtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand kmt = new SqlCommand("delete from Oda104", baglanti);
                kmt.ExecuteNonQuery();
                baglanti.Close();
            }
            //105
           
            if (TxtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand kmt = new SqlCommand("delete from Oda105", baglanti);
                kmt.ExecuteNonQuery();
                baglanti.Close();
            }
            //106
           
            if (TxtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand kmt = new SqlCommand("delete from Oda106", baglanti);
                kmt.ExecuteNonQuery();
                baglanti.Close();
            }
            //107
         
            if (TxtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand kmt = new SqlCommand("delete from Oda107", baglanti);
                kmt.ExecuteNonQuery();
                baglanti.Close();
            }
            //108
           
            if (TxtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand kmt = new SqlCommand("delete from Oda108", baglanti);
                kmt.ExecuteNonQuery();
                baglanti.Close();
            }
            //109
          
            if (TxtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand kmt = new SqlCommand("delete from Oda109", baglanti);
                kmt.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("update TBL_Müsteri_Kaydet set Adı='" + TxrAd.Text + "',Soyad='" + TxtSoyad.Text + "',Cinsiyet='" + CombxCinsiyet.Text + "',Telefon='" + MskdTelefon.Text + "',Mail ='" + TxtMail.Text + "', TC ='" + TxtTC.Text + "',OdaNo='" + TxtOdaNo.Text + "' ,Ücret='" + TxtUcret.Text + "',GirişTarih='" + GirisTarih.Value.ToString("yyyy-MM-dd") + "',ÇıkışTarih='"+dateTimePicker2.Value.ToString("yyyy-MM-dd")+"' where Müsteriid=" + id + "", baglanti);

            kmt.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("Select * From TBL_Müsteri_Kaydet where Adı like'%"+TxtAra.Text+"%'", baglanti);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["Müsteriid"].ToString();
                add.SubItems.Add(read["Adı"].ToString());
                add.SubItems.Add(read["Soyad"].ToString());
                add.SubItems.Add(read["Cinsiyet"].ToString());
                add.SubItems.Add(read["Telefon"].ToString());
                add.SubItems.Add(read["Mail"].ToString());
                add.SubItems.Add(read["TC"].ToString());
                add.SubItems.Add(read["OdaNo"].ToString());
                add.SubItems.Add(read["Ücret"].ToString());
                add.SubItems.Add(read["GirişTarih"].ToString());
                add.SubItems.Add(read["ÇıkışTarih"].ToString());

                listView1.Items.Add(add);


            }

            baglanti.Close();
        }

        // SqlCommand kmt = new SqlCommand("delete From TBL_Müsteri_Kaydet where Müsteriid=(" + id + ")", baglanti);
      //  kmt.ExecuteNonQuery();
          //  baglanti.Close();
          //  temizle();
    }
}
