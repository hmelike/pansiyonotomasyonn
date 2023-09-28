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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2MT46KC;Initial Catalog=Pansiyon;Integrated Security=True");
        private void Odalar_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand kmt1 = new SqlCommand("select* from Oda101", baglanti);
            SqlDataReader oku1 = kmt1.ExecuteReader();
            while  (oku1.Read())
            {
                Btn101.Text = oku1["Adı"].ToString() + " " + oku1["soyadı"].ToString();
            }
            baglanti.Close();
            if(Btn101.Text!="101")
            {
                Btn101.BackColor = Color.Red;
            }
            ///102
            baglanti.Open();
            SqlCommand kmt2 = new SqlCommand("select* from Oda102", baglanti);
            SqlDataReader oku2 = kmt2.ExecuteReader();
            while (oku2.Read())
            {
                Btn102.Text = oku2["Adı"].ToString() + " " + oku2["soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn102.Text != "102")
            {
                Btn102.BackColor = Color.Red;
            }
            //103
            baglanti.Open();
            SqlCommand kmt3 = new SqlCommand("select* from Oda103", baglanti);
            SqlDataReader oku3 = kmt3.ExecuteReader();
            while (oku3.Read())
            {
                Btn103.Text = oku3["Adı"].ToString() + " " + oku3["soyadı"].ToString();
            }
            baglanti.Close();

            if (Btn103.Text != "103")
            {
                Btn103.BackColor = Color.Red;
            }


            ////104
               baglanti.Open();
            SqlCommand kmt4 = new SqlCommand("select* from Oda104", baglanti);
            SqlDataReader oku4 = kmt4.ExecuteReader();
            while (oku4.Read())
            {
                Btn104.Text = oku4["Adı"].ToString() + " " + oku4["soyadı"].ToString();
            }
            baglanti.Close();

            if (Btn104.Text != "104")
            {
                Btn104.BackColor = Color.Red;
            }
            ////105
              baglanti.Open();
            SqlCommand kmt5 = new SqlCommand("select* from Oda105", baglanti);
            SqlDataReader oku5 = kmt5.ExecuteReader();
            while (oku5.Read())
            {
                Btn105.Text = oku2["Adı"].ToString() + " " + oku5["soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn105.Text != "105")
            {
                Btn105.BackColor = Color.Red;
            }
            ///106
            baglanti.Open();
            SqlCommand kmt6 = new SqlCommand("select* from Oda106", baglanti);
            SqlDataReader oku6 = kmt6.ExecuteReader();
            while (oku6.Read())
            {
                Btn106.Text = oku6["Adı"].ToString() + " " + oku6["soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn106.Text != "106")
            {
                Btn106.BackColor = Color.Red;
            }

            ///107
            ///
            baglanti.Open();
            SqlCommand kmt7 = new SqlCommand("select* from Oda107", baglanti);
            SqlDataReader oku7 = kmt7.ExecuteReader();
            while (oku7.Read())
            {
                Btn107.Text = oku7["Adı"].ToString() + " " + oku7["soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn107.Text != "107")
            {
                Btn107.BackColor = Color.Red;
            }

            ///108
            ///  
            baglanti.Open();
            SqlCommand kmt8 = new SqlCommand("select* from Oda108", baglanti);
            SqlDataReader oku8 = kmt8.ExecuteReader();
            while (oku8.Read())
            {
                Btn108.Text = oku8["Adı"].ToString() + " " + oku8["soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn108.Text != "108")
            {
                Btn108.BackColor = Color.Red;
            }
            /////109
            baglanti.Open();
            SqlCommand kmt9 = new SqlCommand("select* from Oda109", baglanti);
            SqlDataReader oku9 = kmt9.ExecuteReader();
            while (oku9.Read())
            {
                Btn109.Text = oku9["Adı"].ToString() + " " + oku9["soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn109.Text != "109")
            {
                Btn109.BackColor = Color.Red;
            }
        }
    }
}