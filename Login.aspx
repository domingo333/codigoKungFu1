<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
            <asp:TableRow ID="TableRow1" runat="server">
                <asp:TableCell ID="TableCell1" runat="server" HorizontalAlign="Center">
                    <p style="font-size: x-large; font-weight: bold; font-family: Aharoni; color: #0000FF;">BIENVENIDO</p>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow2" runat="server">
                <asp:TableCell ID="TableCell2" runat="server"></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow3" runat="server">
                <asp:TableCell ID="TableCell3" runat="server">
                    <asp:Login ID="Login1" runat="server" onauthenticate="Login1_Authenticate" 
                BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderPadding="4" BorderStyle="Solid" 
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" 
                Height="191px" Width="410px">
                
<InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                

<LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" 
                    BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                

<TextBoxStyle Font-Size="0.8em" />
                

<TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" 
                    ForeColor="White" />
            
</asp:Login>
            

            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableClientScript="true" 
                ValidationGroup="Login1" />
            

            <br />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
       
        <br />
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
