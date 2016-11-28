using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
        Login1.FailureText = "El intento de conexión no fue correcto. Usuario o Contraseña Incorrectos, Inténtelo de nuevo.";
        Login1.RememberMeText = "";
        Login1.PasswordRequiredErrorMessage = "La contraseña es obligatoria.";
        Login1.UserNameRequiredErrorMessage = "El nombre de usuario es obligatorio.";
        

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        
        Credenciales UserPass = new Credenciales();

        UserPass.P_Usuario = Login1.UserName;
        UserPass.P_Contraseña = Login1.Password;

    
    if (Membership.ValidateUser(UserPass.P_Usuario, UserPass.P_Contraseña))
       
     {
                FormsAuthentication.RedirectFromLoginPage(UserPass.P_Usuario, false);
      }

        else // Usuario y Contraseña incorrectos
        {

            // no se hace nada, el control Login mostrará automáticament los errores
        }

    }
}
