<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminislemciguncelle.aspx.cs" Inherits="siteTicaret.adminislemciguncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
         <div>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" DataKeyNames="IslemciUrunID" HeaderStyle-CssClass="urunbaslik" AlternatingRowStyle-CssClass="urundetay"><Columns>
            
            <asp:CommandField ShowEditButton="true" EditText="Düzenle" CancelText="İptal" UpdateText="Güncelle" />
<asp:ButtonField CommandName="Delete" Text="Sil" ItemStyle-ForeColor="red"  >
<ItemStyle ForeColor="Red"></ItemStyle>
</asp:ButtonField></Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"
ConnectionString="Data Source=.; Initial Catalog=eTicaret; Integrated Security=true;"
SelectCommand="SELECT * FROM IslemciUrunler"
UpdateCommand="UPDATE [IslemciUrunler] SET [IslemciAdi] = @IslemciAdi , [Marka] =  @Marka , [Fiyat] = @Fiyat , [Stok]=@Stok , [IslemciSoketTipi]=@IslemciSoketTipi , [IslemciNumarasi]=@IslemciNumarasi , [IslemciTeknolojisi]=@IslemciTeknolojisi , [IslemciHizi]=@IslemciHizi , [IslemciOnBellek]=@IslemciOnBellek , [Mensei]=@Mensei , [Garanti]=@Garanti , [KutuluKutusuz]=@KutuluKutusuz , [resim1]=@resim1 WHERE [IslemciUrunID]=@IslemciUrunID" DeleteCommand="Delete [IslemciUrunler] Where [IslemciUrunID]=@IslemciUrunID">
</asp:SqlDataSource>
        <br />
        <br />
    </div>
      
</asp:Content>
