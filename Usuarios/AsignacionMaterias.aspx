<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="AsignacionMaterias.aspx.cs" Inherits="Usuarios_AsignacionMaterias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <br />
<br />
<asp:Label ID="Label3" runat="server" Text="Id_Maestro"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label4" runat="server" Text="Materia: "></asp:Label>
<asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem>Matematicas</asp:ListItem>
    <asp:ListItem>Español</asp:ListItem>
    <asp:ListItem>Ingles</asp:ListItem>
</asp:DropDownList>
<br />
<br />
<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
<br />
<br />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
<br />
<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
<br />
<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
<br />
</asp:Content>

