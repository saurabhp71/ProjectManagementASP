<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Project_management.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 100%;
            height: 451px;
        }
        .auto-style8 {
            margin-left: 0px;
        }
        .auto-style9 {
        width: 575px;
        text-align: center;
    }
        .auto-style10 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        <table class="auto-style5">
            <tr>
                <td class="auto-style9">Type</td>
                <td class="auto-style10">
                    <asp:DropDownList ID="drpType" runat="server" CssClass="auto-style8" Height="17px" Width="176px">
                        <asp:ListItem>Project Manager</asp:ListItem>
                        <asp:ListItem>Admin</asp:ListItem>
                        <asp:ListItem>Team Lead</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Name</td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtName" runat="server" Height="20px" Width="166px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Phone</td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtPhone" runat="server" Height="20px" Width="164px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Email</td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtEmail" runat="server" Height="22px" Width="164px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Gender</td>
                <td class="auto-style10">
                    <asp:RadioButton ID="rdbtnMale" runat="server" Text="Male" GroupName="Gender" OnCheckedChanged="rdbtnMale_CheckedChanged" />
                    <asp:RadioButton ID="rdbtnFemale" runat="server" Text="Female" GroupName="Gender" OnCheckedChanged="rdbtnFemale_CheckedChanged" />
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Country</td>
                <td class="auto-style10">
                    <asp:DropDownList ID="drpCountry" runat="server" Height="16px" Width="174px" OnSelectedIndexChanged="drpCountry_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">State</td>
                <td class="auto-style10">
                    <asp:DropDownList ID="drpState" runat="server" Height="18px" Width="175px" OnSelectedIndexChanged="drpState_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">City</td>
                <td class="auto-style10">
                    <asp:DropDownList ID="drpCity" runat="server" Height="22px" Width="174px" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Password</td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtPassword" runat="server" Height="16px" Width="161px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                </td>
                <td class="auto-style10">
                    &nbsp;&nbsp;
                    <asp:Button ID="btnClear" runat="server" Text="Clear" />
                </td>
            </tr>
        </table>
        <br />
    </p>
    <p>
    </p>
</asp:Content>
