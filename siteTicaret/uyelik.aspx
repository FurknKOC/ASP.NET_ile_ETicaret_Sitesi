<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="uyelik.aspx.cs" Inherits="siteTicaret.uyelik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="uyelik">
        <div class="anayazi2">
            <h1>Üye Girişi</h1>
            <p>GİRİŞ YAP</p>
        </div>

        <table>
            <tr>
                <td><input type="text" placeholder="Email Adresiniz" id="txtEmailGiris" runat="server"/></td>
            </tr>
            <tr>
                <td><input type="password" placeholder="Şifre" id="txtSifreGiris" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Button ID="GirisButon" runat="server" CssClass="buton" Text="GİRİŞ YAP" OnClick="GirisButon_Click"></asp:Button></td>
            </tr>
            <tr><td><asp:Label ID="Label1" runat="server" Text="" CssClass="kontrol"></asp:Label></td></tr>

        </table>
        
        
        
        
       

    </div>

    <div class="yeniuyelik">
        <div class="anayazi2">
            <h1>Yeni Üyelik</h1>
            <p>ÜYE OL</p>
        </div>

        <p id="bilgilendirme">Sizi daha iyi tanıyabilmemiz ve size özel kampanya oluşturabilmemiz için aşağıdaki alanları doldurarak <a class="teknomar"href="default.aspx">TEKNOMAR</a>'a üye olabilirsiniz.</p>
        <table>
            <tr>
                <td><input type="text" placeholder="Adınız" id="txtAd" runat="server" /></td>
            <td><input type="text" placeholder="Soyadınız" id="txtSoyad" runat="server"/></td>
                </tr>
            <tr>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Adınızı Giriniz" ControlToValidate="txtAd" ValidationGroup="uyekayit" CssClass="kontrol"></asp:RequiredFieldValidator>
        </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Soyadınızı Giriniz" ControlToValidate="txtSoyad" ValidationGroup="uyekayit"  CssClass="kontrol"></asp:RequiredFieldValidator></td>
                </tr>
            <tr>
                <td><input type="text" placeholder="Email Adresiniz" id="txtEmailKayit" runat="server"/></td>
                <td><input type="text" placeholder="5XXYYZZZ" id="txtTelefon" runat="server"/></td>
            </tr>
            <tr>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="E-Mailinizi Giriniz" ControlToValidate="txtEmailKayit" ValidationGroup="uyekayit"  CssClass="kontrol"></asp:RequiredFieldValidator>
        </td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Telefon Numaranızı Giriniz" ControlToValidate="txtTelefon" ValidationGroup="uyekayit"  CssClass="kontrol"></asp:RequiredFieldValidator></td>
                
            </tr>
            <tr>
                <td><input type="password" placeholder="Şifre" id="txtSifre" runat="server"/></td>
                <td><input type="password" placeholder="Şifre Tekrar" id="txtSifreTekrar" runat="server" /></td>
            </tr>
            <tr>
                
                <td><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Lütfen Şifreleri Aynı Giriniz" ControlToCompare="txtSifre" ControlToValidate="txtSifreTekrar" ValidationGroup="uyekayit"  CssClass="kontrol"></asp:CompareValidator></td>
           <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Şifrenizi Giriniz" ControlToValidate="txtSifreTekrar" ValidationGroup="uyekayit"  CssClass="kontrol"></asp:RequiredFieldValidator>
        </td>
                 </tr>
            <tr>
                <td><select class="list" id="listGun" runat="server">
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
        <select class="list" id="listAy" runat="server">
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
        <select class="list" id="listYil" runat="server">
            <option>1997</option>
            <option>1998</option>
            <option>1999</option>
        </select></td>
                <td> <select class="list2" id="listCinsiyet" runat="server">
            <option>Kadın</option>
            <option>Erkek</option>
         </select></td>
            </tr>
            <tr>
                <td>
                    </td>
                <td>
                    </td>

            </tr>
            <tr>
                <td><select class="list3" id="listGizliSoru" runat="server">
            <option>İlk okulunuzun adı nedir?</option>
            <option>İlk arabanızın markası nedir?</option>
         </select></td>
                 <td>
        <input type="text" placeholder="Gizli Soru Cevabını Giriniz" id="txtSoruCevap" runat="server" /></td>
            </tr>
            <tr>
                <td></td>
                <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Gizli Sorunun Cevabını Giriniz" ControlToValidate="txtSoruCevap" ValidationGroup="uyekayit"  CssClass="kontrol"></asp:RequiredFieldValidator></td>

            </tr>

            <tr>
                <td> <asp:Button ID="UyeOlButon" runat="server" CssClass="buton" Text="ÜYE OL" OnClick="UyeOlButon_Click" ValidationGroup="uyekayit"></asp:Button></td>
                <td></td>

            </tr>
        </table>

       
    </div>

 


</asp:Content>
