<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="urunsayfasi_ekrankartlari.aspx.cs" Inherits="siteTicaret.urunsayfasi_ekrankartlari" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <script language="javascript" type="application/javascript">
       
            isim=new Array();
            isim[0] = "<%=resim%>";
isim[1] = "<%=resim2%>";
            isim[2] = "<%=resim3%>";
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
            <img id="resim" src="<%=resim%>" width="400px" height="400px" />
            <div class="resimler">
                <ul>
                    <li><a href="<%=resim%>" data-lightbox="<%=resim%>" onmouseover="deneme('<%=resim%>')">
                        <img src="<%=resim%>" width="70" height="72" /></a></li>
                    <li><a href="<%=resim2%>" data-lightbox="<%=resim2%>" onmouseover="deneme('<%=resim2%>')">
                        <img src="<%=resim2%>" width="70" height="72" /></a></li>
                    <li><a href="<%=resim3%>" data-lightbox="<%=resim3%>" onmouseover="deneme('<%=resim3%>')">
                        <img src="<%=resim3%>" width="70" height="72" /></a></li>
                </ul>


            </div>
            <div class="sekil">
                <img src="images/ayni.png" height="30" /><img src="images/kargo.png" height="30" />
            </div>

        </div>

        <div class="urunsayfasi2">
            <div class="ortala">
                <h1><%=ekrankartiadi%></h1>
                <p id="p2"><%=fiyat%>₺</p>
                <select class="sayi" id="listUrunAdet" runat="server">
                    <option>1</option>
                    <option>2</option>
                </select>
                <asp:Button ID="btnSepeteEkle" runat="server" Text="SEPETE EKLE" CssClass="buton" OnClick="btnSepeteEkle_Click" />
            </div>

            <p id="p3">Stok <b><%=stok%></b></p>
            <p id="p3">Çekirdek Hızı<b> <%=cekirdekhizi%></b></p>
            <p id="p3">Ram Kapasitesi<b><%=ramkapasitesi%></b></p>
            <p id="p3">Bellek Hızı<b><%=bellekhizi%></b></p>
            <p id="p3">Grafik Chipseti Markası<b><%=grafikchipsetimarkasi%></b></p>
            <a href="#ozellik">Daha Çok Özellik</a>

        </div>

        <div class="altkisim">
            <div id="TabbedPanels1" class="TabbedPanels">
                <ul class="TabbedPanelsTabGroup">
                    <li class="TabbedPanelsTab" tabindex="0"><a name="ozellik">ÜRÜN ÖZELLİKLERİ</a></li>
                    <li class="TabbedPanelsTab" tabindex="0">YORUMLAR</li>
                    <li class="TabbedPanelsTab" tabindex="0">ÖDEME SEÇENEKLERİ</li>
                </ul>
                <div class="TabbedPanelsContentGroup">
                    <div class="TabbedPanelsContent">
                        <div class="teknikozellik">

                            <table cellspacing="0" align="Center" border="0">
                                <tr>
                                    <p id="teknik">Teknik Özellikler</p>
                                </tr>
                                <tr>
                                    <td id="ilk">Çekirdek Hızı</td>
                                    <td><%=cekirdekhizi%></td>
                                </tr>
                            </table>

                        </div>

                        <div class="islemciozellik">

                            <table cellspacing="0" align="Center" border="0">
                                <tr>
                                    <p id="teknik">Ram Özellikleri</p>
                                </tr>
                                <tr>
                                    <td id="ilk">Ram Kapasitesi</td>
                                    <td><%=ramkapasitesi%></td>
                                </tr>
                                <tr>
                                    <td id="ilk">Bellek Hızı</td>
                                    <td><%=bellekhizi%></td>
                                </tr>
                            </table>

                        </div>

                        <div class="ramozellik">

                            <table cellspacing="0" align="Center" border="0">
                                <tr>
                                    <p id="teknik">Grafik Kart</p>
                                </tr>
                                <tr>
                                    <td id="ilk">Grafik Chipseti Markası</td>
                                    <td><%=grafikchipsetimarkasi%></td>
                                </tr>
                                <tr>
                                    <td id="ilk">Ekran Kartı Chipseti</td>
                                    <td><%=ekrankartichipseti%></td>
                                </tr>
                            </table>
                        </div>

                        <div class="anakartozellik">

                            <table cellspacing="0" align="Center" border="0">
                                <tr>
                                    <p id="teknik">Bellek</p>
                                </tr>
                                <tr>
                                    <td id="ilk">Bellek Tipi</td>
                                    <td><%=bellektipi%></td>
                                </tr>
                                <tr>
                                    <td id="ilk">Bellek Arayüzü</td>
                                    <td><%=bellekarayuzu%></td>
                                </tr>
                            </table>
                        </div>

                        <div class="islemciozellik">

                            <table cellspacing="0" align="Center" border="0">
                                <tr>
                                    <p id="teknik">VGA Slot</p>
                                </tr>
                                <tr>
                                    <td id="ilk">PCI Express 3.0</td>
                                    <td><%=pciexpress3%></td>
                                </tr>
                            </table>
                        </div>

                        <div class="islemciozellik">

                            <table cellspacing="0" align="Center" border="0">
                                <tr>
                                    <p id="teknik">Bağlantı Özellikleri</p>
                                </tr>
                                <tr>
                                    <td id="ilk">HDMI</td>
                                    <td><%=hdmi%></td>
                                </tr>
                                <tr>
                                    <td id="ilk">DVI</td>
                                    <td><%=dvi%></td>
                                </tr>
                                <tr>
                                    <td id="ilk">HDCP Desteği</td>
                                    <td><%=hdcpdestegi%></td>
                                </tr>
                                <tr>
                                    <td id="ilk">DisplayPort</td>
                                    <td><%=displayport%></td>
                                </tr>
                            </table>
                        </div>

                        <div class="islemciozellik">

                            <table cellspacing="0" align="Center" border="0">
                                <tr>
                                    <p id="teknik">Diğer</p>
                                </tr>
                                <tr>
                                    <td id="ilk">Güç Tüketimi</td>
                                    <td><%=guctuketimi%></td>
                                </tr>
                            </table>
                        </div>

                        <div class="islemciozellik">

                            <table cellspacing="0" align="Center" border="0">
                                <tr>
                                    <p id="teknik">Genel Özellikler</p>
                                </tr>
                                <tr>
                                    <td id="ilk">Menşei</td>
                                    <td><%=mensei%></td>
                                </tr>
                                 <tr>
                                    <td id="ilk">Garanti</td>
                                    <td><%=garanti%></td>
                                </tr>
                            </table>
                        </div>


                        <div class="islemciozellik">

                            <table cellspacing="0" align="Center" border="0">
                                <tr>
                                    <p id="teknik">Ekran Özellikleri</p>
                                </tr>
                                <tr>
                                    <td id="ilk">Çözünürlük</td>
                                    <td><%=cozunurluk%></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <div class="TabbedPanelsContent">
                        <script> 

              <%
                            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();%>
               
                            var AdSoyadlar = <%= serializer.Serialize(adsoyadlar) %>;
                            var YorumBasliklari = <%= serializer.Serialize(yorumbasliklari) %>;
                            var Yorumlar = <%= serializer.Serialize(yorumlar) %>;
                            for (var y = 0; y < <%=yorumsayisi%>; y++) {
                                document.write("<div class=\"yorumsayfasi\">");
                                document.write("<div class=\"yorumsayfasisol\">");
                                document.write("<img src=\"images/yorum_avatar.png\" width=\"40\" height=\"40\" />");
                                document.write("<p>"+AdSoyadlar[y]+"</p>");
                                document.write("</div> ");

                                document.write("<div class=\"yorumsayfasisag\">");
                                document.write("<h2>"+YorumBasliklari[y]+"</h2>");
                                document.write("<p>"+Yorumlar[y]+"</p>"); 
                                document.write("</div> ");
                                document.write("</div> ");
            
                            }
                        </script>
                        <div class="yorumyapma">
                            <table class="yorumyapmatablo">
                                <tr>
                                    <td>
                                        <img src="images/yorum_avatar.png" style="width: 40px; height: 40px;" />

                                    </td>

                                </tr>
                                <tr>
                                    <td class="yorumisim">

                                        <asp:Label ID="lblAdSoyad" runat="server" Text="Misafir"></asp:Label>

                                    </td>

                                </tr>
                                <tr>
                                    <td class="yorum">
                                        <input type="text" placeholder="Yorum Başlığını Giriniz." id="txtYorumBasligi" runat="server" /><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtYorumBasligi" ErrorMessage="Lütfen Yorum Başlığı Giriniz." ForeColor="Red" ValidationGroup="yorumyap"></asp:RequiredFieldValidator>
                                    </td>

                                </tr>
                                <tr>
                                    <td class="yorum">
                                        <input type="text" placeholder="Yorumunuzu Giriniz." id="txtYorum" runat="server" /><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Lütfen Yorum Giriniz." ControlToValidate="txtYorum" ForeColor="Red" ValidationGroup="yorumyap"></asp:RequiredFieldValidator>
                                    </td>

                                </tr>
                                <tr>
                                    <td class="yorumbuton">
                                        <asp:Button ID="Button1" runat="server" Text="YORUM YAP" OnClick="Button1_Click" ValidationGroup="yorumyap"></asp:Button>
                                    </td>

                                </tr>
                            </table>
                        </div>
                    </div>
                    <div class="TabbedPanelsContent">

                        <div id="odemesecenek">
                            <table class="odemesecenektablo">
                                <tr>
                                    <td class="odemeresim">
                                        <img src="images/kargokapi.png" /></td>
                                    <td class="odemebaslik">Kargo Bedava</td>
                                    <td class="odemeyazi"><a href="">TEKNOMAR</a>'dan yapacağınız alışverişlerinizde KARGO BEDAVA</td>
                                </tr>
                                <tr>
                                    <td>
                                        <img src="images/kapidaodeme.png" /></td>
                                    <td class="odemebaslik">Kapıda Nakit Ödeme</td>
                                    <td class="odemeyazi">İnternetten alışveriş <a href="">TEKNOMAR</a> ile çok kolay.</td>
                                </tr>
                                <tr>
                                    <td class="odemeresim2">
                                        <img src="images/geriiade.png" /></td>
                                    <td class="odemebaslik">15 Gün İade</td>
                                    <td class="odemeyazi"><a href="">TEKNOMAR</a>'dan almış olduğunuz ve hiç kullanmadığınız ürünleri 15 gün içerisinde iade edebilir veya değiştirebilirsiniz.</td>
                                </tr>
                            </table>
                        </div>

                    </div>
                </div>
            </div>


            <script type="text/javascript">
                var TabbedPanels1 = new Spry.Widget.TabbedPanels("TabbedPanels1");
            </script>
   
</asp:Content>
