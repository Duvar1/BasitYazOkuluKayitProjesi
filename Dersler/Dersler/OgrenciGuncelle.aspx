<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form id="Form1" runat="server">
   

     <div class="form-group">
       
        
         <div>
             <asp:Label for="TxtId" runat="server" Text="Öğrenci ID:" style="font-weight: 700"></asp:Label>
             <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>
         </div>
         <br />
         <div>
             <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı:" style="font-weight: 700"></asp:Label>
             <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
         </div>
         <br />
         <div>
             <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci SoyAdı:" style="font-weight: 700"></asp:Label>
             <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
         </div>
         <br />
         <div>
             <asp:Label for="TxtNumara" runat="server" Text="Öğrenci Numara:" style="font-weight: 700"></asp:Label>
             <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
         </div>
         <br />
         <div>
             <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifre:" style="font-weight: 700"></asp:Label>
             <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
         </div>
         <br />
         <div>
             <asp:Label for="TxtFoto" runat="server" Text="Öğrenci Fotoğraf:" style="font-weight: 700"></asp:Label>
             <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control"></asp:TextBox>
         </div>
         <br />



     </div>
  <asp:Button ID="Button1" runat="server" Text="Güncelle"  CssClass="btn btn-warning" OnClick="Button1_Click" />


 </form>
</asp:Content>
