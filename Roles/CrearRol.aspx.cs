using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Roles_CrearRol : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Text = "Agregar";
        //Cargar Roles Existentes
         string[] roles = Roles.GetAllRoles();
         ListBox1.DataSource = roles;
         ListBox1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ListBox1.Items.Add(TextBox1.Text);
            //Agregar Rol a la BD
            Roles.CreateRole(TextBox1.Text);
        }
        else CustomValidator1.ErrorMessage = "EL Rol ya existe";
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (ListBox1.Items.Count > 0)
        {
            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                if (TextBox1.Text == ListBox1.Items[i].ToString()) args.IsValid = false;
            }
        }
        else
        {
            args.IsValid = true;
        } 
    }
}