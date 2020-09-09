<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminekrankartiguncelle.aspx.cs" Inherits="siteTicaret.adminekrankartiguncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" DataKeyNames="EkranKartiUrunID" HeaderStyle-CssClass="urunbaslik" AlternatingRowStyle-CssClass="urundetay"><Columns>
            
            <asp:CommandField ShowEditButton="true" EditText="Düzenle" CancelText="İptal" UpdateText="Güncelle" />
<asp:ButtonField CommandName="Delete" Text="Sil" ItemStyle-ForeColor="red"  >
<ItemStyle ForeColor="Red"></ItemStyle>
</asp:ButtonField></Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"
ConnectionString="Data Source=.; Initial Catalog=eTicaret; Integrated Security=true;"
SelectCommand="SELECT * FROM EkranKartiUrunler"
UpdateCommand="UPDATE [EkranKartiUrunler] SET [EkranKartiAdi] = @EkranKartiAdi , [Marka] =  @Marka , [Fiyat] = @Fiyat , [Stok]=@Stok , [CekirdekHizi]=@CekirdekHizi , [RamKapasitesi]=@RamKapasitesi , [BellekHizi]=@BellekHizi , [GrafikChipsetiMarkasi]=@GrafikChipsetiMarkasi , [EkranKartiChipseti]=@EkranKartiChipseti , [BellekTipi]=@BellekTipi , [BellekArayuzu]=@BellekArayuzu , [PciExpress3]=@PciExpress3 , [DisplayPort]=@DisplayPort , [HdcpDestegi]=@HdcpDestegi , [Dvi]=@Dvi , [Hdmi]=@Hdmi , [GucTuketimi]=@GucTuketimi , [Mensei]=@Mensei , [Garanti]=@Garanti , [Cozunurluk]=@Cozunurluk , [resim1]=@resim1 , [resim2]=@resim2 , [resim3]=@resim3 WHERE [EkranKartiUrunID]=@EkranKartiUrunID" DeleteCommand="Delete [EkranKartiUrunler] Where [EkranKartiUrunID]=@EkranKartiUrunID">
</asp:SqlDataSource>
        <br />
        <br />
    </div>
</asp:Content>
