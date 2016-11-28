using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Credenciales
/// </summary>
public class Credenciales
{
    string[] UsuarioColeccion = { "web1", "web2", "web3" };
    string[] ContraseñaColeccion = { "web1", "web2", "web3" };
    private string Usuario;
    private string Contraseña;

    public string P_Usuario
    {
        set
        {
            Usuario = value;
        }
        get
        {
            return (Usuario);
        }
    }
    public string P_Contraseña
    {
        set
        {
            Contraseña = value;
        }
        get
        {
            return (Contraseña);
        }
    }

    public bool ValidaUsuario()
    {
        bool valida = false;

        for (int i = 0; i <= UsuarioColeccion.Length - 1; i++)
        {
            bool UserNameIsValid = (string.Compare(Usuario, UsuarioColeccion[i], true) == 0);
            bool PasswordIsValid = (string.Compare(Contraseña, ContraseñaColeccion[i], true) == 0);

            if (UserNameIsValid && PasswordIsValid) valida = true;
        }

        return (valida);
    }
}