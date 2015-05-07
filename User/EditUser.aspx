<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditUser.aspx.cs" Inherits="EditUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Label ID="StatusText_Label" runat="server" Text=""></asp:Label>
    <br />
    <br />

    <asp:Label runat="server" Text="Vælg en bruger:"></asp:Label>
    <asp:DropDownList ID="GetUser_DDL" runat="server"></asp:DropDownList>
    <br />
    <asp:Button ID="GetValues_Btn" runat="server" Text="Indhent værdier" OnClick="GetValues_Btn_Click" />
    <br />
    <br />

    <asp:Label runat="server" Text="Brugernavn:"></asp:Label>
    <asp:TextBox ID="Username_Field" runat="server"></asp:TextBox>
    <br />

    <asp:Label runat="server" Text="Password:"></asp:Label>
    <asp:TextBox ID="Password_Field" runat="server"></asp:TextBox>
    <br />

    <asp:Label runat="server" Text="Mail:"></asp:Label>
    <asp:TextBox ID="Mail_Field" runat="server"></asp:TextBox>
    <br />

    <asp:Label runat="server" Text="Tlf:"></asp:Label>
    <asp:TextBox ID="Tlf_Field" runat="server"></asp:TextBox>
    <br />

    <asp:Label runat="server" Text="Rolle:"></asp:Label>
    <asp:DropDownList ID="Rolle_DDL" runat="server">
        <asp:ListItem Value="1" Text="Administrator"></asp:ListItem>
        <asp:ListItem Value="2" Text="Bruger"></asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />

    <asp:Button ID="EditUser_Btn" runat="server" Text="Rediger" OnClick="EditUser_Btn_Click" Width="150px" />
    <asp:Button ID="EditUser_del" runat="server" Text="Slet" OnClick="EditUser_del_Click" Width="50px" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Visible="false" Text="Er du sikker?"></asp:Label>
    <br />
    <asp:Button ID="btn_sure" runat="server" OnClick="btn_sure_Click" Text="Ja" Visible="false"/>
    <asp:Button ID="btn_NOPE" runat="server" OnClick="btn_NOPE_Click" Text="Nej" Visible="false"/>
</asp:Content>