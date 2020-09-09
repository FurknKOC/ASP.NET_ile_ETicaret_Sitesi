﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace siteTicaret
{
    public partial class adminekrankartistokbilgi : System.Web.UI.Page
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public int sayi;
        public int UrunID;
        public string resim;
        public string[] adlar;
        public static string[] resimler;
        public int[] stoklar;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kadi"] == null && Session["sifre"] == null)
            {
                Response.Redirect("admingiris.aspx");
            }

            SqlCommand cmd = new SqlCommand("select * from EkranKartiUrunler");
            cmd.Connection = baglan.baglan();

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            sayi = dt.Rows.Count;
            adlar = new string[sayi];
            resimler = new string[sayi];
            stoklar = new int[sayi];
            //Session["secim"] = Convert.ToInt32(dt.Rows[0]["AnakartUrunID"]);


            for (int i = 0; i < sayi; i++)
            {
                stoklar[i] = Convert.ToInt32(dt.Rows[i]["Stok"]);
                resimler[i] = dt.Rows[i]["resim1"].ToString();
                adlar[i] = dt.Rows[i]["EkranKartiAdi"].ToString();
            }
        }
    }
}