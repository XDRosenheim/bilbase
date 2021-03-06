﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Spark.aspx.cs" Inherits="Spark" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>       
        <h4>Specificationer</h4> 
        <table>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Mærke"></asp:Label></td>
                <td><asp:Label ID="Label2" runat="server" Text="Model"></asp:Label></td>
                <td><asp:Label ID="Label3" runat="server" Text="Brændstoftype"></asp:Label></td>
                <td><asp:Label ID="Label4" runat="server" Text="KM/L"></asp:Label></td>
                <td><asp:Label ID="Label5" runat="server" Text="Årgang"></asp:Label></td>
                <td><asp:Label ID="Label6" runat="server" Text="Antal sæder"></asp:Label></td>
                <td><asp:Label ID="Label7" runat="server" Text="Antal døre"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="car_mærke" runat="server" Text="N/A"></asp:Label></td>
                <td><asp:Label ID="car_model" runat="server" Text="N/A"></asp:Label></td>
                <td><asp:Label ID="car_fueltype" runat="server" Text="N/A"></asp:Label></td>
                <td><asp:Label ID="car_distance" runat="server" Text="N/A"></asp:Label></td>
                <td><asp:Label ID="car_year" runat="server" Text="N/A"></asp:Label></td>
                <td><asp:Label ID="car_seats" runat="server" Text="N/A"></asp:Label></td>
                <td><asp:Label ID="car_doors" runat="server" Text="N/A"></asp:Label></td>
            </tr>
        </table>
        <img src="/img/Chevrolet_Spark.jpg" />
        <h4>Kommentarer</h4>
        <asp:Label ID="comment" runat="server"></asp:Label>
        <br />
        <br />  
        <asp:TextBox class="commentBox" ID="TextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="commentBtn" runat="server" Text="Button" OnClick="commentBtn_Click"></asp:Button>
    </center>
</asp:Content>