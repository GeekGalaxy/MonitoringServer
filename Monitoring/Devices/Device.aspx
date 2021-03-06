﻿<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Device.aspx.vb" Inherits="Devices_Device" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <h2><asp:HyperLink ID="DevicesHyperLink" runat="server" NavigateUrl="~/Devices/Default.aspx">Devices</asp:HyperLink>&gt;<asp:Label ID="HostNameLabel" runat="server" Text="Device"></asp:Label></h2>
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:PlaceHolder ID="DevicePlaceHolder" runat="server"></asp:PlaceHolder>
            <asp:Timer ID="DeviceTimer" runat="server"></asp:Timer>
        </ContentTemplate>
           </asp:UpdatePanel>
<div style="float:right;padding-right:5px"><br />
    <asp:Button ID="ServicesButton" runat="server" Text="Services" Width="80px" CssClass="Button" />&nbsp;<asp:Button ID="ThresholdButton" runat="server" Text="Thresholds" CssClass="Button" Visible="False" Width="80px" />
</div>
</asp:Content>

