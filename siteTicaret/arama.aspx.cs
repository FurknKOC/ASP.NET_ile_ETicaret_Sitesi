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
    public partial class arama : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public int sayi;
        public string[] anakartadlar;
        public string[] anakartresimler;
        public double[] anakartfiyatlar;
        public int[] anakartidler;

        public int sayi2;
        public string[] islemciadlar;
        public string[] islemciresimler;
        public double[] islemcifiyatlar;
        public int[] islemciidler;

        public int sayi3;
        public string[] ekrankartiadlar;
        public string[] ekrankartiresimler;
        public double[] ekrankartifiyatlar;
        public int[] ekrankartiidler;

        protected void Page_Load(object sender, EventArgs e)
        {
            int queryCount = Request.QueryString.Count;  // Request.QueryString.Count; ile kaç tane query var onu öğrenip queryCount değişkeninne atıyorum...
            var sorgu = ""; // Az öncekine benzer şekilde.. Veritabanında arama yaptırcak sorgu değişkenini yine boş olucak şekilde tanımlıyorum..
            var sorgu2 = "";
            var sorgu3 = "";
            if (queryCount > 1)  // Burda gelen QueryString'ler 1 den fazla ise Or kullanarak birden fazla sqlSorgusu oluşturuyorum..
            {
                for (int i = 0; i < queryCount; i++) // queryString sayısı kadar dönüp sorguyu LIKE arama komutuyla bütün queryString verilerini arattıryorum...
                {
                    sorgu += "AnakartAdi LIKE '%" + Request.QueryString[i] + "%' or ";
                    sorgu2 += "IslemciAdi LIKE '%" + Request.QueryString[i] + "%' or ";
                    sorgu3 += "EkranKartiAdi LIKE '%" + Request.QueryString[i] + "%' or ";
                    //Bunun çıktısı şu şekilde olur....

                    // "makaleBaslik LIKE '%kelime0 or makaleBaslik LIKE '%kelime1 or.... %' or " şeklinde olcak..

                }
                sorgu = sorgu.Substring(0, sorgu.Length - 3); //Ama yine yukarda son dönüşte fazladan or oluşacak onu yine substringle atıyorum...
            }
            else
            {
                sorgu = "AnakartAdi LIKE '%" + Request.QueryString[0] + "%'";
                sorgu2 = "IslemciAdi LIKE '%" + Request.QueryString[0] + "%'";
                sorgu3 = "EkranKartiAdi LIKE '%" + Request.QueryString[0] + "%'"; // Burası query sayısı 1 ise oluşacak sorgu..
            }

            try
            {
            
                SqlCommand cmdAnakartCek = new SqlCommand("select * from AnakartUrunler where " + sorgu, baglan.baglan()); // SqlCommand sorgu değişkenini ekliyorum.

                DataTable dtAnakartCek = new DataTable();
                SqlDataAdapter adpAnakartCek = new SqlDataAdapter(cmdAnakartCek);
                adpAnakartCek.Fill(dtAnakartCek);

                sayi = dtAnakartCek.Rows.Count; ;
                anakartadlar = new string[sayi];
                anakartresimler = new string[sayi];
                anakartfiyatlar = new double[sayi];
                anakartidler = new int[sayi];

                for (int i = 0; i < sayi; i++)
                {
                    anakartidler[i] = Convert.ToInt32(dtAnakartCek.Rows[i]["AnakartUrunID"]);
                    anakartresimler[i] = dtAnakartCek.Rows[i]["resim1"].ToString();
                    anakartadlar[i] = dtAnakartCek.Rows[i]["AnakartAdi"].ToString();
                    anakartfiyatlar[i] = Convert.ToDouble(dtAnakartCek.Rows[i]["Fiyat"]);
                }
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                SqlCommand cmdIslemciCek = new SqlCommand("select * from IslemciUrunler where " + sorgu2, baglan.baglan()); // SqlCommand sorgu değişkenini ekliyorum.

                DataTable dtIslemciCek = new DataTable();
                SqlDataAdapter adpIslemciCek = new SqlDataAdapter(cmdIslemciCek);
                adpIslemciCek.Fill(dtIslemciCek);

                sayi2 = dtIslemciCek.Rows.Count;
                islemciadlar = new string[sayi2];
                islemciresimler = new string[sayi2];
                islemcifiyatlar = new double[sayi2];
                islemciidler = new int[sayi2];

                for (int i = 0; i < sayi2; i++)
                {
                    islemciidler[i] = Convert.ToInt32(dtIslemciCek.Rows[i]["IslemciUrunID"]);
                    islemciresimler[i] = dtIslemciCek.Rows[i]["resim1"].ToString();
                    islemciadlar[i] = dtIslemciCek.Rows[i]["IslemciAdi"].ToString();
                    islemcifiyatlar[i] = Convert.ToDouble(dtIslemciCek.Rows[i]["Fiyat"]);
                }
            }
            catch (Exception)
            {
                throw;
            }

            try
            {

                SqlCommand cmdEkranKartiCek = new SqlCommand("select * from EkranKartiUrunler where " + sorgu3, baglan.baglan()); // SqlCommand sorgu değişkenini ekliyorum.

                DataTable dtEkranKartiCek = new DataTable();
                SqlDataAdapter adpEkrankartiCek = new SqlDataAdapter(cmdEkranKartiCek);
                adpEkrankartiCek.Fill(dtEkranKartiCek);

                sayi3 = dtEkranKartiCek.Rows.Count; ;
                ekrankartiadlar = new string[sayi3];
                ekrankartiresimler = new string[sayi3];
                ekrankartifiyatlar = new double[sayi3];
                ekrankartiidler = new int[sayi3];

                for (int i = 0; i < sayi3; i++)
                {
                    ekrankartiidler[i] = Convert.ToInt32(dtEkranKartiCek.Rows[i]["EkranKartiUrunID"]);
                    ekrankartiresimler[i] = dtEkranKartiCek.Rows[i]["resim1"].ToString();
                    ekrankartiadlar[i] = dtEkranKartiCek.Rows[i]["EkranKartiAdi"].ToString();
                    ekrankartifiyatlar[i] = Convert.ToDouble(dtEkranKartiCek.Rows[i]["Fiyat"]);
                }
            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}