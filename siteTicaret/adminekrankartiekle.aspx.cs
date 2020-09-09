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
    public partial class adminekrankartiekle : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kadi"] == null && Session["sifre"] == null)
            {
                Response.Redirect("admingiris.aspx");
            }
        }
        public double Fiyat;

        protected void Button2_Click(object sender, EventArgs e)
        {
            Fiyat = Convert.ToDouble(txtfiyat.Text);
            SqlCommand cmd = new SqlCommand("insert into EkranKartiUrunler (EkranKartiAdi,Marka,Fiyat,Stok,CekirdekHizi,RamKapasitesi,BellekHizi,GrafikChipsetiMarkasi,EkranKartiChipseti,BellekTipi,BellekArayuzu,PciExpress3,DisplayPort,HdcpDestegi,Dvi,Hdmi,GucTuketimi,Mensei,Garanti,Cozunurluk,resim1,resim2,resim3) values (@EkranKartiAdi,@Marka,@Fiyat,@Stok,@CekirdekHizi,@RamKapasitesi,@BellekHizi,@GrafikChipsetiMarkasi,@EkranKartiChipseti,@BellekTipi,@BellekArayuzu,@PciExpress3,@DisplayPort,@HdcpDestegi,@Dvi,@Hdmi,@GucTuketimi,@Mensei,@Garanti,@Cozunurluk,@resim1,@resim2,@resim3)", baglan.baglan());
            cmd.Connection = baglan.baglan();

            cmd.Parameters.AddWithValue("@EkranKartiAdi", txtekrankartiadi.Text);
            cmd.Parameters.AddWithValue("@Marka", drpmarka.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Fiyat", Fiyat);
            cmd.Parameters.AddWithValue("@Stok", txtstok.Text);
            cmd.Parameters.AddWithValue("@CekirdekHizi", drpcekirdekhizi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@RamKapasitesi", drpramkapasitesi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@BellekHizi", drpbellekhizi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@GrafikChipsetiMarkasi", drpgrafikchipsetimarkasi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@EkranKartiChipseti", drpekrankartichipseti.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@BellekTipi", drpbellektipi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@BellekArayuzu", drpbellekarayuzu.SelectedValue.ToString());
            if (chcpciexpress3.Checked)
            {
                cmd.Parameters.AddWithValue("@PciExpress3", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@PciExpress3", "Yok");
            }
            if (chcdisplayport.Checked)
            {
                cmd.Parameters.AddWithValue("@DisplayPort", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@DisplayPort", "Yok");
            }
            if (chchdcpdestegi.Checked)
            {
                cmd.Parameters.AddWithValue("@HdcpDestegi", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@HdcpDestegi", "Yok");
            }

            if (chcdvi.Checked)
            {
                cmd.Parameters.AddWithValue("@Dvi", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@Dvi", "Yok");
            }
            if (chchdmi.Checked)
            {
                cmd.Parameters.AddWithValue("@Hdmi", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@Hdmi", "Yok");
            }
            cmd.Parameters.AddWithValue("@GucTuketimi", drpguctuketimi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Mensei", txtmensei.Text);
            cmd.Parameters.AddWithValue("@Garanti", txtgaranti.Text);
            cmd.Parameters.AddWithValue("@Cozunurluk", drpcozunurluk.SelectedValue.ToString());
            if (fileresim1.HasFile)
                try
                {
                    fileresim1.SaveAs("C:\\Users\\Furkan KOÇ\\Documents\\Visual Studio 2015\\Projects\\siteTicaret\\siteTicaret\\images\\" + fileresim1.FileName);
                    string resim1 = "images/" + fileresim1.PostedFile.FileName;
                    cmd.Parameters.AddWithValue("@resim1", resim1);
                }
                catch (Exception ex)
                {
                    Label1.Text = "Hata Oluştu: " + ex.Message.ToString();
                }
            if (fileresim2.HasFile)
                try
                {
                    fileresim2.SaveAs("C:\\Users\\Furkan KOÇ\\Documents\\Visual Studio 2015\\Projects\\siteTicaret\\siteTicaret\\images\\" + fileresim2.FileName);
                    string resim2 = "images/" + fileresim2.PostedFile.FileName;
                    cmd.Parameters.AddWithValue("@resim2", resim2);
                }
                catch (Exception ex)
                {
                    Label1.Text = "Hata Oluştu: " + ex.Message.ToString();
                }
            if (fileresim3.HasFile)
                try
                {
                    fileresim3.SaveAs("C:\\Users\\Furkan KOÇ\\Documents\\Visual Studio 2015\\Projects\\siteTicaret\\siteTicaret\\images\\" + fileresim3.FileName);
                    string resim3 = "images/" + fileresim3.PostedFile.FileName;
                    cmd.Parameters.AddWithValue("@resim3", resim3);
                }
                catch (Exception ex)
                {
                    Label1.Text = "Hata Oluştu: " + ex.Message.ToString();
                }
            cmd.ExecuteNonQuery();
        }
    }
}