<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminurunekle.aspx.cs" Inherits="siteTicaret.urunekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h4>ANAKART EKLE</h4>
   <table class="paneliceriktablo">
      <tr class="textoge">
      <td>Anakart Adı</td>
      <td><asp:TextBox ID="txtanakartadi" runat="server"></asp:TextBox></td>
      </tr>
      
      <tr class="selectoge">
      <td>Marka</td>
      <td>
     	<asp:DropDownList ID="drpmarka" runat="server">
            <asp:ListItem>Gigabyte</asp:ListItem>
             <asp:ListItem>MSI</asp:ListItem>
             <asp:ListItem>Asus</asp:ListItem>
        </asp:DropDownList>
    </td>
      </tr>
      
      <tr class="textoge">
      <td>Fiyat</td>
      <td><asp:TextBox ID="txtfiyat" runat="server"></asp:TextBox></td>
      </tr>

       <tr class="textoge">
      <td>Stok</td>
      <td><asp:TextBox ID="txtstok" runat="server"></asp:TextBox></td>
      </tr>
      
      <tr class="selectoge">
      <td>Uyumluluk</td>
      <td><asp:DropDownList ID="drpuyumluluk" runat="server">
            <asp:ListItem>Intel</asp:ListItem>
            <asp:ListItem>Amd</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="selectoge">
      <td>Yapı</td>
      <td><asp:DropDownList ID="drpyapi" runat="server">
            <asp:ListItem>ATX</asp:ListItem>
          <asp:ListItem>Micro ATX</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="selectoge">
      <td>İşlemci Soket Tipi</td>
      <td><asp:DropDownList ID="drpislemcisokettipi" runat="server">
            <asp:ListItem>Soket AM4</asp:ListItem>
          <asp:ListItem>Soket 1151</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="selectoge">
      <td>RAM Tipi</td>
      <td><asp:DropDownList ID="drpramtipi" runat="server">
            <asp:ListItem>DDR4</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="selectoge">
      <td>MB Chip Seti</td>
      <td> <asp:DropDownList ID="drpmbchipseti" runat="server">
            <asp:ListItem>AMD® X370</asp:ListItem>
          <asp:ListItem>AMD® B350</asp:ListItem>
          <asp:ListItem>Intel® B250</asp:ListItem>
          <asp:ListItem>Intel® Z270</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="selectoge">
      <td>MB RAM Slot Sayısı</td>
      <td><asp:DropDownList ID="drpmbramslotsayisi" runat="server">
            <asp:ListItem>4</asp:ListItem>
          <asp:ListItem>2</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="checkoge">
      <td>SPDIF Çıkışı(Optik)</td>
      <td><asp:CheckBox ID="chcspdif" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>PS/2(Klavye ve Fare Yuvası)</td>
      <td><asp:CheckBox ID="chcps2" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>8 Kanal 7.1 Ses Çıkışı</td>
      <td><asp:CheckBox ID="chcsekizkanal" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>Ethernet</td>
      <td><asp:CheckBox ID="chcethernet" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>Kablosuz Wi-fi</td>
      <td><asp:CheckBox ID="chcwifi" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>USB 2.0</td>
      <td><asp:CheckBox ID="chcusb2" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>USB 3.0</td>
      <td><asp:CheckBox ID="chcusb3" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>Clear CMOS Buton</td>
      <td><asp:CheckBox ID="chcclearcmosbuton" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>SupremeFX</td>
      <td><asp:CheckBox ID="chcsupremefx" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>Bluetooth</td>
      <td><asp:CheckBox ID="chcbluetooth" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>Ses</td>
      <td><asp:CheckBox ID="chcses" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>PCI Express</td>
      <td><asp:CheckBox ID="chcpciexpress" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td> SATA III</td>
      <td><asp:CheckBox ID="chcsata3" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>SATA Express</td>
      <td><asp:CheckBox ID="chcsataexpress" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>m.2 Sata</td>
      <td> <asp:CheckBox ID="chcm2sata" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>Core i7</td>
      <td><asp:CheckBox ID="chccorei7" runat="server" /></td>
      </tr>
      
      <tr class="textoge">
      <td>Menşei</td>
      <td><asp:TextBox ID="txtmensei" runat="server"></asp:TextBox></td>
      </tr>
      
      <tr class="textoge">
      <td>Garanti</td>
      <td><asp:TextBox ID="txtgaranti" runat="server"></asp:TextBox></td>
      </tr>
      
      <tr>
      <td>Ürün Fotoğrafı-1</td>
      <td><asp:FileUpload ID="fileresim1" runat="server" /></td>
      </tr>
      
      <tr>
      <td>Ürün Fotoğrafı-2</td>
      <td><asp:FileUpload ID="fileresim2" runat="server" /></td>
      </tr>
      
      <tr>
      <td>Ürün Fotoğrafı-3</td>
      <td><asp:FileUpload ID="fileresim3" runat="server" /></td>
      </tr>
      
      <tr>
      <td>Ürün Fotoğrafı-4</td>
      <td><asp:FileUpload ID="fileresim4" runat="server" /></td>
      </tr>
      
      <tr>
      <td></td>
      <td><asp:Button ID="Button2" runat="server" CssClass="kayitbuton" OnClick="Button2_Click" Text="ANAKART EKLE" /></td>
      </tr>

       <tr>
      <td></td>
      <td>
          <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
      </tr>
      
      </table>
        
</asp:Content>
