using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Usuarios_EliminarUsuario : System.Web.UI.Page
{
    MembershipUserCollection usuarios;
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Text = "Eliminar";
        Button2.Text = "Regresar al inicio";

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Membership.DeleteUser(TextBox1.Text, true))
            Label1.Text = "Usuario eliminado exitosamente";
        else
            Label1.Text = "No se pudo eliminar el Usuario";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        usuarios = Membership.FindUsersByName(TextBox1.Text);
        GridView1.DataSource = usuarios;
        GridView1.DataBind();
        //Label3.Text = usuarios.Count.ToString();

        if (usuarios.Count == 0) Label2.Text = "El Usuario no se encuentra en la Base de Datos";
        else
        {
            Label2.Text = "";
        }
    }
}