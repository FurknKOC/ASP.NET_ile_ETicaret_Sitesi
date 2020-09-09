<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admingiris.aspx.cs" Inherits="siteTicaret.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/main.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        
        
        
    </div>
        <div id="adminpaneli">
        <div id="adminpaneli2">

        <div class="adminicerik">

              <table class="admintablo">
              <tr>
              <td><div id="logo2">
                <a href="default.aspx">
                    <img src="images/LOGOo.fw.png"/>
                </a>
            </div></td>
              </tr>
              <tr class="textoge2">
              <td><asp:TextBox ID="kullanici_adi" runat="server" placeholder="Kullanıcı Adı"></asp:TextBox></td>
              </tr>
              <tr class="textoge2">
              <td><asp:TextBox ID="sifre" runat="server" TextMode="Password" placeholder="Şifre"></asp:TextBox></td>
              </tr>
               <tr>
              <td><asp:Button ID="Button1" runat="server" Text="GİRİŞ" CssClass="gbuton" OnClick="Button1_Click" /></td>
              </tr>
                  <tr>
                      <td><asp:Label ID="Label1" runat="server" Text="" CssClass="yazi"></asp:Label></td>

                  </tr>
  
          </table>
        </div>
        </div>
        </div>
    </form>
</body>
</html>
