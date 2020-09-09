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
    public partial class adminkullanici : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public int sayi;
        public string[] uyefotolar;
        public string[] uyeadlari;
        public string[] uyeadresler;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kadi"] == null && Session["sifre"] == null)
            {
                Response.Redirect("admingiris.aspx");
            }

            SqlCommand cmd = new SqlCommand("Select u.UyeFoto,u.Ad,u.Soyad,a.SehirAdi,a.IlceAdi,a.Adres from Uyeler u inner join AdresTanimlari a on u.UyeID = a.UyeID");
            cmd.Connection = baglan.baglan();

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            sayi = dt.Rows.Count;
            uyefotolar = new string[sayi];
            uyeadlari = new string[sayi];
            uyeadresler = new string[sayi];
            
            for (int i = 0; i < sayi; i++)
            {
                uyeadlari[i] = dt.Rows[i]["Ad"].ToString() + " " + dt.Rows[i]["Soyad"].ToString();
                uyefotolar[i] = dt.Rows[i]["UyeFoto"].ToString();
                uyeadresler[i] = dt.Rows[i]["Adres"].ToString() +" "+dt.Rows[i]["SehirAdi"].ToString() +"/"+ dt.Rows[i]["IlceAdi"].ToString();
            }
        }
    }
}