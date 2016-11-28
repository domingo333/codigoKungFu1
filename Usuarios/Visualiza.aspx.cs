using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Usuarios_Visualiza : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        MembershipUserCollection users = Membership.GetAllUsers();
        GridView1.DataSource = users;
        GridView1.DataBind();
    }
  
}