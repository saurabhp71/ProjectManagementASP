<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="CompletedProject.aspx.cs" Inherits="Project_management.CompletedProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="grdCompleteProject" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="grdCompleteProject_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ProjectName" HeaderText="Project Name" />
                <asp:BoundField DataField="Team Lead" HeaderText="Team Lead" />
                <asp:BoundField DataField="Project Manager" HeaderText="Project Manager" />
                <asp:BoundField DataField="EmailId" HeaderText="EmailId" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                <asp:BoundField DataField="Date" HeaderText="Date" />
                <asp:CommandField SelectText="Pay" HeaderText="manage" ShowSelectButton="True" />

            </Columns>
        </asp:GridView>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
