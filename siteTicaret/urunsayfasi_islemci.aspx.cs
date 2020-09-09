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
    public partial class urunsayfasi_islemci : System.Web.UI.Page
    {
        public string resim;
        public string islemciadi;
        public string marka;
        public double fiyat;
        public int stok;
        public string islemcisokettipi;
        public string islemcinumarasi;
        public string islemciteknolojisi;
        public string islemcihizi;
        public string islemcionbellek;
        public string mensei;
        public string garanti;
        public string kutulukutusuz;
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
            SqlCommand cmd = new SqlCommand("select * from IslemciUrunler where IslemciUrunID=@secim");
            cmd.Connection = baglan.baglan();
            cmd.Parameters.AddWithValue("@secim", Request.QueryString["secim"]);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            resim = dt.Rows[0]["resim1"].ToString();
            islemciadi = dt.Rows[0]["IslemciAdi"].ToString();
            marka = dt.Rows[0]["Marka"].ToString();
            fiyat = Convert.ToDouble(dt.Rows[0]["Fiyat"]);
            stok = Convert.ToInt32(dt.Rows[0]["Stok"]);
            islemcisokettipi = dt.Rows[0]["IslemciSoketTipi"].ToString();
            islemcinumarasi = dt.Rows[0]["IslemciNumarasi"].ToString();
            islemciteknolojisi = dt.Rows[0]["IslemciTeknolojisi"].ToString();
            islemcihizi = dt.Rows[0]["IslemciHizi"].ToString();
            islemcionbellek = dt.Rows[0]["IslemciOnBellek"].ToString();
            kutulukutusuz = dt.Rows[0]["KutuluKutusuz"].ToString();
            mensei = dt.Rows[0]["Mensei"].ToString();
            garanti = dt.Rows[0]["Garanti"].ToString();

            try
            {
                if (Session["UyeID"] == null)
                {
                    SqlCommand cmdYorumCek = new SqlCommand("select * from Yorumlar where UrunID=@yorumsec and TurID=@TurID");
                    cmdYorumCek.Connection = baglan.baglan();
                    cmdYorumCek.Parameters.AddWithValue("@yorumsec", Request.QueryString["secim"]);
                    string yorumturu = "Islemci";
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

                    SqlCommand cmdYorumCek = new SqlCommand("select * from Yorumlar where TurID=@TurID and UrunID=@yorumsec");
                    cmdYorumCek.Connection = baglan.baglan();
                    cmdYorumCek.Parameters.AddWithValue("@yorumsec", Request.QueryString["secim"]);
                    string yorumturu = "Islemci";
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
                    string yorumturu = "Islemci";
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
                    cmdSepeteEkle.Parameters.AddWithValue("@UrunAdi", islemciadi);
                    cmdSepeteEkle.Parameters.AddWithValue("@UrunResim", resim);
                    cmdSepeteEkle.Parameters.AddWithValue("@UrunAdet", Convert.ToInt32(listUrunAdet.Value));
                    cmdSepeteEkle.Parameters.AddWithValue("@UrunFiyat", fiyat);
                    cmdSepeteEkle.Parameters.AddWithValue("@ToplamFiyat", toplamfiyat);
                    cmdSepeteEkle.Parameters.AddWithValue("@TurID", "Islemci");
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