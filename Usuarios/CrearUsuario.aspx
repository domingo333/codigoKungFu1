<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="CrearUsuario.aspx.cs" Inherits="Usuarios_CrearUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <br />
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell><p style="font-family: Aharoni; font-size: x-large; font-weight: bold; font-style: normal">Creación de una nueva cuenta de usuario</p><br /></asp:TableCell>
        </asp:TableRow>        
        <asp:TableRow>
            <asp:TableCell>
                <asp:CreateUserWizard ID="CreateUserWizard1" runat="server">
                    <WizardSteps>
                        <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                        </asp:CreateUserWizardStep>
                        <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                        </asp:CompleteWizardStep>
                    </WizardSteps>
                </asp:CreateUserWizard>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        <br />
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />        
        <br />
        <br />
        
        <br />
        <br />
        <br />
        <br />
        <br />


</asp:Content>

