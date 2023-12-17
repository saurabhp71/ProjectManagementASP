<%@ Page Title="" Language="C#" MasterPageFile="~/TeamLead.Master" AutoEventWireup="true" CodeBehind="TeamLead.aspx.cs" Inherits="Project_management.TeamLead1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 100%;
        }
        .auto-style5 {
            width: 299px;
        }
        .auto-style6 {
            width: 299px;
            text-align: right;
        }
        .auto-style7 {
            text-align: center;
        }
        .auto-style8 {
            text-align: right;
            height: 60px;
        }
        .auto-style9 {
            width: 299px;
            height: 56px;
        }
        .auto-style10 {
            text-align: center;
            height: 56px;
        }
        .auto-style11 {
            height: 56px;
        }
        .auto-style12 {
            width: 299px;
            height: 60px;
        }
        .auto-style13 {
            height: 60px;
            text-align: justify;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <table class="auto-style4">
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style10"><strong>
                <asp:Label ID="lblPN" runat="server" Text="Project Name"></asp:Label>
                </strong></td>
            <td class="auto-style11"></td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style13">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Team Lead -<asp:Label ID="lblTL" runat="server" Text="TL Name"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="lblPN1" runat="server" Text="Project Name"></asp:Label>
            </td>
            <td class="auto-style7">Itration1</td>
            <td>
                <asp:Button ID="btnCompleted1" runat="server" Height="26px" OnClick="btnCompleted1_Click" Text="Completed" Width="135px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="lblPN2" runat="server" Text="Project Name"></asp:Label>
            </td>
            <td class="auto-style7">Itration2</td>
            <td>
                <asp:Button ID="btnCompleted2" runat="server" Height="26px" OnClick="btnCompleted2_Click" Text="Completed" Width="135px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="lblPN3" runat="server" Text="Project Name"></asp:Label>
            </td>
            <td class="auto-style7">Itration3</td>
            <td>
                <asp:Button ID="btnCompleted3" runat="server" Height="26px" Text="Completed" Width="135px" OnClick="btnCompleted3_Click" />
            </td>
        </tr>
    </table>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
</asp:Content>
