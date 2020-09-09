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
     
    public partial class kullanicisayfasi : System.Web.UI.Page
    {
        public int KullaniciID;
        sqlbaglantisi baglan = new sqlbaglantisi();
        public string ayir;
        public string dogumtarihi;
        public string ad;
        public int sayac;
        public string[] urunlerinadlari;
        public string[] resimler;
        public double[] fiyatlar;
        public int[] idler;
        public string[] TurID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["sayac"])==2)
            {

          try
            {
                if (Session["UyeID"] == null)
                    Response.Redirect("uyelik.aspx");

                else
                {
                    SqlCommand cmd = new SqlCommand("select * from Uyeler where UyeID=@UyeID");
                    cmd.Connection = baglan.baglan();
                    KullaniciID = Convert.ToInt32(Session["UyeID"]);
                    cmd.Parameters.AddWithValue("@UyeID", KullaniciID);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    ayir = dt.Rows[0]["DogumTarihi"].ToString();
                    string[] ayirr = ayir.Split(' ');

                    txtAd.Text = dt.Rows[0]["Ad"].ToString();
                    txtSoyad.Text = dt.Rows[0]["Soyad"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                    txtTelefon.Text = dt.Rows[0]["Tel"].ToString();
                    txtSifre.Text = dt.Rows[0]["Sifre"].ToString();
                    txtSifreTekrar.Text = dt.Rows[0]["SifreTekrar"].ToString();
                    listGun.Value = ayirr[0];
                    listAy.Value = ayirr[1];
                    listYil.Value = ayirr[2];
                    listCinsiyet.Value = dt.Rows[0]["Cinsiyet"].ToString();


                        SqlCommand cmdAdresCek = new SqlCommand("select * from AdresTanimlari where UyeID=@UyeID");
                        cmdAdresCek.Connection = baglan.baglan();
                        KullaniciID = Convert.ToInt32(Session["UyeID"]);
                        cmdAdresCek.Parameters.AddWithValue("@UyeID", KullaniciID);
                        DataTable dtAdresCek = new DataTable();
                        SqlDataAdapter adpAdresCek = new SqlDataAdapter(cmdAdresCek);
                        adpAdresCek.Fill(dtAdresCek);

                        txtAdresAd.Text = dtAdresCek.Rows[0]["Ad"].ToString();
                        txtAdresSoyad.Text = dtAdresCek.Rows[0]["Soyad"].ToString();
                        txtAdresSehir.Text = dtAdresCek.Rows[0]["SehirAdi"].ToString();
                        txtAdresIlce.Text = dtAdresCek.Rows[0]["IlceAdi"].ToString();
                        txtAdres.Text = dtAdresCek.Rows[0]["Adres"].ToString();
                        txtAdresTel.Text = dtAdresCek.Rows[0]["Tel"].ToString();

                        //Siparis Kismi------------------------------------------------
                        SqlCommand cmdSiparisCek = new SqlCommand("select * from Siparisler where UyeID=@UyeID");
                        cmdSiparisCek.Connection = baglan.baglan();
                        KullaniciID = Convert.ToInt32(Session["UyeID"]);
                        cmdSiparisCek.Parameters.AddWithValue("@UyeID", KullaniciID);
                        DataTable dtSiparisCek = new DataTable();
                        SqlDataAdapter adpSiparisCek = new SqlDataAdapter(cmdSiparisCek);
                        adpSiparisCek.Fill(dtSiparisCek);
                       
                        sayac = dtSiparisCek.Rows.Count;
                        urunlerinadlari = new string[sayac];
                        resimler = new string[sayac];
                        fiyatlar = new double[sayac];
                        idler = new int[sayac];
                        TurID = new string[sayac];
                        for (int i = 0; i < sayac; i++)
                        {
                            idler[i] = Convert.ToInt32(dtSiparisCek.Rows[i]["UrunID"]);
                            resimler[i] = dtSiparisCek.Rows[i]["UrunResim"].ToString();
                            urunlerinadlari[i] = dtSiparisCek.Rows[i]["UrunAdi"].ToString();
                            fiyatlar[i] = Convert.ToDouble(dtSiparisCek.Rows[i]["UrunFiyat"]);
                            TurID[i] = dtSiparisCek.Rows[i]["TurID"].ToString();
                        }
                    }
            }
            catch (Exception ex)
            {
                Response.Write("Bu işte bir iş var" + ex);
            }
                Session["sayac"] = 1;
            }
            else
            {
                Session["sayac"] = 2;
            }
        }

        protected void btnKisiGuncelle_Click(object sender, EventArgs e)
        {



            SqlCommand cmdGuncelle = new SqlCommand("update Uyeler set Ad = @Ad, Soyad = @Soyad, Email = @Email,Tel = @Tel,Sifre = @Sifre,SifreTekrar = @SifreTekrar,DogumTarihi = @DogumTarihi,Cinsiyet = @Cinsiyet where UyeID = @UyeID ", baglan.baglan());


            KullaniciID = Convert.ToInt32(Session["UyeID"]);
            cmdGuncelle.Parameters.AddWithValue("@UyeID", KullaniciID);

            dogumtarihi = listGun.Value.ToString() + " " + listAy.Value.ToString() + " " + listYil.Value.ToString();

            cmdGuncelle.Parameters.AddWithValue("@Ad", txtAd.Text);
            cmdGuncelle.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            cmdGuncelle.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmdGuncelle.Parameters.AddWithValue("@Tel", txtTelefon.Text);
            cmdGuncelle.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            cmdGuncelle.Parameters.AddWithValue("@SifreTekrar", txtSifreTekrar.Text);
            cmdGuncelle.Parameters.AddWithValue("@DogumTarihi", dogumtarihi);
            cmdGuncelle.Parameters.AddWithValue("@Cinsiyet", listCinsiyet.Value.ToString());


            cmdGuncelle.ExecuteNonQuery();



        }

        protected void myBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmdAdresGuncelle = new SqlCommand("update AdresTanimlari set Ad = @Ad, Soyad = @Soyad, SehirAdi = @SehirAdi,IlceAdi = @IlceAdi,Adres = @Adres,Tel = @Tel where UyeID = @UyeID ", baglan.baglan());

            KullaniciID = Convert.ToInt32(Session["UyeID"]);
            cmdAdresGuncelle.Parameters.AddWithValue("@UyeID", KullaniciID);

            cmdAdresGuncelle.Parameters.AddWithValue("@Ad", txtAd.Text);
            cmdAdresGuncelle.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            cmdAdresGuncelle.Parameters.AddWithValue("@SehirAdi", txtAdresSehir.Text);
            cmdAdresGuncelle.Parameters.AddWithValue("@IlceAdi", txtAdresIlce.Text);
            cmdAdresGuncelle.Parameters.AddWithValue("@Adres", txtAdres.Text);
            cmdAdresGuncelle.Parameters.AddWithValue("@Tel", txtAdresTel.Text);


            cmdAdresGuncelle.ExecuteNonQuery();
        }

        protected void btncikis_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("default.aspx");
        }
    }
}