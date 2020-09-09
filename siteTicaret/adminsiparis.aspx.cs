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
    public partial class adminsiparis : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public int sayi;
        public string[] urunfotolar;
        public string[] urunadlari;
        public string[] uyeadlari;
        public string[] uyeadresler;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["kadi"] == null && Session["sifre"] == null)
            {
                Response.Redirect("admingiris.aspx");
            }

            SqlCommand cmd = new SqlCommand("Select s.UrunResim,s.UrunAdi,a.Ad,a.Soyad,a.SehirAdi,a.IlceAdi,a.Adres from Siparisler s inner join AdresTanimlari a on s.UyeID = a.UyeID");
            cmd.Connection = baglan.baglan();

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            sayi = dt.Rows.Count;
            urunfotolar = new string[sayi];
            uyeadlari = new string[sayi];
            urunadlari = new string[sayi];
            uyeadresler = new string[sayi];

            for (int i = 0; i < sayi; i++)
            {
                uyeadlari[i] = dt.Rows[i]["Ad"].ToString() + " " + dt.Rows[i]["Soyad"].ToString();
                urunfotolar[i] = dt.Rows[i]["UrunResim"].ToString();
                urunadlari[i] = dt.Rows[i]["UrunAdi"].ToString();
                uyeadresler[i] = dt.Rows[i]["Adres"].ToString() + " " + dt.Rows[i]["SehirAdi"].ToString() + "/" + dt.Rows[i]["IlceAdi"].ToString();
            }
        }
    }
}