using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace siteTicaret
{
    public partial class main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnarama_Click(object sender, EventArgs e)
        {
            if (txtarama.Text.Contains(' ')) // Textbox'a girilen değer bir kelimemi yoksa birden fazlamı onu kontrol ediyorum. Eğer içinde boşluk varsa birden fazladır.
            {
                string[] girilenKelime = txtarama.Text.Split(' '); // Daha sonra textbox'taki değeri boşluğa göre Split edip bir diziye atıyorum.. Kelimeleri tek tek işleyebilmek için.
                string yol = "";  // Querystring üzerinde kullanabilmek için string yol değişkeni değeri boş olacak şekilde tanımlıyorum.


                for (int i = 0; i < girilenKelime.Length; i++) // Dizinin içinde dizinin boyutu kadar dönüyorum
                {
                    yol += "kelime" + i + "=" + girilenKelime[i] + "&";
                    //ve yol değişkenin querystring yolu olcak şekilde oluşturuyorum.
                    //bu for döngüsünün sonucu şu şekilde çıktı vericek...
                    // kelime0=....&kelime1=...& Ama sonda bir tane " & " işareti fazladan olacak.. Onu substringle yol'dan çıkarıyorum..

                }
                yol = yol.Substring(0, yol.Length - 1);


                Response.Redirect("arama.aspx?" + yol); // Daha sonra Response redirectla arama sayfasına querystring yolunu veriyorum..  Çalışmasını görelim..

                //Master'dan bir arama.aspx sayfası türetelim.. ve Page_Load altında kodları yazmaya başlıyalım..

            }

            else
            {
                Response.Redirect("Arama.aspx?kelime=" + txtarama.Text);


            }
        }
    }
}