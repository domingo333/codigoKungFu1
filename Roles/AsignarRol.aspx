<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="AsignarRol.aspx.cs" Inherits="Roles_AsignarRol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
        <br />
        <p style="font-family: Aharoni; font-size: x-large; font-weight: bold">Asignación de Roles Para un Usuario</p>
        <br />
        <asp:Label ID="ActionStatus" runat="server" Text="Label" Font-Size="Large" ForeColor="#FF3300"></asp:Label>
        <br />
        <br />
        <p style="font-weight: bold">Seleccione usuario:
            <asp:DropDownList ID="UserList" runat="server" AutoPostBack="true" 
            DataTextField="UserName" DataValueField="UserName" OnSelectedIndexChanged="UserList_SelectedIndexChanged" >
            </asp:DropDownList>
        </p>
        <asp:Repeater ID="UsersRoleList" runat="server">
            <ItemTemplate>
                <asp:CheckBox ID="RoleCheckBox" runat="server"  AutoPostBack="true"
                Text='<%# Container.DataItem %>'
                OnCheckedChanged="RoleCheckBox_CheckChanged"/>
                <br />
            </ItemTemplate>
        </asp:Repeater>
        <br />
        <br />   

</asp:Content>

