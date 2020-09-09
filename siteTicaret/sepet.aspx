<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="sepet.aspx.cs" Inherits="siteTicaret.sepet1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     
        
  <div id="TabbedPanels1" class="TabbedPanels">
    <ul class="TabbedPanelsTabGroup">
      <li class="TabbedPanelsTab" tabindex="0">SEPETİM</li>
      <li class="TabbedPanelsTab" tabindex="0">ADRESİM</li>
      <li class="TabbedPanelsTab" tabindex="0">ÖDEME</li>
    </ul>
    <div class="TabbedPanelsContentGroup">
      <div class="TabbedPanelsContent">
      
      
            <div class="sepeteheader" >
                <a href="#"><img src="images/LOGOo.fw.png"/></a>
                
            </div>

              <div class="sepeticerik">  <script type="text/javascript">
      
     <%

    var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
%>
               
        var UrunAdlari = <%= serializer.Serialize(urunadlari) %>;
        var UrunResimleri = <%= serializer.Serialize(urunresimleri) %>;
        var UrunAdetleri = <%= serializer.Serialize(urunadetleri) %>;
        var UrunFiyatlari = <%= serializer.Serialize(urunfiyatlari) %>;  
        var UrunToplamFiyatlari = <%= serializer.Serialize(uruntoplamfiyatlari) %>; 
        for (var y = 0; y < <%=sayi%>; y++) {
            document.write("<div class=\"sepeticerik2\"> ");
            document.write("<table cellpadding=\"0\" border=\"0\" cellspacing=\"0\" class=\"iceriktablo\">");
            document.write("<tr>");
            document.write("<td><img src=\""   +UrunResimleri[y]   +"\" height=\"90\" width=\"90\" /></td>");
            document.write("<td><h3>"+UrunAdlari[y]+"</h3></td>");
            document.write("<td><h3>"+UrunAdetleri[y]+"</h3></td>");
            document.write("<td><h3>"+UrunFiyatlari[y]+" ₺"+"</h3></td>");
            document.write("</tr>");
            document.write("</table>"); 
            document.write("</div> ");
        }
                                             
              </script>
                  
          <div class="icerik3">
        <table class="toplamfiyat">
        <tr>
        <td><h3>Toplam Tutar:</h3></td>
        <td><h3><%=toplamfiyat%></h3></td>
        </tr>
        <tr>
        <td>
            <asp:Button ID="btnSepetiBosalt" runat="server" CssClass="satinalbutonu" Text="Sepeti Boşalt" OnClick="btnSepetiBosalt_Click" /></td><td></td>
        <td><asp:Button ID="Button1" runat="server" Text="DEVAM ET" CssClass="satinalbutonu" OnClientClick="TabbedPanels1.showPanel(1); return false;"/> </td>
        </tr>
        </table>
       </div> </div>
           
      </div>
      <div class="TabbedPanelsContent">
      
       
            <div class="sepeteheader" >
                <a href="#"><img src="images/LOGOo.fw.png"/></a>
                
            </div>

           
          <div class="sepeticerik"> <div class="sepeticerik2">
             <table cellpadding="0" border="0" cellspacing="0" class="iceriktablo">
            <tr>
            <td>Adınız:</td>
            <td class="input">
                <asp:TextBox ID="txtAd" runat="server"></asp:TextBox> </td>
            </tr>
             <tr>
            <td>Soyadınız:</td>
            <td class="input"><asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox> </td>
            </tr>
            <tr>
            <td>Şehir Adı:</td>
            <td class="input"><asp:TextBox ID="txtSehir" runat="server"></asp:TextBox> </td>
            </tr>
                  <tr>
            <td>İlçe Adı:</td>
            <td class="input"><asp:TextBox ID="txtIlce" runat="server"></asp:TextBox> </td>
            </tr>
                  <tr>
            <td>Adres:</td>
            <td class="input"><asp:TextBox ID="txtAdres" runat="server"></asp:TextBox> </td>
            </tr>
                  <tr>
            <td>Telefon:</td>
            <td class="input"><asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox> </td>
            </tr>
            </table>
             </div>

            <table class="toplamfiyat">
            <tr>
            <td></td>
            <td> <asp:Button ID="Button2" runat="server" Text="DEVAM ET" CssClass="satinalbutonu" OnClientClick="TabbedPanels1.showPanel(2); return false;" /></td> 
           </tr>
            </table></div>
            
            
      
      </div>
      <div class="TabbedPanelsContent">
      
       <div id="sepet">
	
		<div id="sepet3">
            <div class="sepeteheader" >
                <a href="#"><img src="images/LOGOo.fw.png"/></a>
                
            </div>
            
            <div class="sepeticerik"> 
                <div class="sepeticerik2">
                <div id="odemesecenek">
                <table class="odemesecenektablo">
                <tr>
                <td class="odemeresim"><img src="images/kargokapi.png" /></td>
                <td class="odemebaslik">Kargo Bedava</td>
                <td class="odemeyazi"><a href="">TEKNOMAR</a>'dan yapacağınız alışverişlerinizde KARGO BEDAVA</td>
                </tr>
                <tr>
                <td><img src="images/kapidaodeme.png"/></td>
                <td class="odemebaslik">Kapıda Nakit Ödeme</td>
                <td class="odemeyazi">İnternetten alışveriş <a href="">TEKNOMAR</a> ile çok kolay.</td>
                </tr>
                <tr>
                <td class="odemeresim2"><img src="images/geriiade.png"/></td>
                <td class="odemebaslik">15 Gün İade</td>
                <td class="odemeyazi"><a href="">TEKNOMAR</a>'dan almış olduğunuz ve hiç kullanmadığınız ürünleri 15 gün içerisinde iade edebilir veya değiştirebilirsiniz.</td>
                
                            
                       
                </tr>
                    
                        
                    
                </table>
                    </div>
                    </div>
                <table class="toplamfiyat">
            <tr>
            <td></td>
            <td> <asp:Button ID="Button3" CssClass="satinalbutonu" runat="server" Text="SATIN AL" OnClick="Button3_Click" /></td> 
           </tr>
            </table>
       
                 
            </div>
            
            
            
            
		</div>
        
        </div>
	</div>

      
      </div>
      </div>
   


<script type="text/javascript">
var TabbedPanels1 = new Spry.Widget.TabbedPanels("TabbedPanels1");
</script>
    
</asp:Content>
