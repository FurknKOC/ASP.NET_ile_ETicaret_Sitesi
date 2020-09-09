<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminislemciekle.aspx.cs" Inherits="siteTicaret.adminislemciekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h4>İŞLEMCİ EKLE</h4>
   <table class="paneliceriktablo">
      <tr class="textoge">
      <td>İşlemci Adı</td>
      <td><asp:TextBox ID="txtislemciadi" runat="server"></asp:TextBox></td>
      </tr>
      
      <tr class="selectoge">
      <td>Marka</td>
      <td>
     	<asp:DropDownList ID="drpmarka" runat="server">
            <asp:ListItem>Intel</asp:ListItem>
             <asp:ListItem>AMD</asp:ListItem>
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
      <td>İşlemci Soket Tipi</td>
      <td><asp:DropDownList ID="drpislemcisokettipi" runat="server">
            <asp:ListItem>Soket 1150</asp:ListItem>
            <asp:ListItem>Soket 1151</asp:ListItem>
          <asp:ListItem>Soket 2011-V3</asp:ListItem>
          <asp:ListItem>Soket AM3+</asp:ListItem>
          <asp:ListItem>Soket AM4</asp:ListItem>
          <asp:ListItem>Soket FM2</asp:ListItem>
          <asp:ListItem>Soket FM2+</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="selectoge">
      <td>İşlemci Numarası</td>
      <td><asp:DropDownList ID="drpislemcinumarasi" runat="server">
            <asp:ListItem>7700K</asp:ListItem>
          <asp:ListItem>7400</asp:ListItem>
          <asp:ListItem>7100</asp:ListItem>
          <asp:ListItem>1700X</asp:ListItem>
          <asp:ListItem>6600K</asp:ListItem>
          <asp:ListItem>G4560</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="selectoge">
      <td>İşlemci Teknolojisi</td>
      <td><asp:DropDownList ID="drpislemciteknolojisi" runat="server">
            <asp:ListItem>Xeon</asp:ListItem>
          <asp:ListItem>Intel Core i7</asp:ListItem>
          <asp:ListItem>Intel Core i5</asp:ListItem>
          <asp:ListItem>Intel Core i3</asp:ListItem>
          <asp:ListItem>Intel Pentium</asp:ListItem>
          <asp:ListItem>AMD A10 Serisi</asp:ListItem>
          <asp:ListItem>AMD A8 Serisi</asp:ListItem>
          <asp:ListItem>AMD A6 Serisi</asp:ListItem>
          <asp:ListItem>AMD Athlon</asp:ListItem>
          <asp:ListItem>AMD FX</asp:ListItem>
          <asp:ListItem>AMD Ryzen 5</asp:ListItem>
          <asp:ListItem>AMD Ryzen 7</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="selectoge">
      <td>İşlemci Hızı</td>
      <td><asp:DropDownList ID="drpislemcihizi" runat="server">
            <asp:ListItem>1.9 GHz</asp:ListItem>
          <asp:ListItem>3.0 GHz</asp:ListItem>
          <asp:ListItem>3.1 GHz</asp:ListItem>
          <asp:ListItem>3.2 GHz</asp:ListItem>
          <asp:ListItem>3.3 GHz</asp:ListItem>
          <asp:ListItem>3.4 GHz</asp:ListItem>
          <asp:ListItem>3.5 GHz</asp:ListItem>
          <asp:ListItem>3.6 GHz</asp:ListItem>
          <asp:ListItem>3.7 GHz</asp:ListItem>
          <asp:ListItem>3.8 GHz</asp:ListItem>
          <asp:ListItem>3.9 GHz</asp:ListItem>
          <asp:ListItem>4.0 GHz</asp:ListItem>
          <asp:ListItem>4.2 GHz</asp:ListItem>
          <asp:ListItem>4.3 GHz</asp:ListItem>
          <asp:ListItem>4.7 GHz</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="selectoge">
      <td>İşlemci Önbellek</td>
      <td> <asp:DropDownList ID="drpislemcionbellek" runat="server">
          <asp:ListItem>20 MB</asp:ListItem>
          <asp:ListItem>16 MB</asp:ListItem>
            <asp:ListItem>8 MB</asp:ListItem>
          <asp:ListItem>6 MB</asp:ListItem>
          <asp:ListItem>4 MB</asp:ListItem>
          <asp:ListItem>3 MB</asp:ListItem>
        </asp:DropDownList></td>
      </tr>
      
      <tr class="checkoge">
      <td>Kutulu/Kutusuz</td>
      <td><asp:CheckBox ID="chckutulukutusuz" runat="server" /></td>
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
      <td></td>
      <td><asp:Button ID="Button2" runat="server" CssClass="kayitbuton" OnClick="Button2_Click" Text="İŞLEMCİ EKLE" /></td>
      </tr>

       <tr>
      <td></td>
      <td>
          <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
      </tr>
      
      </table>
</asp:Content>
