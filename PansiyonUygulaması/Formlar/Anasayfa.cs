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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
            richTextBox1.Text = "Melike Pansiyon, Antalya'nın batısında masmavi denizin çam ormanları ile birleştiği huzurlu tatil beldesi Adrasan'da bulunmaktadır. " +
                "Adrasan sahiline yürüme mesafesinde bulunan tesis portakal ve nar ağaçlarıyla çevrili geniş bir bahçeye sahiptir. " +
                "Bahçesindeki hamaklar ve köşkler gün boyu narenciye kokuları ve kuş sesleri eşliğinde keyifli vakit geçirebileceğiniz dinlenme ortamları sunmaktadır. " +
                "Ayrıca bahçede çocuklar için oyun alanı bulunmaktadır. Pansiyonun tüm odalarında televizyon, klima, mini buzdolabı, elbise dolabı, duş, WC, 24 saat sıcak su, balkon ve kablosuz internet imkanları sunulmaktadır." +
                " 24 saat resepsiyon, ücretsiz gazete, ücretsiz özel otopark, araç kiralama, çamaşırhane gibi olanaklar sunan pansiyonda talep halinde havaalanı transfer hizmeti de verilmektedir. " +
                "Yarım pansiyon konseptte hizmet veren çiçek Pansiyon'da organik ürünler, hormonsuz bahçe domatesleri ve köy peynirlerinin sunulduğu açık büfe kahvaltı servis edilmektedir. " +
                "Akşam yemeklerinde konukların özel istekleri de dikkate alınarak balık ızgaralar, zeytin yağlılar ve yöresel yemekler ile pansiyonun bahçesinde keyifli sofralar kurulmaktadır. " +
                "Pansiyon, sunduğu samimi aile ortamı ve işletmecilerinin konukseverliği ile ön plana çıkmaktadır. " +
                "Bölgede su altı görüş mesafesinin 20 metrenin üzerinde oluşu ve sıcak iklimi sayesinde su sporları için son derece elverişli bir coğrafya sunmaktadır. " +
                "Ayrıca yakın çevreye düzenlenen günübirlik tekne turlarına katılma imkanı bulunmaktadır. çiçek Pansiyon Antalya şehir merkezine 94 km, Kemer'e 55 km, Olimpos'a 10km mesafededir";

        }
    }
}
