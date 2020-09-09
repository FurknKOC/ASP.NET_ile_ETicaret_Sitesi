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
    public partial class islemciler : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public int sayi;
        public int UrunID;
        public string resim;
        public string[] islemciadlari;
        public string[] resimler;
        public double[] fiyatlar;
        public int[] idler;
        public string islemcisokettipi1 = "";
        public string islemcisokettipi2 = "";
        public string islemcisokettipi3 = "";
        public string islemcisokettipi4 = "";
        public string marka1 = "";
        public string marka2 = "";
        public string islemciteknolojisi1 = "";
        public string islemciteknolojisi2 = "";
        public string islemciteknolojisi3 = "";
        public string islemciteknolojisi4 = "";
        public string islemciteknolojisi5 = "";
        public string islemciteknolojisi6 = "";
        public int[] fiyatAraligi = new int[2];
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from IslemciUrunler");
            cmd.Connection = baglan.baglan();

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            sayi = dt.Rows.Count;
            islemciadlari = new string[sayi];
            resimler = new string[sayi];
            fiyatlar = new double[sayi];
            idler = new int[sayi];
            //Session["secim"] = Convert.ToInt32(dt.Rows[0]["AnakartUrunID"]);


            for (int i = 0; i < sayi; i++)
            {
                idler[i] = Convert.ToInt32(dt.Rows[i]["IslemciUrunID"]);
                resimler[i] = dt.Rows[i]["resim1"].ToString();
                islemciadlari[i] = dt.Rows[i]["IslemciAdi"].ToString();
                fiyatlar[i] = Convert.ToDouble(dt.Rows[i]["Fiyat"]);
            }
        }

        protected void btn_filtreleme_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from IslemciUrunler where (Marka=@marka1 OR Marka=@Marka2) AND (IslemciSoketTipi=@IslemciSoketTipi1 OR IslemciSoketTipi=@IslemciSoketTipi2 OR IslemciSoketTipi=@IslemciSoketTipi3 OR IslemciSoketTipi=@IslemciSoketTipi4) AND (IslemciTeknolojisi=@IslemciTeknolojisi1 OR IslemciTeknolojisi=@IslemciTeknolojisi2 OR IslemciTeknolojisi=@IslemciTeknolojisi3 OR IslemciTeknolojisi=@IslemciTeknolojisi4 OR IslemciTeknolojisi=@IslemciTeknolojisi5 OR IslemciTeknolojisi=@IslemciTeknolojisi6) AND (Fiyat BETWEEN @FiyatAraligi AND @FiyatAraligi2)");
            cmd.Connection = baglan.baglan();
            cmd.Parameters.AddWithValue("@IslemciSoketTipi1", islemcisokettipi1);
            cmd.Parameters.AddWithValue("@IslemciSoketTipi2", islemcisokettipi2);
            cmd.Parameters.AddWithValue("@IslemciSoketTipi3", islemcisokettipi3);
            cmd.Parameters.AddWithValue("@IslemciSoketTipi4", islemcisokettipi4);
            cmd.Parameters.AddWithValue("@Marka1", marka1);
            cmd.Parameters.AddWithValue("@Marka2", marka2);
            cmd.Parameters.AddWithValue("@IslemciTeknolojisi1", islemciteknolojisi1);
            cmd.Parameters.AddWithValue("@IslemciTeknolojisi2", islemciteknolojisi2);
            cmd.Parameters.AddWithValue("@IslemciTeknolojisi3", islemciteknolojisi3);
            cmd.Parameters.AddWithValue("@IslemciTeknolojisi4", islemciteknolojisi4);
            cmd.Parameters.AddWithValue("@IslemciTeknolojisi5", islemciteknolojisi5);
            cmd.Parameters.AddWithValue("@IslemciTeknolojisi6", islemciteknolojisi6);
            cmd.Parameters.AddWithValue("@FiyatAraligi", fiyatAraligi[0]);
            cmd.Parameters.AddWithValue("@FiyatAraligi2", fiyatAraligi[1]);
            if (chcMarkalar.SelectedValue == "AMD")
            {
                cmd.Parameters.RemoveAt("@Marka1");
                marka1 = "AMD";
                cmd.Parameters.AddWithValue("@Marka1", marka1);
            }
            else if (chcMarkalar.SelectedValue == "Intel")
            {
                cmd.Parameters.RemoveAt("@Marka2");
                marka2 = "Intel";
                cmd.Parameters.AddWithValue("@Marka2", marka1);
            }


            if (chcIslemciTeknolojisi.SelectedValue == "Intel Core i7")
            {
                cmd.Parameters.RemoveAt("@IslemciTeknolojisi1");
                islemciteknolojisi1 = "Intel Core i7";
                cmd.Parameters.AddWithValue("@IslemciTeknolojisi1", islemciteknolojisi1);
            }
            else if (chcIslemciTeknolojisi.SelectedValue == "Intel Core i5")
            {
                cmd.Parameters.RemoveAt("@IslemciTeknolojisi2");
                islemciteknolojisi2 = "Intel Core i5";
                cmd.Parameters.AddWithValue("@IslemciTeknolojisi2", islemciteknolojisi2);
            }
            else if (chcIslemciTeknolojisi.SelectedValue == "Intel Core i3")
            {
                cmd.Parameters.RemoveAt("@IslemciTeknolojisi3");
                islemciteknolojisi3 = "Intel Core i3";
                cmd.Parameters.AddWithValue("@IslemciTeknolojisi3", islemciteknolojisi3);
            }
            else if (chcIslemciTeknolojisi.SelectedValue == "Intel Pentium")
            {
                cmd.Parameters.RemoveAt("@IslemciTeknolojisi4");
                islemciteknolojisi4 = "Intel Pentium";
                cmd.Parameters.AddWithValue("@IslemciTeknolojisi4", islemciteknolojisi4);
            }
            else if (chcIslemciTeknolojisi.SelectedValue == "AMD Ryzen 5")
            {
                cmd.Parameters.RemoveAt("@IslemciTeknolojisi5");
                islemciteknolojisi5 = "AMD Ryzen 5";
                cmd.Parameters.AddWithValue("@IslemciTeknolojisi5", islemciteknolojisi5);
            }
            else if (chcIslemciTeknolojisi.SelectedValue == "AMD Ryzen 7")
            {
                cmd.Parameters.RemoveAt("@IslemciTeknolojisi6");
                islemciteknolojisi6 = "AMD Ryzen 7";
                cmd.Parameters.AddWithValue("@IslemciTeknolojisi6", islemciteknolojisi6);
            }

            if (chcIslemciler.SelectedValue == "Soket 1150")
            {
                cmd.Parameters.RemoveAt("@IslemciSoketTipi1");
                islemcisokettipi1 = "Soket 1150";
                cmd.Parameters.AddWithValue("@IslemciSoketTipi1", islemcisokettipi1);
            }

            else if (chcIslemciler.SelectedValue == "Soket 1151")
            {
                cmd.Parameters.RemoveAt("@IslemciSoketTipi2");
                islemcisokettipi2 = "Soket 1151";
                cmd.Parameters.AddWithValue("@IslemciSoketTipi2", islemcisokettipi2);
            }
            else if (chcIslemciler.SelectedValue == "Soket AM3+")
            {
                cmd.Parameters.RemoveAt("@IslemciSoketTipi3");
                islemcisokettipi3 = "Soket AM3+";
                cmd.Parameters.AddWithValue("@IslemciSoketTipi3", islemcisokettipi3);
            }
            else if (chcIslemciler.SelectedValue == "Soket AM4")
            {
                cmd.Parameters.RemoveAt("@IslemciSoketTipi4");
                islemcisokettipi4 = "Soket AM4";
                cmd.Parameters.AddWithValue("@IslemciSoketTipi4", islemcisokettipi4);
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
            islemciadlari = new string[sayi];
            resimler = new string[sayi];
            fiyatlar = new double[sayi];
            idler = new int[sayi];



            for (int i = 0; i < sayi; i++)
            {
                idler[i] = Convert.ToInt32(dt.Rows[i]["IslemciUrunID"]);
                resimler[i] = dt.Rows[i]["resim1"].ToString();
                islemciadlari[i] = dt.Rows[i]["IslemciAdi"].ToString();
                fiyatlar[i] = Convert.ToDouble(dt.Rows[i]["Fiyat"]);
            }

        }
    }
}