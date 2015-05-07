<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Label ID="Username_Label" runat="server" Text="Brugernavn:"></asp:Label>
    <asp:TextBox ID="Username_Field" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Password_Label" runat="server" Text="Password:"></asp:Label>
    <asp:TextBox ID="Password_Field" TextMode="Password" runat="server"></asp:TextBox>
    <br />
    <br />

    <asp:Button ID="Login_Btn" runat="server" Text="Login" OnClick="Login_Btn_Click"/> <!---->
    <br />
    <br />

    <a href="Register.aspx">Har du ikke en bruger?</a>
</asp:Content>

