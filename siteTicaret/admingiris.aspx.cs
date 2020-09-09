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
   
    public partial class admin : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public string isim;
        public string sifree;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           isim= kullanici_adi.Text;
            sifree = sifre.Text;
            SqlCommand cmd = new SqlCommand("select * from Adminler ");
            cmd.Connection = baglan.baglan();

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (isim == dt.Rows[i]["KullaniciAdi"].ToString() && sifree == dt.Rows[i]["Sifre"].ToString())
                {
                    Session["kadi"] = isim;
                    Session["parola"] = sifree;
                    Response.Redirect("adminkullanici.aspx");
                }
              
            }

            Label1.Text = "Kullanıcı adı veya şifre yanlış.";
          
          
        }
    }
}