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
    public partial class anakart : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public int sayi;
        public int UrunID;
        public string resim;
        public string[] anakartadlari;
        public string[] resimler;
        public double[] fiyatlar;
        public int[] idler;
        public string deneme = "";
        public string uyumluluk1 = "";
        public string uyumluluk2 = "";
        public string marka1 = "";
        public string marka2 = "";
        public string marka3 = "";
        public string ramtipi1 = "";
        public string ramtipi2 = "";
        public int[] fiyatAraligi= new int[2];
        
        protected void Page_Load(object sender, EventArgs e)
        {
            fiyatAraligi[0] = 0;
            fiyatAraligi[1] = 100000;
            SqlCommand cmd = new SqlCommand("select * from AnakartUrunler");
            cmd.Connection = baglan.baglan();
           
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            sayi = dt.Rows.Count;
            anakartadlari = new string[sayi];
            resimler = new string[sayi];
            fiyatlar = new double[sayi];
            idler = new int[sayi];
            

            for (int i = 0; i < sayi; i++)
            {
                idler[i] = Convert.ToInt32(dt.Rows[i]["AnakartUrunID"]);
                resimler[i] = dt.Rows[i]["resim1"].ToString();
                anakartadlari[i] = dt.Rows[i]["AnakartAdi"].ToString();
                fiyatlar[i] =Convert.ToDouble(dt.Rows[i]["Fiyat"]);
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
           
        }

        protected void btn_filtreleme_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("select * from AnakartUrunler where (Uyumluluk=@Uyumluluk1 OR Uyumluluk=@Uyumluluk2) AND (Marka=@Marka1 OR Marka=@Marka2 OR Marka=@Marka3) AND (RamTipi=@RamTipi1 OR RamTipi=@RamTipi2) AND (Fiyat BETWEEN @FiyatAraligi AND @FiyatAraligi2)");
            cmd.Connection = baglan.baglan();
            cmd.Parameters.AddWithValue("@Uyumluluk1", uyumluluk1);
            cmd.Parameters.AddWithValue("@Uyumluluk2", uyumluluk2);
            cmd.Parameters.AddWithValue("@Marka1", marka1);
            cmd.Parameters.AddWithValue("@Marka2", marka2);
            cmd.Parameters.AddWithValue("@Marka3", marka3);
            cmd.Parameters.AddWithValue("@RamTipi1", ramtipi1);
            cmd.Parameters.AddWithValue("@RamTipi2", ramtipi2);
            cmd.Parameters.AddWithValue("@FiyatAraligi",fiyatAraligi[0]);
            cmd.Parameters.AddWithValue("@FiyatAraligi2", fiyatAraligi[1]);
            if (chcUyumluluk.SelectedValue=="Amd")
            {
                cmd.Parameters.RemoveAt("@Uyumluluk1");
                uyumluluk1 = "Amd";
                cmd.Parameters.AddWithValue("@Uyumluluk1",uyumluluk1);
            }
            else if (chcUyumluluk.SelectedValue=="Intel")
            {
                cmd.Parameters.RemoveAt("@Uyumluluk2");
                uyumluluk2 = "Intel";
                cmd.Parameters.AddWithValue("@Uyumluluk2", uyumluluk2);
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

            if (chcRamTipi.SelectedValue == "DDR3")
            {
                cmd.Parameters.RemoveAt("@RamTipi1");
                ramtipi1 = "DDR3";
                cmd.Parameters.AddWithValue("@RamTipi1", ramtipi1);
            }
            else if (chcRamTipi.SelectedValue == "DDR4")
            {
                cmd.Parameters.RemoveAt("@RamTipi2");
                ramtipi2 = "DDR4";
                cmd.Parameters.AddWithValue("@RamTipi2", ramtipi2);
            }

            if (chcFiyatAraligi.SelectedValue == "1")
            {
                cmd.Parameters.RemoveAt("@FiyatAraligi");
                cmd.Parameters.RemoveAt("@FiyatAraligi2");
                fiyatAraligi[0] = 0;
                fiyatAraligi[1] = 99;
                cmd.Parameters.AddWithValue("@FiyatAraligi",fiyatAraligi[0]);
                cmd.Parameters.AddWithValue("@FiyatAraligi2", fiyatAraligi[1]);
            }
            else if (chcFiyatAraligi.SelectedValue=="2")
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
            anakartadlari = new string[sayi];
            resimler = new string[sayi];
            fiyatlar = new double[sayi];
            idler = new int[sayi];



            for (int i = 0; i < sayi; i++)
            {
                idler[i] = Convert.ToInt32(dt.Rows[i]["AnakartUrunID"]);
                resimler[i] = dt.Rows[i]["resim1"].ToString();
                anakartadlari[i] = dt.Rows[i]["AnakartAdi"].ToString();
                fiyatlar[i] = Convert.ToDouble(dt.Rows[i]["Fiyat"]);
            }


        }

        

        
    }
}