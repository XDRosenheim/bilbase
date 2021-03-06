﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditCars.aspx.cs" Inherits="EditCars" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Label ID="StatusText_Label" runat="server" Text=""></asp:Label>
    <br />
    <br />

    <asp:Label ID="GetCarModel_Label" runat="server" Text="Vælg en model:"></asp:Label>
    <asp:DropDownList ID="GetCarModel_DDL" runat="server"></asp:DropDownList>
    <br />

    <asp:Button ID="GetValues_Btn" runat="server" Text="Indhent værdier" OnClick="GetValues_Btn_Click" />
    <br />
    <br />

    <asp:Label ID="Model_Label" runat="server" Text="Model:"></asp:Label>
    <asp:TextBox class="TextBoxStyle" ID="Model_Field" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="BraendstofType_Label" runat="server" Text="Brændstofs type:"></asp:Label>
    <asp:DropDownList ID="BraendstofType_DDL" runat="server">
        <asp:ListItem Value="1" Text="Benzin"></asp:ListItem>
        <asp:ListItem Value="2" Text="Diesel"></asp:ListItem>
        <asp:ListItem Value="3" Text="El"></asp:ListItem>
        <asp:ListItem Value="4" Text="Hybrid"></asp:ListItem>
    </asp:DropDownList>
<!-- <asp:TextBox ID="BraendstofType_Field" runat="server"></asp:TextBox> -->
    <br />

    <asp:Label ID="KmPerLiter_Label" runat="server" Text="KM per liter:"></asp:Label>
    <asp:TextBox class="TextBoxStyle"  ID="KmPerLiter_Field" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Pris_Label" runat="server" Text="Pris:"></asp:Label>
    <asp:TextBox class="TextBoxStyle"  ID="Pris_Field" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Aargang" runat="server" Text="Årgang:"></asp:Label>
    <asp:TextBox class="TextBoxStyle" ID="Aargang_Field" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Saeder_Label" runat="server" Text="Sæder:"></asp:Label>
    <asp:TextBox class="TextBoxStyle"  ID="Saeder_Field" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Doere_Label" runat="server" Text="Døre:"></asp:Label>
    <asp:TextBox class="TextBoxStyle"  ID="Doere_Field" runat="server"></asp:TextBox>
    <br />
    <br />

    <asp:Button ID="EditCar_Btn" runat="server" Text="Rediger" OnClick="EditUser_Btn_Click" Width="150px" />
    <br />
    <br />
</asp:Content>

