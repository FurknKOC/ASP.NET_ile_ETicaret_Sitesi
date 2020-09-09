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
    public partial class uyelik : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UyeID"]==null)
            {
                
            }
            else
            {
                Response.Redirect("kullanicisayfasi.aspx");
            }
        }
        sqlbaglantisi baglan = new sqlbaglantisi();

        public string dogumtarihi;
        public int ay;
        public string email;
        public string sifre;

        protected void UyeOlButon_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Uyeler (Ad,Soyad,Email,Tel,Sifre,SifreTekrar,DogumTarihi,Cinsiyet,GizliSoru,GizliSoruCevap) values (@Ad,@Soyad,@Email,@Tel,@Sifre,@SifreTekrar,@DogumTarihi,@Cinsiyet,@GizliSoru,@GizliSoruCevap)", baglan.baglan());
            cmd.Connection = baglan.baglan();

            dogumtarihi = listGun.Value.ToString() +" " +  listAy.Value.ToString() +" "+ listYil.Value.ToString();

            cmd.Parameters.AddWithValue("@Ad", txtAd.Value.ToString());
            cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Value.ToString());
            cmd.Parameters.AddWithValue("@Email", txtEmailKayit.Value.ToString());
            cmd.Parameters.AddWithValue("@Tel", txtTelefon.Value.ToString());
            cmd.Parameters.AddWithValue("@Sifre", txtSifre.Value.ToString());
            cmd.Parameters.AddWithValue("@SifreTekrar", txtSifreTekrar.Value.ToString());
            cmd.Parameters.AddWithValue("@DogumTarihi", dogumtarihi);
            cmd.Parameters.AddWithValue("@Cinsiyet", listCinsiyet.Value.ToString());
            cmd.Parameters.AddWithValue("@GizliSoru", listGizliSoru.Value.ToString());
            cmd.Parameters.AddWithValue("@GizliSoruCevap", txtSoruCevap.Value.ToString());

            cmd.ExecuteNonQuery();
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('Başarıyla Üye Oldunuz!');</script>");

        }

        protected void GirisButon_Click(object sender, EventArgs e)
        {

            email = txtEmailGiris.Value.ToString();
            sifre = txtSifreGiris.Value.ToString();

            SqlCommand cmd = new SqlCommand("select * from Uyeler ");
            cmd.Connection = baglan.baglan();

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (email == dt.Rows[i]["Email"].ToString() && sifre == dt.Rows[i]["Sifre"].ToString())
                {
                    Session["kullaniciadi"] = dt.Rows[i]["Ad"].ToString();
                    Session["kullanicisoyad"] = dt.Rows[i]["Soyad"].ToString();
                    Session["parola"] = sifre;
                    Session["UyeID"] =Convert.ToInt32(dt.Rows[i]["UyeID"]);
                    Session["sayac"] = 2;
                    Response.Redirect("default.aspx");
                }

            }
            Label1.Text = "Kullanıcı adı veya şifre yanlış!";
        }
    }
}