<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminekrankartiekle.aspx.cs" Inherits="siteTicaret.adminekrankartiekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h4>EKRAN KARTI EKLE</h4>
   <table class="paneliceriktablo">
      <tr class="textoge">
      <td>Ekran Kartı Adı</td>
      <td><asp:TextBox ID="txtekrankartiadi" runat="server"></asp:TextBox></td>
      </tr>
      
      <tr class="selectoge">
      <td>Marka</td>
      <td>
     	<asp:DropDownList ID="drpmarka" runat="server">
            <asp:ListItem>ASUS</asp:ListItem>
             <asp:ListItem>MSI</asp:ListItem>
             <asp:ListItem>EVGA</asp:ListItem>
             <asp:ListItem>SAPPHIRE</asp:ListItem>
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
      <td>Çekirdek Hızı</td>
      <td><asp:DropDownList ID="drpcekirdekhizi" runat="server">
            <asp:ListItem>1480 MHz</asp:ListItem>
            <asp:ListItem>1380 MHz</asp:ListItem>
          <asp:ListItem>1266 MHz</asp:ListItem>
            <asp:ListItem>1260 MHz</asp:ListItem>
          <asp:ListItem>1206 MHz</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="selectoge">
      <td>Ram Kapasitesi</td>
      <td><asp:DropDownList ID="drpramkapasitesi" runat="server">
            <asp:ListItem>1 GB</asp:ListItem>
          <asp:ListItem>2 GB</asp:ListItem>
          <asp:ListItem>3 GB</asp:ListItem>
          <asp:ListItem>4 GB</asp:ListItem>
          <asp:ListItem>6 GB</asp:ListItem>
          <asp:ListItem>8 GB</asp:ListItem>
          <asp:ListItem>11 GB</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="selectoge">
      <td>Bellek Hızı</td>
      <td><asp:DropDownList ID="drpbellekhizi" runat="server">
            <asp:ListItem>11016 Mhz</asp:ListItem>
          <asp:ListItem>8000 Mhz</asp:ListItem>
          <asp:ListItem>7000 Mhz</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="selectoge">
      <td>Grafik Chipseti Markası</td>
      <td><asp:DropDownList ID="drpgrafikchipsetimarkasi" runat="server">
            <asp:ListItem>NVIDIA</asp:ListItem>
          <asp:ListItem>AMD</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="selectoge">
      <td>Ekran Kartı Chipseti</td>
      <td> <asp:DropDownList ID="drpekrankartichipseti" runat="server">
            <asp:ListItem>GTX 1080 Ti</asp:ListItem>
          <asp:ListItem>GTX 1050</asp:ListItem>
          <asp:ListItem>RX 580</asp:ListItem>
          <asp:ListItem>RX 550</asp:ListItem>
          <asp:ListItem>RX 480</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="selectoge">
      <td>Bellek Tipi</td>
      <td><asp:DropDownList ID="drpbellektipi" runat="server">
            <asp:ListItem>GDDR5X</asp:ListItem>
          <asp:ListItem>GDDR5</asp:ListItem>
        </asp:DropDownList></td>
      </tr>

       <tr class="selectoge">
      <td>Bellek Arayüzü</td>
      <td><asp:DropDownList ID="drpbellekarayuzu" runat="server">
            <asp:ListItem>352 Bit</asp:ListItem>
          <asp:ListItem>256 Bit</asp:ListItem>
          <asp:ListItem>128 Bit</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="checkoge">
      <td>PCI Express 3.0</td>
      <td><asp:CheckBox ID="chcpciexpress3" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>DisplayPort</td>
      <td><asp:CheckBox ID="chcdisplayport" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>HDCP Desteği</td>
      <td><asp:CheckBox ID="chchdcpdestegi" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>DVI</td>
      <td><asp:CheckBox ID="chcdvi" runat="server" /></td>
      </tr>
      
      <tr class="checkoge">
      <td>HDMI</td>
      <td><asp:CheckBox ID="chchdmi" runat="server" /></td>
      </tr>
      
       <tr class="selectoge">
      <td>Güç Tüketimi</td>
      <td><asp:DropDownList ID="drpguctuketimi" runat="server">
            <asp:ListItem>250 W</asp:ListItem>
          <asp:ListItem>235 W</asp:ListItem>
          <asp:ListItem>150 W</asp:ListItem>
          <asp:ListItem>65 W</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="textoge">
      <td>Menşei</td>
      <td><asp:TextBox ID="txtmensei" runat="server"></asp:TextBox></td>
      </tr>
      
      <tr class="textoge">
      <td>Garanti</td>
      <td><asp:TextBox ID="txtgaranti" runat="server"></asp:TextBox></td>
      </tr>
      
       <tr class="selectoge">
      <td>Çözünürlük</td>
      <td><asp:DropDownList ID="drpcozunurluk" runat="server">
            <asp:ListItem>7680 x 4320</asp:ListItem>
          <asp:ListItem>3840 x 2160</asp:ListItem>
        </asp:DropDownList></td>
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
      <td></td>
      <td><asp:Button ID="Button2" runat="server" CssClass="kayitbuton" OnClick="Button2_Click" Text="EKRAN KARTI EKLE" /></td>
      </tr>

       <tr>
      <td></td>
      <td>
          <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
      </tr>
      
      </table>
</asp:Content>
