<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="InsertarMestro.aspx.cs" Inherits="Clientes_Insertar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
        width: 63%;
        height: 643px;
    }
    .auto-style2 {
    }
    .auto-style3 {
        width: 137px;
    }
        .auto-style4 {
            width: 286px;
        }
        .auto-style5 {
            width: 137px;
            height: 15px;
        }
        .auto-style6 {
            width: 286px;
            height: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <center
    <asp:Label ID="Label1" runat="server" Text="Id: "></asp:Label>
        <br />
        <table class="auto-style1" style="font-family: 'Arial Rounded MT Bold'; background-color: #C0C0C0; border-style: double; color: black;">
            <tr>
                <td class="auto-style3">
    <asp:Label ID="Label2" runat="server" Text="Nombre: "></asp:Label>
                </td>
                <td class="auto-style4">
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
    <asp:Label ID="Label3" runat="server" Text="ApPaterno: "></asp:Label>
                </td>
                <td class="auto-style4">
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
    <asp:Label ID="Label6" runat="server" Text="ApMaterno : "></asp:Label>
                </td>
                <td class="auto-style4">
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
    <asp:Label ID="Label4" runat="server" Text="FechaNac: "></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                        <NextPrevStyle VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#808080" />
                        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" />
                        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <WeekendDayStyle BackColor="#FFFFCC" />
                    </asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
    <asp:Label ID="Label11" runat="server" Text="Direccion :"></asp:Label>
                </td>
                <td class="auto-style4">
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
    <asp:Label ID="Label12" runat="server" Text="Telefono :"></asp:Label>
                </td>
                <td class="auto-style4"><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
    <asp:Label ID="Label13" runat="server" Text="Sexo :"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="172px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Masculino</asp:ListItem>
                        <asp:ListItem>Femenino</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
    <asp:Label ID="Label14" runat="server" Text="Email :"></asp:Label>
                </td>
                <td class="auto-style4"><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
    <asp:Label ID="Label15" runat="server" Text="Contraseña :"></asp:Label>
                </td>
                <td class="auto-style6"><asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
    <asp:Button ID="Button1" runat="server" Text="Agregar" 
        onclick="Button1_Click1" />
                </td>
            </tr>
        </table>

        </center>
    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>

</asp:Content>

