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
    public partial class ekrankartlari : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public int sayi;
        public int UrunID;
        public string resim;
        public string[] ekrankartiadlari;
        public string[] resimler;
        public double[] fiyatlar;
        public int[] idler;
        public string grafikchipsetimarkasi1 = "";
        public string grafikchipsetimarkasi2 = "";
        public string marka1 = "";
        public string marka2 = "";
        public string marka3 = "";
        public string marka4 = "";
        public string ramkapasitesi1 = "";
        public string ramkapasitesi2 = "";
        public string ramkapasitesi3 = "";
        public string ramkapasitesi4 = "";
        public int[] fiyatAraligi = new int[2];
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from EkranKartiUrunler");
            cmd.Connection = baglan.baglan();

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            sayi = dt.Rows.Count;
            ekrankartiadlari = new string[sayi];
            resimler = new string[sayi];
            fiyatlar = new double[sayi];
            idler = new int[sayi];
            //Session["secim"] = Convert.ToInt32(dt.Rows[0]["AnakartUrunID"]);


            for (int i = 0; i < sayi; i++)
            {
                idler[i] = Convert.ToInt32(dt.Rows[i]["EkranKartiUrunID"]);
                resimler[i] = dt.Rows[i]["resim1"].ToString();
                ekrankartiadlari[i] = dt.Rows[i]["EkranKartiAdi"].ToString();
                fiyatlar[i] = Convert.ToDouble(dt.Rows[i]["Fiyat"]);
            }
        }

        protected void btn_filtreleme_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from EkranKartiUrunler where (GrafikChipsetiMarkasi=@GrafikChipsetiMarkasi1 OR GrafikChipsetiMarkasi=@GrafikChipsetiMarkasi2) AND (Marka=@Marka1 OR Marka=@Marka2 OR Marka=@Marka3 OR Marka=@Marka4) AND (RamKapasitesi=@RamKapasitesi1 OR RamKapasitesi=@RamKapasitesi2 OR RamKapasitesi=@RamKapasitesi3 OR RamKapasitesi=@RamKapasitesi4) AND (Fiyat BETWEEN @FiyatAraligi AND @FiyatAraligi2)");
            cmd.Connection = baglan.baglan();
            cmd.Parameters.AddWithValue("@GrafikChipsetiMarkasi1", grafikchipsetimarkasi1);
            cmd.Parameters.AddWithValue("@GrafikChipsetiMarkasi2", grafikchipsetimarkasi2);
            cmd.Parameters.AddWithValue("@Marka1", marka1);
            cmd.Parameters.AddWithValue("@Marka2", marka2);
            cmd.Parameters.AddWithValue("@Marka3", marka3);
            cmd.Parameters.AddWithValue("@Marka4", marka4);
            cmd.Parameters.AddWithValue("@RamKapasitesi1", ramkapasitesi1);
            cmd.Parameters.AddWithValue("@RamKapasitesi2", ramkapasitesi2);
            cmd.Parameters.AddWithValue("@RamKapasitesi3", ramkapasitesi3);
            cmd.Parameters.AddWithValue("@RamKapasitesi4", ramkapasitesi4);
            cmd.Parameters.AddWithValue("@FiyatAraligi", fiyatAraligi[0]);
            cmd.Parameters.AddWithValue("@FiyatAraligi2", fiyatAraligi[1]);
            if (chcEkranKartlari.SelectedValue == "AMD")
            {
                cmd.Parameters.RemoveAt("@GrafikChipsetiMarkasi1");
                grafikchipsetimarkasi1 = "AMD";
                cmd.Parameters.AddWithValue("@GrafikChipsetiMarkasi1", grafikchipsetimarkasi1);
            }
            else if (chcEkranKartlari.SelectedValue == "NVIDIA")
            {
                cmd.Parameters.RemoveAt("@GrafikChipsetiMarkasi2");
                grafikchipsetimarkasi2 = "NVIDIA";
                cmd.Parameters.AddWithValue("@GrafikChipsetiMarkasi2", grafikchipsetimarkasi2);
            }


            if (chcMarkalar.SelectedValue == "Asus")
            {
                cmd.Parameters.RemoveAt("@Marka1");
                marka1 = "Asus";
                cmd.Parameters.AddWithValue("@Marka1", marka1);
            }
            else if (chcMarkalar.SelectedValue == "Gigabyte")
            {
                cmd.Parameters.RemoveAt("@Marka2");
                marka2 = "Gigabyte";
                cmd.Parameters.AddWithValue("@Marka2", marka2);
            }
            else if (chcMarkalar.SelectedValue == "MSI")
            {
                cmd.Parameters.RemoveAt("@Marka3");
                marka3 = "MSI";
                cmd.Parameters.AddWithValue("@Marka3", marka3);
            }
            else if (chcMarkalar.SelectedValue == "SAPPHIRE")
            {
                cmd.Parameters.RemoveAt("@Marka4");
                marka4 = "SAPPHIRE";
                cmd.Parameters.AddWithValue("@Marka4", marka4);
            }

            if (chcRamKapasitesi.SelectedValue == "2 GB")
            {
                cmd.Parameters.RemoveAt("@RamKapasitesi1");
                ramkapasitesi1 = "2 GB";
                cmd.Parameters.AddWithValue("@RamKapasitesi1", ramkapasitesi1);
            }
            else if (chcRamKapasitesi.SelectedValue == "4 GB")
            {
                cmd.Parameters.RemoveAt("@RamKapasitesi2");
                ramkapasitesi2 = "4 GB";
                cmd.Parameters.AddWithValue("@RamKapasitesi2", ramkapasitesi2);
            }
            else if (chcRamKapasitesi.SelectedValue == "8 GB")
            {
                cmd.Parameters.RemoveAt("@RamKapasitesi3");
                ramkapasitesi3 = "8 GB";
                cmd.Parameters.AddWithValue("@RamKapasitesi3", ramkapasitesi3);
            }
            else if (chcRamKapasitesi.SelectedValue == "11 GB")
            {
                cmd.Parameters.RemoveAt("@RamKapasitesi4");
                ramkapasitesi4 = "11 GB";
                cmd.Parameters.AddWithValue("@RamKapasitesi4", ramkapasitesi4);
            }

            if (chcFiyatAraligi.SelectedValue == "1")
            {
                cmd.Parameters.RemoveAt("@FiyatAraligi");
                cmd.Parameters.RemoveAt("@FiyatAraligi2");
                fiyatAraligi[0] = 0;
                fiyatAraligi[1] = 99;
                cmd.Parameters.AddWithValue("@FiyatAraligi", fiyatAraligi[0]);
                cmd.Parameters.AddWithValue("@FiyatAraligi2", fiyatAraligi[1]);
            }
            else if (chcFiyatAraligi.SelectedValue == "2")
            {
                cmd.Parameters.RemoveAt("@FiyatAraligi");
                cmd.Parameters.RemoveAt("@FiyatAraligi2");
                fiyatAraligi[0] = 100;
                fiyatAraligi[1] = 199;
                cmd.Parameters.AddWithValue("@FiyatAraligi", fiyatAraligi[0]);
                cmd.Parameters.AddWithValue("@FiyatAraligi2", fiyatAraligi[1]);
            }
            else if (chcFiyatAraligi.SelectedValue == "3")
            {
                cmd.Parameters.RemoveAt("@FiyatAraligi");
                cmd.Parameters.RemoveAt("@FiyatAraligi2");
                fiyatAraligi[0] = 200;
                fiyatAraligi[1] = 499;
                cmd.Parameters.AddWithValue("@FiyatAraligi", fiyatAraligi[0]);
                cmd.Parameters.AddWithValue("@FiyatAraligi2", fiyatAraligi[1]);

            }
            else if (chcFiyatAraligi.SelectedValue == "4")
            {

                cmd.Parameters.RemoveAt("@FiyatAraligi");
                cmd.Parameters.RemoveAt("@FiyatAraligi2");
                fiyatAraligi[0] = 500;
                fiyatAraligi[1] = 999;
                cmd.Parameters.AddWithValue("@FiyatAraligi", fiyatAraligi[0]);
                cmd.Parameters.AddWithValue("@FiyatAraligi2", fiyatAraligi[1]);
            }
            else if (chcFiyatAraligi.SelectedValue == "5")
            {
                cmd.Parameters.RemoveAt("@FiyatAraligi");
                cmd.Parameters.RemoveAt("@FiyatAraligi2");
                fiyatAraligi[0] = 1000;
                fiyatAraligi[1] = 100000;
                cmd.Parameters.AddWithValue("@FiyatAraligi", fiyatAraligi[0]);
                cmd.Parameters.AddWithValue("@FiyatAraligi2", fiyatAraligi[1]);
            }

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            sayi = dt.Rows.Count;
            ekrankartiadlari = new string[sayi];
            resimler = new string[sayi];
            fiyatlar = new double[sayi];
            idler = new int[sayi];



            for (int i = 0; i < sayi; i++)
            {
                idler[i] = Convert.ToInt32(dt.Rows[i]["EkranKartiUrunID"]);
                resimler[i] = dt.Rows[i]["resim1"].ToString();
                ekrankartiadlari[i] = dt.Rows[i]["EkranKartiAdi"].ToString();
                fiyatlar[i] = Convert.ToDouble(dt.Rows[i]["Fiyat"]);
            }

        }
    }
}