﻿<%@ Page Title="" Language="VB" MasterPageFile="~/Events/EventsMasterPage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="Events_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>  
    <table style="width:100%;padding-bottom:10px;padding-right:0px">
        <tr>
        <td style="text-align:left;vertical-align:top;color:#485385;font-size:10pt;font-weight:bold">Events</td>
        <td style="text-align:right"><asp:Button ID="EventsButton" runat="server" Text="My Events" CssClass="Button" PostBackUrl="~/Events/MyEvents.aspx" /></td>
        </tr>
    </table>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:PlaceHolder ID="EventPlaceHolder" runat="server"></asp:PlaceHolder>
            <asp:Timer ID="EventsTimer" runat="server" Interval="10000">
            </asp:Timer>
        </ContentTemplate>
    </asp:UpdatePanel>

    </asp:Content>

