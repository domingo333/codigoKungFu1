using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Roles_AsignarRol : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            // Bind the users and roles 
            BindUsersToUserList();
            BindRolesToList();
            // Check the selected user's roles 
            CheckRolesForSelectedUser();
        }         
    }
        //Carga los usuarios existentes enel dropdown
    private void BindUsersToUserList()
    {
        // Get all of the user accounts 
        MembershipUserCollection users = Membership.GetAllUsers();
        UserList.DataSource = users;
        UserList.DataBind();
    }

    //Carga los roles existentes mediante el control repeater
    //como controles checkbox
    private void BindRolesToList()
    {
        // Get all of the roles 
        string[] roles = Roles.GetAllRoles();
        UsersRoleList.DataSource = roles;
        UsersRoleList.DataBind();
    }

    //Cuando se carga la página o cuando se selecciona un usuario
    //verifica cada checbox con el rol perteneciente al usuario
    private void CheckRolesForSelectedUser()
    {
        // Determine what roles the selected user belongs to 
        string selectedUserName = UserList.SelectedValue;
        string[] selectedUsersRoles = Roles.GetRolesForUser(selectedUserName);

        // Loop through the Repeater's Items and check or uncheck the checkbox as needed 

        foreach (RepeaterItem ri in UsersRoleList.Items)
        {
            // Programmatically reference the CheckBox 
            CheckBox RoleCheckBox = ri.FindControl("RoleCheckBox") as CheckBox;
            // See if RoleCheckBox.Text is in selectedUsersRoles 
            if (selectedUsersRoles.Contains<string>(RoleCheckBox.Text))
                RoleCheckBox.Checked = true;
            else
                RoleCheckBox.Checked = false;
        }
    }

    //Se añade o quita el rol al usuario seleccionado ´selectedUserName´
    protected void RoleCheckBox_CheckChanged(object sender, EventArgs e)
    {
        // Reference the CheckBox that raised this event 
        CheckBox RoleCheckBox = sender as CheckBox;

        // Get the currently selected user and role 
        string selectedUserName = UserList.SelectedValue;

        string roleName = RoleCheckBox.Text;

        // Determine if we need to add or remove the user from this role 
        if (RoleCheckBox.Checked)
        {
            // Add the user to the role 
            Roles.AddUserToRole(selectedUserName, roleName);
            // Display a status message 
            ActionStatus.Text = string.Format("El Usuario {0} fue agregado al Rol {1}.", selectedUserName, roleName);
        }
        else
        {
            // Remove the user from the role 
            Roles.RemoveUserFromRole(selectedUserName, roleName);
            // Display a status message 
            ActionStatus.Text = string.Format("El Usuario {0} fue removido del Rol {1}.", selectedUserName, roleName);

        }
    }

    protected void UserList_SelectedIndexChanged(object sender, EventArgs e)
    {
        CheckRolesForSelectedUser(); 
    }
}