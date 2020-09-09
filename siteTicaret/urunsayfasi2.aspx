<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="urunsayfasi.aspx.cs" Inherits="siteTicaret.urunsayfasi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script language="javascript" type="application/javascript">
       
isim=new Array();
isim[0] = "<%=resim%>";
isim[1] = "<%=resim2%>";
isim[2] = "<%=resim3%>";
isim[3] = "<%=resim4%>";
var i=0;
slider=function slider1(){	
	document.getElementById('resim').src=isim[i];i++;
	if(i==6){
	i=0;	
	}
}

function deneme(lnk){
document.getElementById('resim').src=lnk;
clearInterval(zaman);
}
</script>
    <div class="urunsayfasi1">
        <img id="resim" src="<%=resim%>" width="400px" height="400px"  />
        <div class="resimler">
        <ul>
	        <li><a href="<%=resim%>" data-lightbox="<%=resim%>" onmouseover="deneme('<%=resim%>')"><img src="<%=resim%>" width="70" height="72" /></a></li>
            <li><a href="<%=resim2%>" data-lightbox="<%=resim2%>" onmouseover="deneme('<%=resim2%>')"><img src="<%=resim2%>" width="70" height="72" /></a></li>
            <li><a href="<%=resim3%>" data-lightbox="<%=resim3%>" onmouseover="deneme('<%=resim3%>')"><img src="<%=resim3%>" width="70" height="72" /></a></li>
            <li><a href="<%=resim4%>" data-lightbox="<%=resim4%>" onmouseover="deneme('<%=resim4%>')"><img src="<%=resim4%>" width="70" height="72" /></a></li>
        </ul>
            

        </div>
 <div class="sekil">
     <img src="images/ayni.png" height="30" /><img src="images/kargo.png" height="30" /></div>

    </div>

    <div class="urunsayfasi2">
        <div class="ortala">
        <h1><%=anakartadi%></h1>
        <p id="p2"><%=fiyat%></p>
        <select class="sayi">
            <option>1</option>
            <option>2</option>
         </select>
        <input value="SEPETE EKLE" type="submit" class="buton"/></div>

        <p id="p3">MB Chipseti<b> <%=mbchipseti%></b></p>
        <p id="p3">Core i7 <b><%=corei7%></b></p>
        <p id="p3">MB Ram Slot Sayısı<b><%=mbramslotsayisi%></b></p>
       <p id="p3">RAM Tipi	<b><%=ramtipi%></b></p> 
        <p id="p3">İşlemci Soket Tipi <b><%=islemcisokettipi%></b></p> 
        <a href="#">Daha Çok Özellik</a>
        	
           </div>

    <div class="altkisim">
  <div id="TabbedPanels1" class="TabbedPanels">
    <ul class="TabbedPanelsTabGroup">
      <li class="TabbedPanelsTab" tabindex="0">ÜRÜN ÖZELLİKLERİ</li>
      <li class="TabbedPanelsTab" tabindex="0">YORUMLAR</li>
      <li class="TabbedPanelsTab" tabindex="0">ÖDEME SEÇENEKLERİ</li>
    </ul>
    <div class="TabbedPanelsContentGroup">
      <div class="TabbedPanelsContent">
      <div class="teknikozellik">
     
      <table cellspacing="0" align="Center" border="0">
      <tr><p id="teknik">Teknik Özellikler</p></tr>
      <tr><td id="ilk">Yapı</td><td><%=yapi%></td></tr></table>

      </div>
      
      <div class="islemciozellik">
     
      <table cellspacing="0" align="Center" border="0">
      <tr><p id="teknik">İşlemci Özellikleri</p></tr>
      <tr><td id="ilk">İşlemci Soket Tipi</td><td><%=islemcisokettipi%></td></tr></table>

      </div>
      
      <div class="ramozellik">
     
      <table cellspacing="0" align="Center" border="0">
      <tr><p id="teknik">RAM Özellikleri</p></tr>
      <tr><td id="ilk">RAM Tipi</td><td><%=ramtipi%></td></tr></table>
      </div>
      
      <div class="anakartozellik">
     
      <table cellspacing="0" align="Center" border="0">
      <tr><p id="teknik">Anakart</p></tr>
      <tr><td id="ilk">MB Chipseti</td><td><%=mbchipseti%></td></tr>
      <tr><td id="ilk">MB Ram Slot sayısı</td><td><%=mbramslotsayisi%></td></tr>
      </table>
      </div>
      
      <div class="islemciozellik">
     
      <table cellspacing="0" align="Center" border="0">
      <tr><p id="teknik">Onboard</p></tr>
      <tr><td id="ilk">SPDIF Çıkışı (optik)</td><td><%=spdifcikisi%></td></tr>
      <tr><td id="ilk">PS/2 (Klavye/fare yuvası)</td><td><%=ps2%></td></tr>
      <tr><td id="ilk">8 Kanal (7.1) Ses Çıkışı</td><td><%=sekizkanal%></td></tr>
      <tr><td id="ilk">Ethernet (10/100/1000)</td><td><%=ethernet%></td></tr>
      <tr><td id="ilk">Kablosuz Wi-Fi</td><td><%=kablosuzwifi%></td></tr>
      <tr><td id="ilk">USB 2.0</td><td><%=usb2%></td></tr>
      <tr><td id="ilk">USB 3.0</td><td><%=usb3%></td></tr>
      <tr><td id="ilk">Clear CMOS button</td><td><%=clearcmosbuton%></td></tr>
      <tr><td id="ilk">SupremeFX</td><td><%=supremefx%></td></tr>
      <tr><td id="ilk">Bluetooth</td><td><%=bluetooth%></td></tr>
      <tr><td id="ilk">Ses</td><td><%=ses%></td></tr>
      </table>
      </div>

           <div class="islemciozellik">
     
      <table cellspacing="0" align="Center" border="0">
      <tr><p id="teknik">VGA Slot</p></tr>
      <tr><td id="ilk">PCI Express</td><td><%=pciexpress%></td></tr>
      </table>
      </div>
      
          <div class="islemciozellik">
     
      <table cellspacing="0" align="Center" border="0">
      <tr><p id="teknik">HDD I/O</p></tr>
      <tr><td id="ilk">SATA III</td><td><%=sata3%></td></tr>
      <tr><td id="ilk">SATA Express</td><td><%=sataexpress%></td></tr>
      <tr><td id="ilk">m.2 Sata</td><td><%=m2sata%></td></tr>
      </table>
      </div>

        <div class="islemciozellik">
     
      <table cellspacing="0" align="Center" border="0">
      <tr><p id="teknik">İşlemci Serisi</p></tr>
      <tr><td id="ilk">Core i7</td><td><%=corei7%></td></tr>
      </table>
      </div>

        
        <div class="islemciozellik">
     
      <table cellspacing="0" align="Center" border="0">
      <tr><p id="teknik">Genel Özellikler</p></tr>
      <tr><td id="ilk">Menşei</td><td><%=mensei%></td></tr>
      <tr><td id="ilk">Garanti</td><td><%=garanti%></td></tr>
      </table>
      </div>
      </div>
      <div class="TabbedPanelsContent"></div>
      <div class="TabbedPanelsContent"></div>
    </div>
  </div>


<script type="text/javascript">
var TabbedPanels1 = new Spry.Widget.TabbedPanels("TabbedPanels1");
</script>

</asp:Content>
