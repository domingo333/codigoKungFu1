using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Roles_EliminarRol : System.Web.UI.Page
{
    MembershipUserCollection rol;
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Text = "Eliminar";
        Button2.Text = "Continuar";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (Roles.DeleteRole(TextBox1.Text, true))
            Label1.Text = "Rol eliminado exitosamente";
        else
            Label1.Text = "No se pudo eliminar el Rol";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }
}