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
    public partial class MüsteriMesajlari : Form
    {
        public MüsteriMesajlari()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2MT46KC;Initial Catalog=Pansiyon;Integrated Security=True");
        private void verigöster()
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select * from TBL_Mesajlar", baglanti);
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = oku["Mesajid"].ToString();
                add.SubItems.Add(oku["AdSoyad"].ToString());
                add.SubItems.Add(oku["Mesaj"].ToString());
          

                listView1.Items.Add(add);

            }

            baglanti.Close();
        }
            private void MüsteriMesajlari_Load(object sender, EventArgs e)
        {
            verigöster();

        }
    }
}
