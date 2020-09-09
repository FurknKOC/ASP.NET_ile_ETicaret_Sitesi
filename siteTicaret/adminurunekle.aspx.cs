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
    public partial class urunekle : System.Web.UI.Page
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
            SqlCommand cmd = new SqlCommand("insert into AnakartUrunler (AnakartAdi,Marka,Fiyat,Stok,Uyumluluk,Yapi,IslemciSoketTipi,RamTipi,MbChipSeti,MbRamSlotSayisi,SpdifCikisi,Ps2,Sekizkanal,Ethernet,KablosuzWifi,usb2,usb3,ClearCmosButon,SupremeFX,BlueTooth,Ses,PciExpress,Sata3,SataExpress,M2Sata,CoreI7,Mensei,Garanti,resim1,resim2,resim3,resim4) values (@AnakartAdi,@Marka,@Fiyat,@Stok,@Uyumluluk,@Yapi,@IslemciSoketTipi,@RamTipi,@MbChipSeti,@MbRamSlotSayisi,@SpdifCikisi,@Ps2,@Sekizkanal,@Ethernet,@KablosuzWifi,@usb2,@usb3,@ClearCmosButon,@SupremeFX,@BlueTooth,@Ses,@PciExpress,@Sata3,@SataExpress,@M2Sata,@CoreI7,@Mensei,@Garanti,@resim1,@resim2,@resim3,@resim4)", baglan.baglan());
            cmd.Connection = baglan.baglan();

            cmd.Parameters.AddWithValue("@AnakartAdi", txtanakartadi.Text);
            cmd.Parameters.AddWithValue("@Marka", drpmarka.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Fiyat", Fiyat);
            cmd.Parameters.AddWithValue("@Stok", txtstok.Text);
            cmd.Parameters.AddWithValue("@Uyumluluk", drpuyumluluk.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Yapi", drpyapi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@IslemciSoketTipi", drpislemcisokettipi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@RamTipi", drpramtipi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@MbChipSeti", drpmbchipseti.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@MbRamSlotSayisi", drpmbramslotsayisi.SelectedValue.ToString());
            if (chcspdif.Checked)
            {
                cmd.Parameters.AddWithValue("@SpdifCikisi", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@SpdifCikisi", "Yok");
            }
            if (chcps2.Checked)
            {
                cmd.Parameters.AddWithValue("@Ps2", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@Ps2", "Yok");
            }
            if (chcsekizkanal.Checked)
            {
                cmd.Parameters.AddWithValue("@Sekizkanal", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@Sekizkanal", "Yok");
            }

            if (chcethernet.Checked)
            {
                cmd.Parameters.AddWithValue("@Ethernet", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@Ethernet", "Yok");
            }
            if (chcwifi.Checked)
            {
                cmd.Parameters.AddWithValue("@KablosuzWifi", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@KablosuzWifi", "Yok");
            }
            if (chcusb2.Checked)
            {
                cmd.Parameters.AddWithValue("@usb2", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@usb2", "Yok");
            }
            if (chcusb3.Checked)
            {
                cmd.Parameters.AddWithValue("@usb3", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@usb3", "Yok");
            }
            if (chcclearcmosbuton.Checked)
            {
                cmd.Parameters.AddWithValue("@ClearCmosButon", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@ClearCmosButon", "Yok");
            }
            if (chcsupremefx.Checked)
            {
                cmd.Parameters.AddWithValue("@SupremeFX", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@SupremeFX", "Yok");
            }
            if (chcbluetooth.Checked)
            {
                cmd.Parameters.AddWithValue("@Bluetooth", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@Bluetooth", "Yok");
            }
            if (chcses.Checked)
            {
                cmd.Parameters.AddWithValue("@Ses", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@Ses", "Yok");
            }
            if (chcpciexpress.Checked)
            {
                cmd.Parameters.AddWithValue("@PciExpress", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@PciExpress", "Yok");
            }
            if (chcsata3.Checked)
            {
                cmd.Parameters.AddWithValue("@Sata3", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@Sata3", "Yok");
            }
            if (chcsataexpress.Checked)
            {
                cmd.Parameters.AddWithValue("@SataExpress", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@SataExpress", "Yok");
            }
            if (chcm2sata.Checked)
            {
                cmd.Parameters.AddWithValue("@M2Sata", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@M2Sata", "Yok");
            }
            if (chccorei7.Checked)
            {
                cmd.Parameters.AddWithValue("@CoreI7", "Var");
            }
            else
            {
                cmd.Parameters.AddWithValue("@CoreI7", "Yok");
            }
            cmd.Parameters.AddWithValue("@Mensei", txtmensei.Text);
            cmd.Parameters.AddWithValue("@Garanti", txtgaranti.Text);
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
            if (fileresim4.HasFile)
                try
                {
                    fileresim4.SaveAs("C:\\Users\\Furkan KOÇ\\Documents\\Visual Studio 2015\\Projects\\siteTicaret\\siteTicaret\\images\\" + fileresim4.FileName);
                    string resim4 = "images/" + fileresim4.PostedFile.FileName;
                    cmd.Parameters.AddWithValue("@resim4", resim4);
                }
                catch (Exception ex)
                {
                    Label1.Text = "Hata Oluştu: " + ex.Message.ToString();
                }
            cmd.ExecuteNonQuery();
        }
    }
}