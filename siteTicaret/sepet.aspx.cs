using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace siteTicaret
{
    public partial class sepet1 : System.Web.UI.Page
    {
        public string[] urunadlari;
        public string[] urunresimleri;
        public int[] urunadetleri;
        public double[] urunfiyatlari;
        public double[] uruntoplamfiyatlari;
        public string faturaurunadlari;
        public string faturaurunfiyatlari;
        public string faturaurunadetleri;
        public int sayi;
        public string KullaniciID;
        public double toplamfiyat;
        public string ad;
        public string soyad;
        public string sehiradi;
        public string ilceadi;
        public string adres;
        public string telefon;
        public string faturaadres;
        public string[] turID;
        public int[] urunID;

        sqlbaglantisi baglan = new sqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["UyeID"] == null)
                    Response.Redirect("uyelik.aspx");

                else
                {
                   
                        //SEPETE ÇEKME KISMI
                        SqlCommand cmd = new SqlCommand("select * from Sepet where UyeID=@UyeID");
                    cmd.Connection = baglan.baglan();

                    KullaniciID = Session["UyeID"].ToString();
                    cmd.Parameters.AddWithValue("@UyeID", KullaniciID);

                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    sayi = dt.Rows.Count;

                    urunadlari = new string[sayi];
                    urunresimleri = new string[sayi];
                    urunfiyatlari = new double[sayi];
                    urunadetleri = new int[sayi];
                    turID = new string[sayi];
                    urunID = new int[sayi];

                    for (int i = 0; i < sayi; i++)
                    {
                        urunadlari[i] = dt.Rows[i]["UrunAdi"].ToString();
                        faturaurunadlari += urunadlari[i].ToString() + " ";
                        urunresimleri[i] = dt.Rows[i]["UrunResim"].ToString();
                        urunadetleri[i] = Convert.ToInt32(dt.Rows[i]["UrunAdet"]);
                        faturaurunadetleri += urunadetleri[i].ToString() + " ";
                        urunfiyatlari[i] = Convert.ToDouble(dt.Rows[i]["UrunFiyat"]);
                        faturaurunfiyatlari += urunfiyatlari[i].ToString() + " ";
                        turID[i] = dt.Rows[i]["TurID"].ToString();
                        urunID[i] = Convert.ToInt32(dt.Rows[i]["UrunID"]);

                    }

                    for (int i = 0; i < sayi; i++)
                    {
                        toplamfiyat += Convert.ToDouble(dt.Rows[i]["ToplamFiyat"]);
                    }
                    //ADRES ÇEKME KISMI
                    SqlCommand cmdAdresCek = new SqlCommand("select * from AdresTanimlari where UyeID=@UyeID");
                    cmdAdresCek.Connection = baglan.baglan();

                    KullaniciID = Session["UyeID"].ToString();
                    cmdAdresCek.Parameters.AddWithValue("@UyeID", KullaniciID);

                    DataTable dtAdresCek = new DataTable();
                    SqlDataAdapter adpAdresCek = new SqlDataAdapter(cmdAdresCek);
                    adpAdresCek.Fill(dtAdresCek);

                    txtAd.Text = dtAdresCek.Rows[0]["Ad"].ToString();
                    txtSoyad.Text = dtAdresCek.Rows[0]["Soyad"].ToString();
                    txtSehir.Text = dtAdresCek.Rows[0]["SehirAdi"].ToString();
                    txtIlce.Text = dtAdresCek.Rows[0]["IlceAdi"].ToString();
                    txtAdres.Text = dtAdresCek.Rows[0]["Adres"].ToString();
                    txtTelefon.Text = dtAdresCek.Rows[0]["Tel"].ToString();
                }
               
            }
            catch (Exception)
            {
                
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            

           
            //SİPARİŞ EKLEME KISMI
            SqlCommand cmdSiparisEkle = new SqlCommand("insert into Siparisler (UyeID,TurID,UrunID,UrunResim,UrunAdi,UrunFiyat)  Select UyeID,TurID,UrunID,UrunResim,UrunAdi,UrunFiyat from Sepet where UyeID=@UyeID", baglan.baglan());
            cmdSiparisEkle.Connection = baglan.baglan();
            KullaniciID = Session["UyeID"].ToString();
            cmdSiparisEkle.Parameters.AddWithValue("@UyeID", KullaniciID);

            //FATURA EKLEME --------------------------------------------
            SqlCommand cmdFaturaEkle = new SqlCommand("insert into Fatura (UyeID,UyeAdi,UyeSoyad,UyeAdres,Tarih,UrunAdlari,UrunFiyatlari,UrunAdetleri,ToplamFiyat)  values (@UyeID,@UyeAdi,@UyeSoyad,@UyeAdres,@Tarih,@UrunAdlari,@UrunFiyatlari,@UrunAdetleri,@ToplamFiyat)", baglan.baglan());
            cmdFaturaEkle.Connection = baglan.baglan();
            KullaniciID = Session["UyeID"].ToString();
            cmdFaturaEkle.Parameters.AddWithValue("@UyeID", KullaniciID);

            SqlCommand cmdAdresCek = new SqlCommand("select * from AdresTanimlari where UyeID=@UyeID");
            cmdAdresCek.Connection = baglan.baglan();

            KullaniciID = Session["UyeID"].ToString();
            cmdAdresCek.Parameters.AddWithValue("@UyeID", KullaniciID);
            DataTable dtAdresCek = new DataTable();
            SqlDataAdapter adpAdresCek = new SqlDataAdapter(cmdAdresCek);
            adpAdresCek.Fill(dtAdresCek);

            faturaadres = dtAdresCek.Rows[0]["Adres"].ToString() + dtAdresCek.Rows[0]["IlceAdi"].ToString() + dtAdresCek.Rows[0]["SehirAdi"].ToString();

            cmdFaturaEkle.Parameters.AddWithValue("@UyeAdi", Session["kullaniciadi"].ToString());
            cmdFaturaEkle.Parameters.AddWithValue("@UyeSoyad", Session["kullanicisoyad"].ToString());
            cmdFaturaEkle.Parameters.AddWithValue("@UyeAdres", faturaadres);
            cmdFaturaEkle.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(DateTime.Now.ToString()));
            cmdFaturaEkle.Parameters.AddWithValue("@UrunAdlari", faturaurunadlari);
            cmdFaturaEkle.Parameters.AddWithValue("@UrunFiyatlari", faturaurunfiyatlari);
            cmdFaturaEkle.Parameters.AddWithValue("@UrunAdetleri", faturaurunadetleri);
            cmdFaturaEkle.Parameters.AddWithValue("@ToplamFiyat", toplamfiyat);

            cmdFaturaEkle.ExecuteNonQuery();

            cmdSiparisEkle.ExecuteNonQuery();

            //MAİL GÖNDERME KISMI
            SqlCommand cmdUyeCek = new SqlCommand("select * from Uyeler where UyeID=@UyeID");
            cmdUyeCek.Connection = baglan.baglan();

            KullaniciID = Session["UyeID"].ToString();
            cmdUyeCek.Parameters.AddWithValue("@UyeID", KullaniciID);

            DataTable dtUyeCek = new DataTable();
            SqlDataAdapter adpUyeCek = new SqlDataAdapter(cmdUyeCek);
            adpUyeCek.Fill(dtUyeCek);


            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("teknomarketteknomar@gmail.com");
                msg.To.Add(new MailAddress(dtUyeCek.Rows[0]["Email"].ToString()));
                msg.Subject = "TEKNOMAR ALIŞVERİŞ";
                msg.Body = "Siparişiniz alınmıştır bizi seçtiğiniz için teşekkür ederiz!";

                SmtpClient mySmtpClient = new SmtpClient();
                System.Net.NetworkCredential myCredential = new System.Net.NetworkCredential("teknomarketteknomar@gmail.com", "T3knomar");
                mySmtpClient.Host = "smtp.gmail.com";
                mySmtpClient.Port = 587;
                mySmtpClient.EnableSsl = true;
                mySmtpClient.UseDefaultCredentials = false;
                mySmtpClient.Credentials = myCredential;
                mySmtpClient.Send(msg);
                msg.Dispose();
            }
            catch (Exception exp)
            {
                Response.Write("Bu işte bir iş var" + exp);
            }
            try
            {
                for (int i = 0; i < sayi; i++)
                {

                
                if (turID[i]=="Anakart")
                {
                    SqlCommand cmdStokdanDus = new SqlCommand("update AnakartUrunler set Stok=Stok-@UrunAdet  where AnakartUrunID=@UrunID ", baglan.baglan());

                   
                    cmdStokdanDus.Parameters.AddWithValue("@UrunID", urunID[i]);
                        cmdStokdanDus.Parameters.AddWithValue("@UrunAdet", urunadetleri[i]);
                        cmdStokdanDus.ExecuteNonQuery();
                }
                if (turID[i]=="Islemci")
                {
                    SqlCommand cmdStokdanDus = new SqlCommand("update IslemciUrunler set Stok=Stok-@UrunAdet  where IslemciUrunID=@UrunID ", baglan.baglan());


                        cmdStokdanDus.Parameters.AddWithValue("@UrunID", urunID[i]);
                        cmdStokdanDus.Parameters.AddWithValue("@UrunAdet", urunadetleri[i]);
                        cmdStokdanDus.ExecuteNonQuery();
                }
                if (turID[i] == "EkranKartı")
                {
                    SqlCommand cmdStokdanDus = new SqlCommand("update EkranKartiUrunler set Stok=Stok-@UrunAdet  where EkranKartiUrunID = @UrunID ", baglan.baglan());


                        cmdStokdanDus.Parameters.AddWithValue("@UrunID", urunID[i]);
                        cmdStokdanDus.Parameters.AddWithValue("@UrunAdet", urunadetleri[i]);
                        cmdStokdanDus.ExecuteNonQuery();
                }
                }



            }
            catch (Exception)
            {
                
                Response.Write("Urun Zaten Stokta Yok.");
            }


       
            //SEPET SİLME KISMI
            SqlCommand cmdSepetSil = new SqlCommand("Delete Sepet where UyeID=@UyeID", baglan.baglan());

            KullaniciID = Session["UyeID"].ToString();
            cmdSepetSil.Parameters.AddWithValue("@UyeID", KullaniciID);
            cmdSepetSil.ExecuteNonQuery();
           
        }

        protected void btnSepetiBosalt_Click(object sender, EventArgs e)
        {
            SqlCommand cmdSepetSil = new SqlCommand("Delete Sepet where UyeID=@UyeID", baglan.baglan());

            KullaniciID = Session["UyeID"].ToString();
            cmdSepetSil.Parameters.AddWithValue("@UyeID", KullaniciID);
            cmdSepetSil.ExecuteNonQuery();
        }
    }
}