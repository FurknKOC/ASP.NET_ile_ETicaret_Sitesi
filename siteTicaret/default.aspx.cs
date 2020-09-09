using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace siteTicaret
{
    public partial class _default : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public int sayi;
        public int sayiSiparis;
        public int rastgele;
        public int UrunID;
        public string resim;
        public string[] adlar;
        public string[] resimler;
        public double[] fiyatlar;
        public int[] idler;
        public string[] siparisadlar;
        public string[] siparisresimler;
        public double[] siparisfiyatlar;
        public int[] siparisidler;
        public string[] SiparisTurIdler;
        protected void Page_Load(object sender, EventArgs e)
        {

            Random r = new Random();
            rastgele = r.Next(1,4);
            if (rastgele == 1)
            {
                SqlCommand cmd = new SqlCommand("select * from AnakartUrunler");
                cmd.Connection = baglan.baglan();

                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                sayi = dt.Rows.Count;
                if (sayi > 3)
                {
                    sayi = 3;
                    adlar = new string[3];
                    resimler = new string[3];
                    fiyatlar = new double[3];
                    idler = new int[3];
                    //Session["secim"] = Convert.ToInt32(dt.Rows[0]["AnakartUrunID"]);


                    for (int i = 0; i < 3; i++)
                    {
                        sayi = 3;
                        idler[i] = Convert.ToInt32(dt.Rows[i]["AnakartUrunID"]);
                        resimler[i] = dt.Rows[i]["resim1"].ToString();
                        adlar[i] = dt.Rows[i]["AnakartAdi"].ToString();
                        fiyatlar[i] = Convert.ToDouble(dt.Rows[i]["Fiyat"]);
                    }
                }
                else
                {
                    
                    adlar = new string[sayi];
                    resimler = new string[sayi];
                    fiyatlar = new double[sayi];
                    idler = new int[sayi];
                    //Session["secim"] = Convert.ToInt32(dt.Rows[0]["AnakartUrunID"]);


                    for (int i = 0; i < sayi; i++)
                    {
                        idler[i] = Convert.ToInt32(dt.Rows[i]["AnakartUrunID"]);
                        resimler[i] = dt.Rows[i]["resim1"].ToString();
                        adlar[i] = dt.Rows[i]["AnakartAdi"].ToString();
                        fiyatlar[i] = Convert.ToDouble(dt.Rows[i]["Fiyat"]);
                    }
                }
            }
            if (rastgele == 2)
            {
                SqlCommand cmd = new SqlCommand("select * from IslemciUrunler");
                cmd.Connection = baglan.baglan();

                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                sayi = dt.Rows.Count;
                if (sayi>4)
                {
                    
                    adlar = new string[4];
                    resimler = new string[4];
                    fiyatlar = new double[4];
                    idler = new int[4];
                    //Session["secim"] = Convert.ToInt32(dt.Rows[0]["AnakartUrunID"]);


                    for (int i = 0; i < 4; i++)
                    {
                        sayi = 4;
                        idler[i] = Convert.ToInt32(dt.Rows[i]["IslemciUrunID"]);
                        resimler[i] = dt.Rows[i]["resim1"].ToString();
                        adlar[i] = dt.Rows[i]["IslemciAdi"].ToString();
                        fiyatlar[i] = Convert.ToDouble(dt.Rows[i]["Fiyat"]);
                    }
                }
                else
                {
                    
                    adlar = new string[sayi];
                    resimler = new string[sayi];
                    fiyatlar = new double[sayi];
                    idler = new int[sayi];
                    //Session["secim"] = Convert.ToInt32(dt.Rows[0]["AnakartUrunID"]);


                    for (int i = 0; i < sayi; i++)
                    {
                        idler[i] = Convert.ToInt32(dt.Rows[i]["IslemciUrunID"]);
                        resimler[i] = dt.Rows[i]["resim1"].ToString();
                        adlar[i] = dt.Rows[i]["IslemciAdi"].ToString();
                        fiyatlar[i] = Convert.ToDouble(dt.Rows[i]["Fiyat"]);
                    }
                }
            }

            if (rastgele == 3)
            {
                SqlCommand cmd = new SqlCommand("select * from EkranKartiUrunler");
                cmd.Connection = baglan.baglan();

                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                sayi = dt.Rows.Count;
                if (sayi > 4)
                {

                    adlar = new string[4];
                    resimler = new string[4];
                    fiyatlar = new double[4];
                    idler = new int[4];
                    //Session["secim"] = Convert.ToInt32(dt.Rows[0]["AnakartUrunID"]);


                    for (int i = 0; i < 4; i++)
                    {
                        sayi = 4;
                        idler[i] = Convert.ToInt32(dt.Rows[i]["EkranKartiUrunID"]);
                        resimler[i] = dt.Rows[i]["resim1"].ToString();
                        adlar[i] = dt.Rows[i]["EkranKartiAdi"].ToString();
                        fiyatlar[i] = Convert.ToDouble(dt.Rows[i]["Fiyat"]);
                    }
                }
                else
                {

                    adlar = new string[sayi];
                    resimler = new string[sayi];
                    fiyatlar = new double[sayi];
                    idler = new int[sayi];
                    //Session["secim"] = Convert.ToInt32(dt.Rows[0]["AnakartUrunID"]);


                    for (int i = 0; i < sayi; i++)
                    {
                        idler[i] = Convert.ToInt32(dt.Rows[i]["EkranKartiUrunID"]);
                        resimler[i] = dt.Rows[i]["resim1"].ToString();
                        adlar[i] = dt.Rows[i]["EkranKartiAdi"].ToString();
                        fiyatlar[i] = Convert.ToDouble(dt.Rows[i]["Fiyat"]);
                    }
                }
            }
            //
            //Satılanları çek
            SqlCommand cmdSiparisler = new SqlCommand("select * from Siparisler");
            cmdSiparisler.Connection = baglan.baglan();

            DataTable dtSiparisler = new DataTable();
            SqlDataAdapter adpSiparisler = new SqlDataAdapter(cmdSiparisler);
            adpSiparisler.Fill(dtSiparisler);
            sayiSiparis = dtSiparisler.Rows.Count;

            if (sayiSiparis > 4)
            {
                sayiSiparis = 4;
                siparisadlar = new string[4];
                siparisresimler = new string[4];
                siparisfiyatlar = new double[4];
                siparisidler = new int[4];
                SiparisTurIdler = new string[4];


                for (int i = 0; i < 4; i++)
                {
                    siparisidler[i] = Convert.ToInt32(dtSiparisler.Rows[i]["UrunID"]);
                    siparisresimler[i] = dtSiparisler.Rows[i]["UrunResim"].ToString();
                    siparisadlar[i] = dtSiparisler.Rows[i]["UrunAdi"].ToString();
                    siparisfiyatlar[i] = Convert.ToDouble(dtSiparisler.Rows[i]["UrunFiyat"]);
                    SiparisTurIdler[i] = dtSiparisler.Rows[i]["TurID"].ToString();
                }
            }
            else
            {

                siparisadlar = new string[sayiSiparis];
                siparisresimler = new string[sayiSiparis];
                siparisfiyatlar = new double[sayiSiparis];
                siparisidler = new int[sayiSiparis];
                SiparisTurIdler = new string[sayiSiparis];


                for (int i = 0; i < sayiSiparis; i++)
                {
                    siparisidler[i] = Convert.ToInt32(dtSiparisler.Rows[i]["UrunID"]);
                    siparisresimler[i] = dtSiparisler.Rows[i]["UrunResim"].ToString();
                    siparisadlar[i] = dtSiparisler.Rows[i]["UrunAdi"].ToString();
                    siparisfiyatlar[i] = Convert.ToDouble(dtSiparisler.Rows[i]["UrunFiyat"]);
                    SiparisTurIdler[i] = dtSiparisler.Rows[i]["TurID"].ToString();
                }
            }
        }
    }
    }
