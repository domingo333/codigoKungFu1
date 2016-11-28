<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="Eliminar.aspx.cs" Inherits="Modificacion_Eliminar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>Eliminación de un registro por medio de su Id. </p>
     <asp:Label ID="Label1" runat="server" Text="Id:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
     <br />
     <br />

     <br />

      <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Eliminar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />

      <br />

</asp:Content>

