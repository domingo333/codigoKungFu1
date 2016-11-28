<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="MandarEmail.aspx.cs" Inherits="Clientes_Busqueda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

       <br />
       NOMBRE:
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    &nbsp;<asp:Button ID="Button1" runat="server" Text="Visualiza Registros" 
        onclick="Button1_Click1" Width="170px" />
       <br />
       <br />
       CORREO :&nbsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
       <br />
       <br />
       CONTRASEÑA:&nbsp;
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
       <br />
       <br />
       CORREO A ENVIAR:
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
       <br />
       <br />
       MENSAJE:
       <asp:Panel ID="Panel1" runat="server" BackColor="White" ForeColor="Black" Height="171px" Width="282px">
       </asp:Panel>
       <br />
       <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
       <br />
    <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Height="207px" Width="334px">
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
        <br />
       <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
        <br />
       <br />
       <br />
       <br />
       <br />
    <br />
<br />
    <br />
    <center>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
    </center>

</asp:Content>

