﻿<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="ekrankartlari.aspx.cs" Inherits="siteTicaret.ekrankartlari" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="anayazi">

    <h1>Ekran Kartları</h1>
<p>  Ekran Kartı modelleri fiyatları ve Ekran Kartı markalarını en uygun özel taksit seçenekleriyle TEKNOMAR'da</p>
</div>

<div class="kutu">
<a class="active" href="">Ekran Kartları</a>
    <asp:CheckBoxList ID="chcEkranKartlari" CssClass="yy" runat="server">
        <asp:ListItem>AMD</asp:ListItem>
        <asp:ListItem>NVIDIA</asp:ListItem>

    </asp:CheckBoxList>

<div id="CollapsiblePanel1" class="CollapsiblePanel">

 <div class="CollapsiblePanelTab" tabindex="0"><a class="active" href="">Markalar</a></div>
  
  <div class="CollapsiblePanelContent">

      <asp:CheckBoxList ID="chcMarkalar" CssClass="yy" runat="server">
        <asp:ListItem>Asus</asp:ListItem>
        <asp:ListItem>Gigabyte</asp:ListItem>
          <asp:ListItem>MSI</asp:ListItem>
          <asp:ListItem>SAPPHIRE</asp:ListItem>
    </asp:CheckBoxList>

  </div>
  
</div>

<div id="CollapsiblePanel2" class="CollapsiblePanel">
  <div class="CollapsiblePanelTab" tabindex="0"><a class="active" href="">Fiyat Aralığı</a></div>
  <div class="CollapsiblePanelContent">
  <asp:CheckBoxList ID="chcFiyatAraligi" CssClass="yy" runat="server">
        <asp:ListItem Value="1">0-99</asp:ListItem>
        <asp:ListItem Value="2">100-199</asp:ListItem>
          <asp:ListItem Value="3">200-499</asp:ListItem>
      <asp:ListItem Value="4">500-999</asp:ListItem>
      <asp:ListItem Value="5">1000+</asp:ListItem>
    </asp:CheckBoxList>
  
  </div>
</div>



<div id="CollapsiblePanel3" class="CollapsiblePanel">
  <div class="CollapsiblePanelTab" tabindex="0"><a class="active" href="">RAM Kapasitesi</a></div>
  <div class="CollapsiblePanelContent">
  <asp:CheckBoxList ID="chcRamKapasitesi" CssClass="yy" runat="server">
        <asp:ListItem>2 GB</asp:ListItem>
          <asp:ListItem>4 GB</asp:ListItem>
          <asp:ListItem>8 GB</asp:ListItem>
          <asp:ListItem>11 GB</asp:ListItem>
    </asp:CheckBoxList>
 </div>
</div>


    <div class="fitrele">
    <asp:Button ID="btn_filtreleme" runat="server" CssClass="buton2" Text="FİLTRELE" OnClick="btn_filtreleme_Click"/>
    </div>
</div>


          
    
<div class="listeleme">
    
        <div class="konum">
            <p>Ekran Kartları</p>
        </div>
    
    <script type="text/javascript">
      
        <%

    var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
%>
               
        var Resimler = <%= serializer.Serialize(resimler) %>;
        var EkranKartiAdlari = <%= serializer.Serialize(ekrankartiadlari) %>;
        var EkranKartiIdler = <%= serializer.Serialize(idler) %>;
        var EkranKartiFiyatlar = <%= serializer.Serialize(fiyatlar) %>; 
        document.write("<table>");
        var sayac=0;
        var sayac2=4;
       
        var degisken2 =<%=sayi/4%>;
        for (var y = 0; y < degisken2+1; y++) {
            document.write("<tr>");
            for (var i = sayac; i < sayac2; i++) {
                if (EkranKartiIdler[i]==null) {
                    break;
    
                }
          
            document.write("<td>");

            document.write("<a href=\"urunsayfasi_ekrankartlari.aspx?secim="+EkranKartiIdler[i]+"\">")
            document.write("<div class=\"kolon2\"> ");
            document.write("<img src=\""   +Resimler[i]        +"  \" width=\"200\" height=\"200\">");
            document.write("<h2>"+EkranKartiFiyatlar[i]+" ₺"+"</h2>");
            document.write("<p>"+EkranKartiAdlari[i]+"</p>");
            document.write("</div> ");
            document.write("</a>");
            document.write("</td>");
           
            }
            
            document.write("</tr>");
            
           
                sayac=sayac+4;
                sayac2=sayac+4;
            
        }
       
        document.write("</table>");
       
    </script>
      
<script type="text/javascript">
var CollapsiblePanel1 = new Spry.Widget.CollapsiblePanel("CollapsiblePanel1", {contentIsOpen:true});

var CollapsiblePanel2 = new Spry.Widget.CollapsiblePanel("CollapsiblePanel2", {contentIsOpen:true});

var CollapsiblePanel3 = new Spry.Widget.CollapsiblePanel("CollapsiblePanel3", {contentIsOpen:false});

var CollapsiblePanel4 = new Spry.Widget.CollapsiblePanel("CollapsiblePanel4", {contentIsOpen:false});
</script>

</asp:Content>