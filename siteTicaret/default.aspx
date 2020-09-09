<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="siteTicaret._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="slide">
<div class="slider-wrapper theme-default">
    <div class="ribbon"></div>
<div id="slider" class="nivoSlider">
    <a href="urunsayfasi_islemci.aspx?secim=2"><img src="images/slider1.jpg" alt="" /></a>
	<a href="urunsayfasi.aspx?secim=17"><img src="images/slider2.jpg" alt="" title="" /></a>
    <a href="urunsayfasi_ekrankartlari.aspx?secim=3"><img src="images/slider4.jpg" alt="" title="" /></a>
    </div>
</div>
</div>


    <h2 id="yazi1">Öne Çıkan Ürünler</h2>

    <script type="text/javascript">
        if (<%=rastgele%>==1) {
      <%
   
    var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
%>      
        var Resimler = <%= serializer.Serialize(resimler) %>;
        var Adlar = <%= serializer.Serialize(adlar) %>;
        var Idler = <%= serializer.Serialize(idler) %>;
        var Fiyatlar = <%= serializer.Serialize(fiyatlar) %>;
        document.write("<div class=\"a\"> ");
        for (var y = 0; y <3; y++) {
            
            document.write("<a href=\"urunsayfasi.aspx?secim="+Idler[y]+"\">")
            document.write("<div class=\"kolon2\"> ");
            document.write("<img src=\""   +Resimler[y]        +"  \" width=\"200\" height=\"200\">");
            document.write("<h2>"+Fiyatlar[y]+" ₺"+"</h2>");
            document.write("<p>"+Adlar[y]+"</p>");
            document.write("</div> ");
            document.write("</a>"); 
        }
        document.write("</div> ");
        }
       if (<%=rastgele%>==2) {
      <%
   
    var serializerr = new System.Web.Script.Serialization.JavaScriptSerializer();
%>      
        var Resimler = <%= serializerr.Serialize(resimler) %>;
        var Adlar = <%= serializerr.Serialize(adlar) %>;
        var Idler = <%= serializerr.Serialize(idler) %>;
        var Fiyatlar = <%= serializerr.Serialize(fiyatlar) %>;
        document.write("<div class=\"a\"> ");
        for (var y = 0; y < 3; y++) {
            
            document.write("<a href=\"urunsayfasi_islemci.aspx?secim="+Idler[y]+"\">")
            document.write("<div class=\"kolon2\"> ");
            document.write("<img src=\""   +Resimler[y]        +"  \" width=\"200\" height=\"200\">");
            document.write("<h2>"+Fiyatlar[y]+" ₺"+"</h2>");
            document.write("<p>"+Adlar[y]+"</p>");
            document.write("</div> ");
            document.write("</a>"); 
        }
        document.write("</div> ");
        }
        if (<%=rastgele%>==3) {
      <%
   
    var serializerrr = new System.Web.Script.Serialization.JavaScriptSerializer();
%>      
        var Resimler = <%= serializerrr.Serialize(resimler) %>;
        var Adlar = <%= serializerrr.Serialize(adlar) %>;
        var Idler = <%= serializerrr.Serialize(idler) %>;
        var Fiyatlar = <%= serializerrr.Serialize(fiyatlar) %>;
        document.write("<div class=\"a\"> ");
        for (var y = 0; y < 3; y++) {
            
            document.write("<a href=\"urunsayfasi_ekrankartlari.aspx?secim="+Idler[y]+"\">")
            document.write("<div class=\"kolon2\"> ");
            document.write("<img src=\""   +Resimler[y]        +"  \" width=\"200\" height=\"200\">");
            document.write("<h2>"+Fiyatlar[y]+" ₺"+"</h2>");
            document.write("<p>"+Adlar[y]+"</p>");
            document.write("</div> ");
            document.write("</a>"); 
        }
        document.write("</div> ");
        }
      
        
    </script>

				<div class="a">
                <div style="clear: both"></div>
				</div>

			<h2 id="yazi1">Satılan Ürünler</h2>
    <script type="text/javascript">

        <%var serializerSatilan = new System.Web.Script.Serialization.JavaScriptSerializer();%>
               
                            var Resimler = <%= serializerSatilan.Serialize(siparisresimler) %>;
                            var UrunlerinAdlari = <%= serializerSatilan.Serialize(siparisadlar) %>;
                            var UrunlerinIdleri = <%= serializerSatilan.Serialize(siparisidler) %>;
                            var UrunlerinFiyatlari = <%= serializerSatilan.Serialize(siparisfiyatlar) %>;  
                            var TurID= <%=serializerSatilan.Serialize(SiparisTurIdler)%>;
                            document.write("<div class=\"a\"> ");
                            for (var y = 0; y < <%=sayiSiparis%>; y++) {
                                if (TurID[y]=="Anakart") {
                                    document.write("<a href=\"urunsayfasi.aspx?secim="+UrunlerinIdleri[y]+"\">")
                                    document.write("<div class=\"kolon2\"> ");
                                    document.write("<img src=\""   +Resimler[y]        +"  \" width=\"200\" height=\"200\">");
                                    document.write("<h2>"+UrunlerinFiyatlari[y]+" ₺"+"</h2>");
                                    document.write("<p>"+UrunlerinAdlari[y]+"</p>");
                                    document.write("</div> ");
                                    document.write("</a>"); 
                                }
                                
                                document.write("<div class=\"a\"> ");
                                if (TurID[y]=="Islemci") {
                                    document.write("<a href=\"urunsayfasi_islemci.aspx?secim="+UrunlerinIdleri[y]+"\">")
                                    document.write("<div class=\"kolon2\"> ");
                                    document.write("<img src=\""   +Resimler[y]        +"  \" width=\"200\" height=\"200\">");
                                    document.write("<h2>"+UrunlerinFiyatlari[y]+" ₺"+"</h2>");
                                    document.write("<p>"+UrunlerinAdlari[y]+"</p>");
                                    document.write("</div> ");
                                    document.write("</a>"); 
                                }
                                document.write("</div> ");
                                if (TurID[y]=="EkranKartı") {
                                    document.write("<a href=\"urunsayfasi_ekrankartlari.aspx?secim="+UrunlerinIdleri[y]+"\">")
                                    document.write("<div class=\"kolon2\"> ");
                                    document.write("<img src=\""   +Resimler[y]        +"  \" width=\"200\" height=\"200\">");
                                    document.write("<h2>"+UrunlerinFiyatlari[y]+" ₺"+"</h2>");
                                    document.write("<p>"+UrunlerinAdlari[y]+"</p>");
                                    document.write("</div> ");
                                    document.write("</a>"); 
                                }
                                document.write("</div> ");
                            }
                       
                        </script>
        



</asp:Content>
