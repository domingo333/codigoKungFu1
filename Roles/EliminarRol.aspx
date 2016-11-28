<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="EliminarRol.aspx.cs" Inherits="Roles_EliminarRol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <p>
        <br />
    </p>
    <p style="font-family: Aharoni; font-size: x-large; font-weight: bold; font-style: normal">
        Eliminar Rol</p>    
         Escriba Nombre de Rol:
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Eliminar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Continuar" />
         <br />
         <br />
         <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
         <br />
         <br />
    </p>
</asp:Content>

