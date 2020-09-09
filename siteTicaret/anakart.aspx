<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="anakart.aspx.cs" Inherits="siteTicaret.anakart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
<div class="anayazi">

    <h1>Anakartlar</h1>
<p>  Anakart modelleri fiyatları ve anakart markalarını en uygun özel taksit seçenekleriyle TEKNOMAR'da</p>
</div>

<div class="kutu">
<a class="active" href="">Uyumluluk</a>
    <asp:CheckBoxList ID="chcUyumluluk" CssClass="yy" runat="server">
        <asp:ListItem Value="Amd">Amd</asp:ListItem>
        <asp:ListItem>Intel</asp:ListItem>

    </asp:CheckBoxList>

<div id="CollapsiblePanel1" class="CollapsiblePanel">

 <div class="CollapsiblePanelTab" tabindex="0"><a class="active" href="">Markalar</a></div>
  
  <div class="CollapsiblePanelContent">

      <asp:CheckBoxList ID="chcMarkalar" CssClass="yy" runat="server">
        <asp:ListItem>Asus</asp:ListItem>
        <asp:ListItem>Gigabyte</asp:ListItem>
          <asp:ListItem>MSI</asp:ListItem>
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
  <div class="CollapsiblePanelTab" tabindex="0"><a class="active" href="">RAM Tipi</a></div>
  <div class="CollapsiblePanelContent">
  <asp:CheckBoxList ID="chcRamTipi" CssClass="yy" runat="server">
        <asp:ListItem>DDR3</asp:ListItem>
        <asp:ListItem>DDR4</asp:ListItem>
      
    </asp:CheckBoxList>
 </div>
</div>


    <div class="fitrele">
    <asp:Button ID="btn_filtreleme" runat="server" CssClass="buton2" Text="FİLTRELE" OnClick="btn_filtreleme_Click" />
    </div>
</div>

    
<div class="listeleme">
    
        <div class="konum">
            <p>ANAKARTLAR</p>
        </div>
    
    <script type="text/javascript">
      
        <%

    var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
%>
               
        var Resimler = <%= serializer.Serialize(resimler) %>;
        var AnakartAdlari = <%= serializer.Serialize(anakartadlari) %>;
        var AnakartIdler = <%= serializer.Serialize(idler) %>;
        var AnakartFiyatlar = <%= serializer.Serialize(fiyatlar) %>; 
        document.write("<table>");
        var sayac=0;
        var sayac2=4;
       
        var degisken2 =<%=sayi/4%>;
        for (var y = 0; y < degisken2+1; y++) {
            document.write("<tr>");
            for (var i = sayac; i < sayac2; i++) {
                if (AnakartIdler[i]==null) {
                    break;
    
                }
          
            document.write("<td>");

            document.write("<a href=\"urunsayfasi.aspx?secim="+AnakartIdler[i]+"\">")
            document.write("<div class=\"kolon2\"> ");
            document.write("<img src=\""   +Resimler[i]        +"  \" width=\"200\" height=\"200\">");
            document.write("<h2>"+AnakartFiyatlar[i]+" ₺"+"</h2>");
            document.write("<p>"+AnakartAdlari[i]+"</p>");
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
            
      
				</div>
 
<script type="text/javascript">

var CollapsiblePanel1 = new Spry.Widget.CollapsiblePanel("CollapsiblePanel1", {contentIsOpen:true});

var CollapsiblePanel2 = new Spry.Widget.CollapsiblePanel("CollapsiblePanel2", {contentIsOpen:true});

var CollapsiblePanel3 = new Spry.Widget.CollapsiblePanel("CollapsiblePanel3", {contentIsOpen:false});

var CollapsiblePanel4 = new Spry.Widget.CollapsiblePanel("CollapsiblePanel4", {contentIsOpen:false});
</script>
    
 
</asp:Content>
