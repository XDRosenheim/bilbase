<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <!-- Status label, starter som usynlig.-->
    <asp:Label ID="Status_label" runat="server" Text="Label" Visible="False"></asp:Label>
    <br />
    <br />
    <!-- -->
    <asp:Label ID="Username_Label" runat="server" Text="Brugernavn:"></asp:Label>
    <asp:TextBox class="TextBoxStyle"  ID="EnterUsername_Field" runat="server"></asp:TextBox>
    <br />
    <!-- -->
    <asp:Label ID="Password_Label" runat="server" Text="Password:"></asp:Label>
    <asp:TextBox class="TextBoxStyle" ID="EnterPassword_Field" TextMode="Password" runat="server"></asp:TextBox>
    <br />
    <!-- -->
    <asp:Label ID="RePassword_Label" runat="server" Text="Gentag password:"></asp:Label>
    <asp:TextBox class="TextBoxStyle"  ID="ReEnterPassword_Field" TextMode="Password" runat="server"></asp:TextBox>
    <br />
    <!-- -->
    <asp:Label ID="Mail_Label" runat="server" Text="Email adresse:"></asp:Label>
    <asp:TextBox class="TextBoxStyle"  ID="EnterMail_Field" runat="server"></asp:TextBox>
    <br />
    <!-- Label og textbox -->
    <asp:Label ID="Tlf_Label" runat="server" Text="Tlf nr.:"></asp:Label>
    <asp:TextBox class="TextBoxStyle"  ID="EnterTlf_Field" runat="server"></asp:TextBox>
    <br />
    <br />
    <!-- BUTTON! -->
    <asp:Button ID="btn_regit" runat="server" Text="Opret" OnClick="btn_regit_Click"/>
</asp:Content>