<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="arama.aspx.cs" Inherits="siteTicaret.arama" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="aramasayfasi">
                <script type="text/javascript">

        <%var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();%>
               
                            var AnakartResimler = <%= serializer.Serialize(anakartresimler) %>;
                            var AnakartAdlari = <%= serializer.Serialize(anakartadlar) %>;
                            var AnakartIdleri = <%= serializer.Serialize(anakartidler) %>;
                            var AnakartFiyatlari = <%= serializer.Serialize(anakartfiyatlar) %>;  
                            
                            
                            for (var y = 0; y < <%=sayi%>; y++) {
                               
                                document.write("<a href=\"urunsayfasi.aspx?secim="+AnakartIdleri[y]+"\"><ul class=\"siparis\"> ");
                                document.write("<li class=\"deneme\"><img src="+AnakartResimler[y]+" width=\"100\" height=\"100\">");
                                document.write("<h2>"+AnakartFiyatlari[y]+"</h2>");
                                document.write("<p>"+AnakartAdlari[y]+"</p>");
                                document.write("</li>"); 
                                document.write("</ul></a>");
                                
                            }

                            var IslemciResimler = <%= serializer.Serialize(islemciresimler) %>;
                            var IslemciAdlar = <%= serializer.Serialize(islemciadlar) %>;
                            var IslemciIdler = <%= serializer.Serialize(islemciidler) %>;
                            var IslemciFiyatlar = <%= serializer.Serialize(islemcifiyatlar) %>;  
                            
                            
                            for (var y = 0; y < <%=sayi2%>; y++) {
                               
                                document.write("<a href=\"urunsayfasi_islemci.aspx?secim="+IslemciIdler[y]+"\"><ul class=\"siparis\"> ");
                                document.write("<li class=\"deneme\"><img src="+IslemciResimler[y]+" width=\"100\" height=\"100\">");
                                document.write("<h2>"+IslemciFiyatlar[y]+"</h2>");
                                document.write("<p>"+IslemciAdlar[y]+"</p>");
                                document.write("</li>"); 
                                document.write("</ul></a>");
                                
                            }

                            var EkranKartiResimler = <%= serializer.Serialize(ekrankartiresimler) %>;
                            var EkranKartiAdlar = <%= serializer.Serialize(ekrankartiadlar) %>;
                            var EkranKartiIdler = <%= serializer.Serialize(ekrankartiidler) %>;
                            var EkranKartiFiyatlar = <%= serializer.Serialize(ekrankartifiyatlar) %>;  
                            
                            
                            for (var y = 0; y < <%=sayi3%>; y++) {
                               
                                document.write("<a href=\"urunsayfasi_ekrankartlari.aspx?secim="+EkranKartiIdler[y]+"\"><ul class=\"siparis\"> ");
                                document.write("<li class=\"deneme\"><img src="+EkranKartiResimler[y]+" width=\"100\" height=\"100\">");
                                document.write("<h2>"+EkranKartiFiyatlar[y]+"</h2>");
                                document.write("<p>"+EkranKartiAdlar[y]+"</p>");
                                document.write("</li>"); 
                                document.write("</ul></a>");
                                
                            }
                       
                        </script>
        </div>
</asp:Content>
