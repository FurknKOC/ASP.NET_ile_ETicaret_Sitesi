<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="islemciler.aspx.cs" Inherits="siteTicaret.islemciler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
<div class="anayazi">

    <h1>İşlemciler</h1>
<p>  İşlemci modelleri fiyatları ve İşlemci markalarını en uygun özel taksit seçenekleriyle TEKNOMAR'da</p>
</div>

<div class="kutu">
<!--<ul>
<li><a class="active" href="">Anakartlar</a>
<ul>
<li class="yy"><b class="open"></b><a href="">AMD Uyumlu</a></li>
<li class="yy"><b class="open"></b><a href="">INTEL Uyumlu</a></li>
</ul>
</li>
</ul>--><a class="active" href="">Markalar</a>
    <asp:CheckBoxList ID="chcMarkalar" CssClass="yy" runat="server">
        <asp:ListItem>Intel</asp:ListItem>
        <asp:ListItem>AMD</asp:ListItem>

    </asp:CheckBoxList>

<div id="CollapsiblePanel1" class="CollapsiblePanel">

 <div class="CollapsiblePanelTab" tabindex="0"><a class="active" href="">İşlemciler</a></div>
  
  <div class="CollapsiblePanelContent">

      <asp:CheckBoxList ID="chcIslemciler" CssClass="yy" runat="server">
        <asp:ListItem>Soket 1150</asp:ListItem>
            <asp:ListItem>Soket 1151</asp:ListItem>
          <asp:ListItem>Soket AM3+</asp:ListItem>
          <asp:ListItem>Soket AM4</asp:ListItem>
          
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
  <div class="CollapsiblePanelTab" tabindex="0"><a class="active" href="">İşlemci Teknolojisi</a></div>
  <div class="CollapsiblePanelContent">
  <asp:CheckBoxList ID="chcIslemciTeknolojisi" CssClass="yy" runat="server">
        <asp:ListItem>Xeon</asp:ListItem>
          <asp:ListItem>Intel Core i7</asp:ListItem>
          <asp:ListItem>Intel Core i5</asp:ListItem>
          <asp:ListItem>Intel Core i3</asp:ListItem>
          <asp:ListItem>Intel Pentium</asp:ListItem>
          <asp:ListItem>AMD Ryzen 5</asp:ListItem>
          <asp:ListItem>AMD Ryzen 7</asp:ListItem>
    </asp:CheckBoxList>
 </div>
</div>


    <div class="fitrele">
    <asp:Button ID="btn_filtreleme" runat="server" CssClass="buton2" Text="FİLTRELE" OnClick="btn_filtreleme_Click" />
    </div>
</div>


          
    
<div class="listeleme">
    
        <div class="konum">
            <p>İŞLEMCİLER</p>
        </div>
    
    <script type="text/javascript">
      
        <%

    var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
%>
               
        var Resimler = <%= serializer.Serialize(resimler) %>;
        var IslemciAdlari = <%= serializer.Serialize(islemciadlari) %>;
        var IslemciIdler = <%= serializer.Serialize(idler) %>;
        var IslemciFiyatlar = <%= serializer.Serialize(fiyatlar) %>; 
        document.write("<table>");
        var sayac=0;
        var sayac2=4;
       
        var degisken2 =<%=sayi/4%>;
        for (var y = 0; y < degisken2+1; y++) {
            document.write("<tr>");
            for (var i = sayac; i < sayac2; i++) {
                if (IslemciIdler[i]==null) {
                    break;
    
                }
          
            document.write("<td>");

            document.write("<a href=\"urunsayfasi_islemci.aspx?secim="+IslemciIdler[i]+"\">")
            document.write("<div class=\"kolon2\"> ");
            document.write("<img src=\""   +Resimler[i]        +"  \" width=\"200\" height=\"200\">");
            document.write("<h2>"+IslemciFiyatlar[i]+" ₺"+"</h2>");
            document.write("<p>"+IslemciAdlari[i]+"</p>");
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
