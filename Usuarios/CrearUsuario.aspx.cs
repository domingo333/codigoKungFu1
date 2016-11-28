using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Usuarios_CrearUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CreateUserWizard1.DisplayCancelButton = true;
        CreateUserWizard1.CancelDestinationPageUrl = "~/Default.aspx";
        CreateUserWizard1.ContinueDestinationPageUrl = "~/Default.aspx";
        Label1.Text=User.Identity.Name;
     
    }
}