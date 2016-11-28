using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Roles_RemoverRolUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            // Bind the roles
            BindRolesToList();
            // Display those users belonging to the currently selected role 
            DisplayUsersBelongingToRole();
        }
    }

    private void BindRolesToList()
    {
        // Get all of the roles       
        string[] roles = Roles.GetAllRoles();
        RoleList.DataSource = roles;
        RoleList.DataBind();
    }

    private void DisplayUsersBelongingToRole()
    {
        // Get the selected role 
        string selectedRoleName = RoleList.SelectedValue;

        // Get the list of usernames that belong to the role 
        string[] usersBelongingToRole = Roles.GetUsersInRole(selectedRoleName);

        // Bind the list of users to the GridView 
        RolesUserList.DataSource = usersBelongingToRole;
        RolesUserList.DataBind();
    }

    protected void RoleList_SelectedIndexChanged(object sender, EventArgs e)
    {
        DisplayUsersBelongingToRole();
    }

    protected void RolesUserList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        // Get the selected role 
        string selectedRoleName = RoleList.SelectedValue;

        // Reference the UserNameLabel 
        Label UserNameLabel = RolesUserList.Rows[e.RowIndex].FindControl("UserNameLabel") as Label;

        // Remove the user from the role 
        Roles.RemoveUserFromRole(UserNameLabel.Text, selectedRoleName);

        // Refresh the GridView 
        DisplayUsersBelongingToRole();

        // Display a status message 
        ActionStatus.Text = string.Format("El Usuario {0} ha sido removido del Rol {1}.", UserNameLabel.Text, selectedRoleName);
    }
}