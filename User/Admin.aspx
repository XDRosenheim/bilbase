<%@ Page Title="Admin title" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="AdminClass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Label ID="label_greeting" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Edit database "></asp:Label>
    <asp:Button ID="EditCar_Btn" runat="server" Text="Cars" OnClick="EditCar_Btn_Click" />
    <asp:Button ID="EditUser_Btn" runat="server" Text="Users" OnClick="EditUser_Btn_Click" />

</asp:Content>