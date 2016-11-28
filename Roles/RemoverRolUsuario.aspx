<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="RemoverRolUsuario.aspx.cs" Inherits="Roles_RemoverRolUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
        <p style="font-family: Aharoni; font-size: x-large; font-weight: bold">
            Remover Rol Para un Usuario</p>
        <asp:Label ID="ActionStatus" runat="server" Font-Size="Large" 
            ForeColor="#FF3300" Text="Label"></asp:Label>
        <br />
        <p style="font-weight: bold">
            Seleccione usuario:
            <asp:DropDownList ID="RoleList" runat="server" AutoPostBack="true" 
                onselectedindexchanged="RoleList_SelectedIndexChanged"> 
            </asp:DropDownList>
        </p>
        <asp:GridView ID="RolesUserList" runat="server" AutoGenerateColumns="False"
                      EmptyDataText="No hay usuarios asociados a este Rol." 
            onrowdeleting="RolesUserList_RowDeleting" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" >
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:TemplateField HeaderText="Users"> 
                    <ItemTemplate> 
                         <asp:Label runat="server" id="UserNameLabel" 
                              Text='<%# Container.DataItem %>'></asp:Label> 
                    </ItemTemplate> 
               </asp:TemplateField> 
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
</asp:Content>

