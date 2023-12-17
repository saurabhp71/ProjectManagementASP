<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="Project_management.Project" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            width: 100%;
        }
        .auto-style10 {
            width: 467px;
            text-align: center;
        }
        .auto-style11 {
            width: 323px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table class="auto-style9">
            <tr>
                <td class="auto-style10">Project Type</td>
                <td class="auto-style11">
                    <asp:DropDownList ID="drpprojecttype" runat="server" Height="16px" Width="119px">
                        <asp:ListItem>Java</asp:ListItem>
                        <asp:ListItem>.Net</asp:ListItem>
                        <asp:ListItem>PHP</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">Project Name</td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtprojectname" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">Start Date</td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtstartdate" runat="server"></asp:TextBox>
                <asp:ImageButton ID="btnstartdate" runat="server" ImageUrl="~/Content/Image/calendar-icon-.jpg" OnClick="btnstartdate_Click1" Width="24px" />
                    <asp:Calendar ID="calstartdate" runat="server" OnSelectionChanged="calstartdate_SelectionChanged"></asp:Calendar>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">End Date</td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtenddate" runat="server"></asp:TextBox>
                <asp:ImageButton ID="btnenddate" runat="server" ImageUrl="~/Content/Image/calendar-icon-.jpg" OnClick="btnenddate_Click1" Width="24px" />
                    <asp:Calendar ID="calenddate" runat="server" OnSelectionChanged="calenddate_SelectionChanged"></asp:Calendar>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Button ID="btnRegister" runat="server" Text="Register" Width="107px" OnClick="btnRegister_Click" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="btnClear" runat="server" Text="Clear" Width="107px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
    </p>
</asp:Content>
