<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Asign Project.aspx.cs" Inherits="Project_management.Asign_Project1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 100%;
            height: 188px;
        }
        .auto-style5 {
            text-align: right;
            width: 459px;
        }
        .auto-style6 {
            width: 347px;
            height: 36px;
        }
        .auto-style7 {
            text-align: right;
            width: 376px;
            height: 36px;
            margin-right: 0px;
        }
        .auto-style14 {
            text-align: right;
            width: 376px;
            height: 45px;
            margin-right: 0px;
        }
        .auto-style15 {
            width: 347px;
            height: 45px;
        }
        .auto-style16 {
            height: 45px;
        }
        .auto-style17 {
            height: 36px;
        }
        .auto-style18 {
            height: 43px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br />
        <table class="auto-style4">
            <tr>
                <td class="auto-style7">Project Name</td>
                <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="drpProjectname" runat="server" Height="21px" Width="199px">
                    </asp:DropDownList>
                    &nbsp;</td>
                <td class="auto-style17"></td>
            </tr>
            <tr>
                <td class="auto-style14">Project Manager</td>
                <td class="auto-style15">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="drpprojectmanager" runat="server" Height="27px" Width="193px">
                    </asp:DropDownList>
                    &nbsp;</td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td colspan="3" class="auto-style18">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnAsign" runat="server" Height="28px" Text="Asign" Width="127px" OnClick="btnAsign_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnClear" runat="server" Height="25px" Text="Clear" Width="134px" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
    </div>
</asp:Content>
