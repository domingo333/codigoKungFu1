<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="CrearRol.aspx.cs" Inherits="Roles_CrearRol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <br />
        <p style="font-family: Aharoni; font-size: x-large; font-weight: bold; font-style: normal">
        Creación de Roles de usuario</p>
        <p>Ingrese un Rol para agregarlo a la lista</p>Rol:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <br />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="102px" Width="117px">
        </asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CustomValidator ID="CustomValidator1" runat="server" 
            ControlToValidate="TextBox1" ErrorMessage="CustomValidator" 
            onservervalidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
        <br />
        <br />
        <br />
    <br />
        <br />
        <br />
        
    
</asp:Content>

