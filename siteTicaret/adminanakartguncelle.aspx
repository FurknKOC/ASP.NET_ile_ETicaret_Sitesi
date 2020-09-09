<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminanakartguncelle.aspx.cs" Inherits="siteTicaret.adminanakartguncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" DataKeyNames="AnakartUrunID" HeaderStyle-CssClass="urunbaslik" AlternatingRowStyle-CssClass="urundetay"><Columns>
            
            <asp:CommandField ShowEditButton="true" EditText="Düzenle" CancelText="İptal" UpdateText="Güncelle" />
<asp:ButtonField CommandName="Delete" Text="Sil" ItemStyle-ForeColor="red"  >
<ItemStyle ForeColor="Red"></ItemStyle>
</asp:ButtonField></Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"
ConnectionString="Data Source=.; Initial Catalog=eTicaret; Integrated Security=true;"
SelectCommand="SELECT * FROM AnakartUrunler"
UpdateCommand="UPDATE [AnakartUrunler] SET [AnakartAdi] = @AnakartAdi , [Marka] =  @Marka , [Fiyat] = @Fiyat ,[Stok] = @Stok , [Uyumluluk]=@Uyumluluk , [Yapi]=@Yapi , [IslemciSoketTipi]=@IslemciSoketTipi , [RamTipi]=@RamTipi , [MbChipSeti]=@MbChipSeti , [MbRamSlotSayisi]=@MbRamSlotSayisi , [SpdifCikisi]=@SpdifCikisi , [Ps2]=@Ps2 , [Sekizkanal]=@Sekizkanal , [Ethernet]=@Ethernet , [KablosuzWifi]=@KablosuzWifi , [usb2]=@usb2 , [usb3]=@usb3 , [ClearCmosButon]=@ClearCmosButon , [SupremeFX]=@SupremeFX , [Bluetooth]=@Bluetooth , [Ses]=@Ses , [PciExpress]=@PciExpress , [Sata3]=@Sata3 , [SataExpress]=@SataExpress , [M2Sata]=@M2Sata , [CoreI7]=@CoreI7 , [Mensei]=@Mensei , [Garanti]=@Garanti , [resim1]=@resim1 , [resim2]=@resim2 , [resim3]=@resim3 , [resim4]=@resim4 WHERE [AnakartUrunID]=@AnakartUrunID" DeleteCommand="Delete [AnakartUrunler] Where [AnakartUrunID]=@AnakartUrunID">
</asp:SqlDataSource>
        <br />
        <br />
    </div>
</asp:Content>
