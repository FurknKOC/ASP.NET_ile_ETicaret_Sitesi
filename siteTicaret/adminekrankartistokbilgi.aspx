<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminekrankartistokbilgi.aspx.cs" Inherits="siteTicaret.adminekrankartistokbilgi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <script type="text/javascript">
      
        <%

    var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
%>
               
        var Resimler = <%= serializer.Serialize(resimler) %>;
        var Adlar = <%= serializer.Serialize(adlar) %>;
        var Stoklar = <%= serializer.Serialize(stoklar) %>; 
        document.write("<table cellspacing=\"0\" border=\"0\" class=\"adminstok\">");
        for (var y = 0; y < <%=sayi%>; y++) {
            document.write("<tr> ");
            document.write("<td class=\"urunres\"><img src=\"" +Resimler[y] +"  \" width=\"100\" height=\"100\"></td>");
            document.write("<td class=\"urunisim\">"+Adlar[y]+"</td>");
            document.write("<td class=\"urunadet\">"+Stoklar[y]+ "</td>"); 
            document.write("</tr>");
        }
        document.write("</table>");
    </script>
</asp:Content>
