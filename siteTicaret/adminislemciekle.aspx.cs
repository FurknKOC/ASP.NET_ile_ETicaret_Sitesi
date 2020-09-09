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
    public partial class adminislemciekle : System.Web.UI.Page
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
            SqlCommand cmd = new SqlCommand("insert into IslemciUrunler (IslemciAdi,Marka,Fiyat,Stok,IslemciSoketTipi,IslemciNumarasi,IslemciTeknolojisi,IslemciHizi,IslemciOnBellek,Mensei,Garanti,KutuluKutusuz,resim1) values (@IslemciAdi,@Marka,@Fiyat,@Stok,@IslemciSoketTipi,@IslemciNumarasi,@IslemciTeknolojisi,@IslemciHizi,@IslemciOnBellek,@Mensei,@Garanti,@KutuluKutusuz,@resim1)", baglan.baglan());
            cmd.Connection = baglan.baglan();

            cmd.Parameters.AddWithValue("@IslemciAdi", txtislemciadi.Text);
            cmd.Parameters.AddWithValue("@Marka", drpmarka.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Fiyat", Fiyat);
            cmd.Parameters.AddWithValue("@Stok", txtstok.Text);
            cmd.Parameters.AddWithValue("@IslemciSoketTipi", drpislemcisokettipi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@IslemciNumarasi", drpislemcinumarasi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@IslemciTeknolojisi", drpislemciteknolojisi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@IslemciHizi", drpislemcihizi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@IslemciOnBellek", drpislemcionbellek.SelectedValue.ToString());
            if (chckutulukutusuz.Checked)
            {
                cmd.Parameters.AddWithValue("@KutuluKutusuz", "Kutulu");
            }
            else
            {
                cmd.Parameters.AddWithValue("@KutuluKutusuz", "Kutusuz");
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
            cmd.ExecuteNonQuery();
           
        }
    }
}