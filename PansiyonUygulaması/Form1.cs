using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using DevExpress.Skins;
using System.Data.Sql;
using System.Data.SqlClient;



namespace PansiyonUygulaması
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2MT46KC;Initial Catalog=Pansiyon;Integrated Security=True");
        private void AnasayfaBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Anasayfa As = new Formlar.Anasayfa();
            As.MdiParent = this;
            As.Show();
        }

       
     

        private void Form1_Load(object sender, EventArgs e)
        {
            Formlar.Anasayfa a = new Formlar.Anasayfa();
            a.MdiParent = this;
            a.Show();
        }

        private void MusterilerBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.Müsteriler m = new Formlar.Müsteriler();
            m.MdiParent = this;
            m.Show();
        }

        private void BtnOdalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.Odalar o = new Formlar.Odalar();
            o.MdiParent = this;
            o.Show();
        }

        private void YeniMüsteri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.YeniMüsteri Ym = new Formlar.YeniMüsteri();
            Ym.MdiParent = this;
            Ym.Show();

        }

        private void StoklarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.Stoklar S = new Formlar.Stoklar();
            S.MdiParent = this;
            S.Show();
        }

        private void RadyoBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.Radyo R = new Formlar.Radyo();
            R.MdiParent = this;
            R.Show();

        }

        private void MüsteriMesajlariBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.MüsteriMesajlari mm = new Formlar.MüsteriMesajlari();
            mm.MdiParent = this;
            mm.Show();

        }
    }
}
