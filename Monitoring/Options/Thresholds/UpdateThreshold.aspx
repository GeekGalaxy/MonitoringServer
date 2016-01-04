﻿<%@ Page Title="" Language="VB" MasterPageFile="~/Options/OptionsMasterPage.master" AutoEventWireup="false" CodeFile="UpdateThreshold.aspx.vb" Inherits="Options_EditThreshold" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table style="width:100%;padding-bottom:10px;padding-right:0px">
        <tr>
        <td style="text-align:left;vertical-align:top;color:#485385;font-size:10pt;font-weight:bold"><asp:HyperLink ID="OptionsHyperLink" runat="server">Options</asp:HyperLink>&gt;<asp:HyperLink ID="ThresholdsHyperLink" runat="server" NavigateUrl="~/Options/Thresholds/Default.aspx">Thresholds</asp:HyperLink>&gt;Update Threshold</td>
        <td style="text-align:right"><asp:Button ID="OptionsButton" runat="server" Text="Options" CssClass="Button" PostBackUrl="~/Options/Default.aspx" /></td>
        </tr>
    </table>

         <table class='StaticTable' style='width: 100%'><thead><tr><th>Update Threshold</th></tr></thead><tr><td>
          <table style="width:500px">
              <tr>

                  <td>Class:</td>
                  <td>
                      <asp:TextBox ID="ClassTextBox" runat="server" CssClass="TextBox" Enabled="false" Width="150px"></asp:TextBox></td>
              </tr>
              <tr>

                  <td>Property:</td>
                  <td>
                      <asp:TextBox ID="PropertyTextBox" runat="server" CssClass="TextBox" Enabled="false" Width="150px"></asp:TextBox></td>
              </tr>
                            <tr>

                  <td>Operator</td>
                  <td>
                      <asp:DropDownList ID="OperatorDropDownList" runat="server" CssClass="TextBox">
                          <asp:ListItem Value="=" >=</asp:ListItem>
                          <asp:ListItem Value=">">&gt;</asp:ListItem>
                          <asp:ListItem Value=">=">&gt;=</asp:ListItem>
                          <asp:ListItem Value="<">&lt;</asp:ListItem>
                          <asp:ListItem Value="<=">&lt;=</asp:ListItem>
                          <asp:ListItem Value="<>">&lt;&gt;</asp:ListItem>
                      </asp:DropDownList></td>
              </tr>
                            <tr>

                  <td>Threshold:</td>
                  <td>
                      <asp:TextBox ID="ThresholdTextBox" runat="server" CssClass="TextBox" Width="150px" TextMode="Number"></asp:TextBox></td>
              </tr>
                            <tr>

                  <td>Duration (Min.):</td>
                  <td>
                      <asp:TextBox ID="DurationTextBox" runat="server" CssClass="TextBox" Width="150px" TextMode="Number"></asp:TextBox></td>
              </tr>
                            <tr>

                  <td>Severity:</td>
                  <td>
                      <asp:DropDownList ID="SeverityDropDownList" runat="server" CssClass="TextBox" Width="110px">
                          <asp:ListItem Value="3">Critical</asp:ListItem>
                          <asp:ListItem Value="2">Major</asp:ListItem>
                          <asp:ListItem Value="1">Minor</asp:ListItem>
                      </asp:DropDownList></td>
              </tr>
                 <tr>
                              <td>Enabled:</td>
                              <td>
                                  <asp:RadioButtonList ID="EnabledRadioButtonList" runat="server" RepeatDirection="Horizontal" Width="100px">
                                      <asp:ListItem Value="True">Yes</asp:ListItem>
                                      <asp:ListItem Value="False">No</asp:ListItem>
                                  </asp:RadioButtonList></td>

                          </tr>
              <tr>
                  <td colspan="2">

                      <asp:Label ID="ValidatorLabel" runat="server" ForeColor="Red"></asp:Label>
                  </td>

              </tr>
                            <tr>

                  <td>
                      <asp:Label ID="IDLabel" runat="server" Visible="False"></asp:Label>
                                </td>
                  <td>
                      <asp:Button ID="ReturnButton" runat="server" CssClass="Button" PostBackUrl="~/Options/Thresholds/Default.aspx" Text="Return" UseSubmitBehavior="False" />&nbsp;<asp:Button ID="EditButton" runat="server" CssClass="Button" Text="Edit" />
                                </td>
              </tr>


          </table>

             </td>
             </tr>
             </table>

</asp:Content>

