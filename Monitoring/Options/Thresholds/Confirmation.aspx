﻿<%@ Page Title="" Language="VB" MasterPageFile="~/Options/OptionsMasterPage.master" AutoEventWireup="false" CodeFile="Confirmation.aspx.vb" Inherits="Options_Thresholds_Confirmation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <h2> <asp:HyperLink ID="OptionsHyperLink" runat="server" NavigateUrl="~/Options/Default.aspx">Options</asp:HyperLink>&gt;<asp:HyperLink ID="ThresholdsHyperLink" runat="server" NavigateUrl="~/Options/Thresholds/Default.aspx">Thresholds</asp:HyperLink>&gt;Confirmation</h2>

    
         <table class='StaticTable' style='width: 100%'><thead><tr><th>Confirmation</th></tr></thead><tr><td style="text-align:center">

    <br />
             <asp:Label ID="MessageLabel" runat="server" Text=""></asp:Label><br />
             <asp:Label ID="ValueLabel" runat="server" Text="" Visible="False"></asp:Label>
             <br />

    <asp:Button ID="ReturnButton" runat="server" Text="Return" CssClass="Button" PostBackUrl="~/Options/Default.aspx" />&nbsp;<asp:Button ID="SubmitButton" runat="server" Text="Submit" CssClass="Button" />
<br />

             </td></tr></table>


</asp:Content>
