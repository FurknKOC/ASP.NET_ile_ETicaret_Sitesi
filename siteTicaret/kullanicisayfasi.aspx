<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="kullanicisayfasi.aspx.cs" Inherits="siteTicaret.kullanicisayfasi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Button ID="btncikis" runat="server" Text="ÇIKIŞ YAP" CssClass="kullanicicikis" OnClick="btncikis_Click" />
      

        <div id="TabbedPanels1" class="TabbedPanels">
            <ul class="TabbedPanelsTabGroup">
                <li class="TabbedPanelsTab" tabindex="0">SİPARİŞLERİM</li>
                <li class="TabbedPanelsTab" tabindex="0">ÜYELİK BİLGİLERİM</li>
                <li class="TabbedPanelsTab" tabindex="0">ADRESLERİM</li>
            </ul>
            <div class="TabbedPanelsContentGroup">
                <div class="TabbedPanelsContent">
                    <div id="kullanicihesap2">
                        <h4>SİPARİŞLERİM</h4>
                          
                        <script type="text/javascript">

        <%var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();%>
               
                            var Resimler = <%= serializer.Serialize(resimler) %>;
                            var UrunlerinAdlari = <%= serializer.Serialize(urunlerinadlari) %>;
                            var UrunlerinIdleri = <%= serializer.Serialize(idler) %>;
                            var UrunlerinFiyatlari = <%= serializer.Serialize(fiyatlar) %>;  
                            var TurID= <%=serializer.Serialize(TurID)%>;
                            
                            for (var y = 0; y < <%=sayac%>; y++) {
                                if (TurID[y]=="Anakart") {
                                document.write("<a href=\"urunsayfasi.aspx?secim="+UrunlerinIdleri[y]+"\"><ul class=\"siparis\"> ");
                                document.write("<li class=\"deneme\"><img src="+Resimler[y]+" width=\"100\" height=\"100\">");
                                document.write("<h2>"+UrunlerinFiyatlari[y]+"</h2>");
                                document.write("<p>"+UrunlerinAdlari[y]+"</p>");
                                document.write("</li>"); 
                                document.write("</ul></a>");
                                }
                                if (TurID[y]=="Islemci") {
                                    document.write("<a href=\"urunsayfasi_islemci.aspx?secim="+UrunlerinIdleri[y]+"\"><ul class=\"siparis\"> ");
                                    document.write("<li class=\"deneme\"><img src="+Resimler[y]+" width=\"100\" height=\"100\">");
                                    document.write("<h2>"+UrunlerinFiyatlari[y]+"</h2>");
                                    document.write("<p>"+UrunlerinAdlari[y]+"</p>");
                                    document.write("</li>"); 
                                    document.write("</ul></a>");
                                }
                                if (TurID[y]=="EkranKartı") {
                                    document.write("<a href=\"urunsayfasi_ekrankartlari.aspx?secim="+UrunlerinIdleri[y]+"\"><ul class=\"siparis\"> ");
                                    document.write("<li class=\"deneme\"><img src="+Resimler[y]+" width=\"100\" height=\"100\">");
                                    document.write("<h2>"+UrunlerinFiyatlari[y]+"</h2>");
                                    document.write("<p>"+UrunlerinAdlari[y]+"</p>");
                                    document.write("</li>"); 
                                    document.write("</ul></a>");
                                }
                            }
                       
                        </script>

                        


                    </div>
                </div>

                <div class="TabbedPanelsContent">

                    <div id="kullanicihesap2">
                        <h4>ÜYELİK BİLGİLERİM</h4>

                        <table class="khesapbilgi">
                            <tr>
                                <td class="input">
                                    <asp:TextBox ID="txtAd" runat="server"></asp:TextBox></td>
                                <td class="input">
                                    <asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="input">
                                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                                </td>
                                <td class="input">
                                    <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox></td>

                            </tr>

                            <tr>
                                <td class="input">
                                    <asp:TextBox ID="txtSifre" runat="server"></asp:TextBox></td>
                                <td class="input">
                                    <asp:TextBox ID="txtSifreTekrar" runat="server"></asp:TextBox></td>
                            </tr>

                            <tr>
                                <td>
                                    <select class="klist" id="listGun" runat="server">
                                        <option>1</option>
                                        <option>2</option>
                                        <option>3</option>
                                        <option>4</option>
                                        <option>5</option>
                                        <option>6</option>
                                        <option>7</option>
                                        <option>8</option>
                                        <option>9</option>
                                        <option>10</option>
                                        <option>11</option>
                                        <option>12</option>
                                        <option>13</option>
                                        <option>14</option>
                                        <option>15</option>
                                        <option>16</option>
                                        <option>17</option>
                                        <option>18</option>
                                        <option>19</option>
                                        <option>20</option>
                                        <option>21</option>
                                        <option>22</option>
                                        <option>23</option>
                                        <option>25</option>
                                        <option>26</option>
                                        <option>27</option>
                                        <option>28</option>
                                        <option>29</option>
                                        <option>30</option>
                                        <option>31</option>
                                    </select>
                                    <select class="klist" id="listAy" runat="server">
                                        <option>Ocak</option>
                                        <option>Şubat</option>
                                        <option>Mart</option>
                                        <option>Nisan</option>
                                        <option>Mayıs</option>
                                        <option>Haziran</option>
                                        <option>Temmuz</option>
                                        <option>Ağustos</option>
                                        <option>Eylül</option>
                                        <option>Ekim</option>
                                        <option>Kasım</option>
                                        <option>Aralık</option>
                                    </select>
                                    <select class="klist" id="listYil" runat="server">
                                        <option>1997</option>
                                        <option>1998</option>
                                        <option>1999</option>
                                    </select>
                                </td>
                                <td>
                                    <select class="klist2" id="listCinsiyet" runat="server">
                                        <option>Kadın</option>
                                        <option>Erkek</option>
                                    </select></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnKisiGuncelle" runat="server" CssClass="kbuton" Text="GÜNCELLE" OnClick="btnKisiGuncelle_Click" /></td>
                                <td></td>
                            </tr>

                        </table>
                    </div>

                </div>
                <div class="TabbedPanelsContent">
                    <div id="kullanicihesap2">
                        <h4>ADRESLERİM</h4>

                        <p class="bilgilisteyazi">Teslimat Adresi</p>

                        <div class="modal-body">
                            <h2>TESLİMAT ADRESİ GÜNCELLE</h2>
                            <table class="adreslerim">
                                <tr>
                                    <td class="input">
                                        <asp:TextBox ID="txtAdresAd" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="input">
                                        <asp:TextBox ID="txtAdresSoyad" runat="server"></asp:TextBox></td>
                                    <td class="input">
                                        <asp:TextBox ID="txtAdresTel" runat="server"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td class="input">
                                        <asp:TextBox ID="txtAdresSehir" runat="server"></asp:TextBox></td>
                                    <td class="input">
                                        <asp:TextBox ID="txtAdresIlce" runat="server"></asp:TextBox></td>
                                    <td class="input">
                                        <asp:TextBox ID="txtAdres" runat="server"></asp:TextBox></td>
                                </tr>

                            </table>
                            <table class="khesapbilgi">
                                <tr>
                                    <td>
                                        <asp:Button ID="myBtn" runat="server" Text="TESLİMAT ADRESİ GÜNCELLE" CssClass="kbuton" OnClick="myBtn_Click" /></td>
                                </tr>
                            </table>

                        </div>

                    </div>
                </div>
                <script type="text/javascript">
                    var TabbedPanels1 = new Spry.Widget.TabbedPanels("TabbedPanels1");
                </script>
    
</asp:Content>
