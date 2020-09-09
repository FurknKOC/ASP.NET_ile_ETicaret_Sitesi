<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="urunsayfasi_islemci.aspx.cs" Inherits="siteTicaret.urunsayfasi_islemci" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <script language="javascript" type="application/javascript">
       
            isim=new Array();
            isim[0] = "<%=resim%>";
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
              </div>
            <div class="sekil">
                <img src="images/ayni.png" height="30" /><img src="images/kargo.png" height="30" />
            </div>

        </div>

        <div class="urunsayfasi2">
            <div class="ortala">
                <h1><%=islemciadi%></h1>
                <p id="p2"><%=fiyat%>₺</p>
                <select class="sayi" id="listUrunAdet" runat="server">
                    <option>1</option>
                    <option>2</option>
                </select>
                <asp:button id="btnSepeteEkle" runat="server" text="SEPETE EKLE" cssclass="buton" onclick="btnSepeteEkle_Click" />
            </div>

            <p id="p3">Stok <b><%=stok%></b></p>
            <p id="p3">İşlemci Soket Tipi<b> <%=islemcisokettipi%></b></p>
            <p id="p3">İşlemci Numarası<b><%=islemcinumarasi%></b></p>
            <p id="p3">İşlemci Teknolojisi<b><%=islemciteknolojisi%></b></p>
            <p id="p3">İşlemci Ön Bellek<b><%=islemcionbellek%></b></p>
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
                                    <p id="teknik">İşlemci Özellikleri</p>
                                </tr>
                                <tr>
                                    <td id="ilk">İşlemci Numarası</td>
                                    <td><%=islemcinumarasi%></td>
                                </tr>
                                <tr>
                                    <td id="ilk">İşlemci Soket Tipi</td>
                                    <td><%=islemcisokettipi%></td>
                                </tr>
                                <tr>
                                    <td id="ilk">İşlemci Teknolojisi</td>
                                    <td><%=islemciteknolojisi%></td>
                                </tr>
                                <tr>
                                    <td id="ilk">İşlemci Hızı</td>
                                    <td><%=islemcihizi%></td>
                                </tr>
                                <tr>
                                    <td id="ilk">İşlemci Ön Bellek</td>
                                    <td><%=islemcionbellek%></td>
                                </tr>
                                <tr>
                                    <td id="ilk">İşlemci Markası</td>
                                    <td><%=marka%></td>
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
                                <tr>
                                    <td id="ilk">Kutulu/Kutusuz</td>
                                    <td><%=kutulukutusuz%></td>
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

                                        <asp:label id="lblAdSoyad" runat="server" text="Misafir"></asp:label>

                                    </td>

                                </tr>
                                <tr>
                                    <td class="yorum">
                                        <input type="text" placeholder="Yorum Başlığını Giriniz." id="txtYorumBasligi" runat="server" /><asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" controltovalidate="txtYorumBasligi" errormessage="Lütfen Yorum Başlığı Giriniz." forecolor="Red" validationgroup="yorumyap"></asp:requiredfieldvalidator>
                                    </td>

                                </tr>
                                <tr>
                                    <td class="yorum">
                                        <input type="text" placeholder="Yorumunuzu Giriniz." id="txtYorum" runat="server" /><asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" errormessage="Lütfen Yorum Giriniz." controltovalidate="txtYorum" forecolor="Red" validationgroup="yorumyap"></asp:requiredfieldvalidator>
                                    </td>

                                </tr>
                                <tr>
                                    <td class="yorumbuton">
                                        <asp:button id="Button1" runat="server" text="YORUM YAP" onclick="Button1_Click" validationgroup="yorumyap"></asp:button>
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
