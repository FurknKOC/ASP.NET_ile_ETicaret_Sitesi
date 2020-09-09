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
    public partial class urunsayfasi : System.Web.UI.Page
    {
        public string resim;
        public string resim2;
        public string resim3;
        public string resim4;
        public string anakartadi;
        public string marka;
        public double fiyat;
        public int stok;
        public string yapi;
        public string islemcisokettipi;
        public string ramtipi;
        public string mbchipseti;
        public string mbramslotsayisi;
        public string spdifcikisi;
        public string ps2;
        public string sekizkanal;
        public string ethernet;
        public string kablosuzwifi;
        public string usb2;
        public string usb3;
        public string clearcmosbuton;
        public string supremefx;
        public string bluetooth;
        public string ses;
        public string pciexpress;
        public string sata3;
        public string sataexpress;
        public string m2sata;
        public string corei7;
        public string mensei;
        public string garanti;
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
            SqlCommand cmd = new SqlCommand("select * from AnakartUrunler where AnakartUrunID=@secim");
            cmd.Connection = baglan.baglan();
            cmd.Parameters.AddWithValue("@secim", Request.QueryString["secim"]);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            resim = dt.Rows[0]["resim1"].ToString();
            resim2 = dt.Rows[0]["resim2"].ToString();
            resim3 = dt.Rows[0]["resim3"].ToString();
            resim4 = dt.Rows[0]["resim4"].ToString();
            anakartadi = dt.Rows[0]["AnakartAdi"].ToString();
            marka = dt.Rows[0]["Marka"].ToString();
            fiyat = Convert.ToDouble(dt.Rows[0]["Fiyat"]);
            stok = Convert.ToInt32(dt.Rows[0]["Stok"]);
            yapi = dt.Rows[0]["Yapi"].ToString();
            islemcisokettipi = dt.Rows[0]["IslemciSoketTipi"].ToString();
            ramtipi = dt.Rows[0]["RamTipi"].ToString();
            mbchipseti = dt.Rows[0]["MbChipseti"].ToString();
            mbramslotsayisi = dt.Rows[0]["MbRamSlotSayisi"].ToString();
            spdifcikisi = dt.Rows[0]["SpdifCikisi"].ToString();
            ps2 = dt.Rows[0]["Ps2"].ToString();
            sekizkanal = dt.Rows[0]["Sekizkanal"].ToString();
            ethernet = dt.Rows[0]["Ethernet"].ToString();
            kablosuzwifi = dt.Rows[0]["KablosuzWifi"].ToString();
            usb2 = dt.Rows[0]["usb2"].ToString();
            usb3 = dt.Rows[0]["usb3"].ToString();
            clearcmosbuton = dt.Rows[0]["ClearCmosButon"].ToString();
            supremefx = dt.Rows[0]["SupremeFX"].ToString();
            bluetooth = dt.Rows[0]["Bluetooth"].ToString();
            ses = dt.Rows[0]["Ses"].ToString();
            pciexpress = dt.Rows[0]["PciExpress"].ToString();
            sata3 = dt.Rows[0]["Sata3"].ToString();
            sataexpress = dt.Rows[0]["SataExpress"].ToString();
            m2sata = dt.Rows[0]["M2Sata"].ToString();
            corei7 = dt.Rows[0]["CoreI7"].ToString();
            mensei = dt.Rows[0]["Mensei"].ToString();
            garanti = dt.Rows[0]["Garanti"].ToString();

            try
            {
                if (Session["UyeID"] == null)
                {
                    SqlCommand cmdYorumCek = new SqlCommand("select * from Yorumlar where UrunID=@yorumsec and TurID=@TurID");
                    cmdYorumCek.Connection = baglan.baglan();
                    cmdYorumCek.Parameters.AddWithValue("@yorumsec", Request.QueryString["secim"]);
                    string yorumturu = "Anakart";
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
                    string yorumturu = "Anakart";
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
                    string yorumturu = "Anakart";
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
                    cmdSepeteEkle.Parameters.AddWithValue("@UrunAdi", anakartadi);
                    cmdSepeteEkle.Parameters.AddWithValue("@UrunResim", resim);
                    cmdSepeteEkle.Parameters.AddWithValue("@UrunAdet", Convert.ToInt32(listUrunAdet.Value));
                    cmdSepeteEkle.Parameters.AddWithValue("@UrunFiyat", fiyat);
                    cmdSepeteEkle.Parameters.AddWithValue("@ToplamFiyat", toplamfiyat);
                    cmdSepeteEkle.Parameters.AddWithValue("@TurID", "Anakart");
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