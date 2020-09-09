using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace siteTicaret
{
    public partial class urunsayfasi_ekrankartlari : System.Web.UI.Page
    {
        public string resim;
        public string resim2;
        public string resim3;
        public string ekrankartiadi;
        public string marka;
        public double fiyat;
        public int stok;
        public string cekirdekhizi;
        public string ramkapasitesi;
        public string bellekhizi;
        public string grafikchipsetimarkasi;
        public string ekrankartichipseti;
        public string bellektipi;
        public string bellekarayuzu;
        public string pciexpress3;
        public string displayport;
        public string hdcpdestegi;
        public string dvi;
        public string hdmi;
        public string guctuketimi;
        public string mensei;
        public string garanti;
        public string cozunurluk;
        public string secim;
        public string ad;
        public string soyad;
        public int uyeid;
        public string adsoyad;
        public string yorumbasligi;
        public string yorum;
        public int yorumsayisi;
        public string[] adsoyadlar;
        public string[] yorumbasliklari;
        public string[] yorumlar;
        public string KullaniciID;
        public double toplamfiyat;

        sqlbaglantisi baglan = new sqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from EkranKartiUrunler where EkranKartiUrunID=@secim");
            cmd.Connection = baglan.baglan();
            cmd.Parameters.AddWithValue("@secim", Request.QueryString["secim"]);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            resim = dt.Rows[0]["resim1"].ToString();
            resim2 = dt.Rows[0]["resim2"].ToString();
            resim3 = dt.Rows[0]["resim3"].ToString();
            ekrankartiadi = dt.Rows[0]["EkranKartiAdi"].ToString();
            marka = dt.Rows[0]["Marka"].ToString();
            fiyat = Convert.ToDouble(dt.Rows[0]["Fiyat"]);
            stok = Convert.ToInt32(dt.Rows[0]["Stok"]);
            cekirdekhizi = dt.Rows[0]["CekirdekHizi"].ToString();
            ramkapasitesi = dt.Rows[0]["RamKapasitesi"].ToString();
            bellekhizi = dt.Rows[0]["BellekHizi"].ToString();
            grafikchipsetimarkasi = dt.Rows[0]["GrafikChipsetiMarkasi"].ToString();
            ekrankartichipseti = dt.Rows[0]["EkranKartiChipseti"].ToString();
            bellektipi = dt.Rows[0]["BellekTipi"].ToString();
            bellekarayuzu = dt.Rows[0]["BellekArayuzu"].ToString();
            pciexpress3 = dt.Rows[0]["PciExpress3"].ToString();
            displayport = dt.Rows[0]["DisplayPort"].ToString();
            hdcpdestegi = dt.Rows[0]["HdcpDestegi"].ToString();
            dvi = dt.Rows[0]["Dvi"].ToString();
            hdmi = dt.Rows[0]["Hdmi"].ToString();
            guctuketimi = dt.Rows[0]["GucTuketimi"].ToString();
            mensei = dt.Rows[0]["Mensei"].ToString();
            garanti = dt.Rows[0]["Garanti"].ToString();
            cozunurluk = dt.Rows[0]["Cozunurluk"].ToString();
            try
            {
                if (Session["UyeID"] == null)
                {
                    SqlCommand cmdYorumCek = new SqlCommand("select * from Yorumlar where UrunID=@yorumsec and TurID=@TurID");
                    cmdYorumCek.Connection = baglan.baglan();
                    cmdYorumCek.Parameters.AddWithValue("@yorumsec", Request.QueryString["secim"]);
                    string yorumturu = "EkranKartı";
                    cmdYorumCek.Parameters.AddWithValue("@TurID", yorumturu.ToString());
                    DataTable dtYorumCek = new DataTable();
                    SqlDataAdapter adpYorumCek = new SqlDataAdapter(cmdYorumCek);
                    adpYorumCek.Fill(dtYorumCek);
                    yorumsayisi = dtYorumCek.Rows.Count;

                    adsoyadlar = new string[yorumsayisi];
                    yorumbasliklari = new string[yorumsayisi];
                    yorumlar = new string[yorumsayisi];
                    for (int i = 0; i < yorumsayisi; i++)
                    {
                        adsoyadlar[i] = dtYorumCek.Rows[i]["AdSoyad"].ToString();
                        yorumbasliklari[i] = dtYorumCek.Rows[i]["YorumBasligi"].ToString();
                        yorumlar[i] = dtYorumCek.Rows[i]["Yorum"].ToString();
                    }
                }
                else
                {
                    SqlCommand cmdd = new SqlCommand("select * from Uyeler where UyeID=@UyeID");
                    cmdd.Connection = baglan.baglan();
                    KullaniciID = Session["UyeID"].ToString();
                    cmdd.Parameters.AddWithValue("@UyeID", KullaniciID);
                    DataTable dtt = new DataTable();
                    SqlDataAdapter adpp = new SqlDataAdapter(cmdd);
                    adpp.Fill(dtt);
                    uyeid = Convert.ToInt32(dtt.Rows[0]["UyeID"].ToString());
                    ad = dtt.Rows[0]["Ad"].ToString();
                    soyad = dtt.Rows[0]["Soyad"].ToString();
                    adsoyad = ad + " " + soyad;
                    lblAdSoyad.Text = adsoyad.ToString();

                    SqlCommand cmdYorumCek = new SqlCommand("select * from Yorumlar where UrunID=@yorumsec and TurID=@TurID");
                    cmdYorumCek.Connection = baglan.baglan();
                    cmdYorumCek.Parameters.AddWithValue("@yorumsec", Request.QueryString["secim"]);
                    string yorumturu = "EkranKartı";
                    cmdYorumCek.Parameters.AddWithValue("@TurID", yorumturu.ToString());
                    DataTable dtYorumCek = new DataTable();
                    SqlDataAdapter adpYorumCek = new SqlDataAdapter(cmdYorumCek);
                    adpYorumCek.Fill(dtYorumCek);
                    yorumsayisi = dtYorumCek.Rows.Count;

                    adsoyadlar = new string[yorumsayisi];
                    yorumbasliklari = new string[yorumsayisi];
                    yorumlar = new string[yorumsayisi];
                    for (int i = 0; i < yorumsayisi; i++)
                    {
                        adsoyadlar[i] = dtYorumCek.Rows[i]["AdSoyad"].ToString();
                        yorumbasliklari[i] = dtYorumCek.Rows[i]["YorumBasligi"].ToString();
                        yorumlar[i] = dtYorumCek.Rows[i]["Yorum"].ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["UyeID"] == null)
                    Response.Redirect("uyelik.aspx");
                else
                {
                    SqlCommand cmdYorumEkle = new SqlCommand("insert into Yorumlar (AdSoyad,YorumBasligi,Yorum,UyeID,UrunID,TurID) values (@AdSoyad,@YorumBasligi,@Yorum,@UyeID,@UrunID,@TurID)", baglan.baglan());
                    cmdYorumEkle.Connection = baglan.baglan();
                    string yorumturu = "EkranKartı";
                    cmdYorumEkle.Parameters.AddWithValue("@AdSoyad", adsoyad);
                    cmdYorumEkle.Parameters.AddWithValue("@YorumBasligi", txtYorumBasligi.Value.ToString());
                    cmdYorumEkle.Parameters.AddWithValue("@Yorum", txtYorum.Value.ToString());
                    cmdYorumEkle.Parameters.AddWithValue("@UyeID", uyeid);
                    cmdYorumEkle.Parameters.AddWithValue("@UrunID", Request.QueryString["secim"]);
                    cmdYorumEkle.Parameters.AddWithValue("@TurID", yorumturu);
                    cmdYorumEkle.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["UyeID"] == null)
                    Response.Redirect("uyelik.aspx");

                else
                {
                    SqlCommand cmdSepeteEkle = new SqlCommand("insert into Sepet (UyeID,UrunAdi,UrunResim,UrunAdet,UrunFiyat,ToplamFiyat,UrunID,TurID) values (@UyeID,@UrunAdi,@UrunResim,@UrunAdet,@UrunFiyat,@ToplamFiyat,@UrunID,@TurID)", baglan.baglan());
                    cmdSepeteEkle.Connection = baglan.baglan();

                    toplamfiyat = Convert.ToInt32(listUrunAdet.Value) * fiyat;

                    KullaniciID = Session["UyeID"].ToString();
                    cmdSepeteEkle.Parameters.AddWithValue("@UyeID", KullaniciID);
                    cmdSepeteEkle.Parameters.AddWithValue("@UrunAdi", ekrankartiadi);
                    cmdSepeteEkle.Parameters.AddWithValue("@UrunResim", resim);
                    cmdSepeteEkle.Parameters.AddWithValue("@UrunAdet", Convert.ToInt32(listUrunAdet.Value));
                    cmdSepeteEkle.Parameters.AddWithValue("@UrunFiyat", fiyat);
                    cmdSepeteEkle.Parameters.AddWithValue("@ToplamFiyat", toplamfiyat);
                    cmdSepeteEkle.Parameters.AddWithValue("@TurID", "EkranKartı");
                    cmdSepeteEkle.Parameters.AddWithValue("@UrunID", Request.QueryString["secim"]);
                    cmdSepeteEkle.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Response.Write("Bu işte bir iş var" + ex);
            }
        }
    }
}