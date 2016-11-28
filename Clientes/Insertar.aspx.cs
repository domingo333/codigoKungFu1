using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Clientes_Insertar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        SqlCommand MyCommand;
        SqlConnection cnn;

        Datos agrega = new Datos();

        if ((cnn = agrega.ConectarBase()) != null)
        {

            MyCommand = agrega.ActualizaCmd("Insert into Persona (Nombre, ApPaterno,ApMaterno,FechaNac,Documento,Direccion,Telefono,Sexo,Email,contrasena ) values ( @Nombre, @ApPaterno, @ApMaterno, @FechaNac, @Documento,@Direccion,@Telefono,@Sexo,@Email,@contrasena)");


            MyCommand.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 50));
            MyCommand.Parameters["@Nombre"].Value = TextBox2.Text;

            MyCommand.Parameters.Add(new SqlParameter("@ApPaterno", SqlDbType.NVarChar, 50));
            MyCommand.Parameters["@ApPaterno"].Value = TextBox3.Text;

            MyCommand.Parameters.Add(new SqlParameter("@ApMaterno", SqlDbType.NVarChar, 50));
            MyCommand.Parameters["@ApMaterno"].Value = (TextBox4.Text);

            MyCommand.Parameters.Add(new SqlParameter("@FechaNac", SqlDbType.Date));
            MyCommand.Parameters["@FechaNac"].Value = Calendar1.SelectedDate;

            MyCommand.Parameters.Add(new SqlParameter("@Documento", SqlDbType.NChar, 20));
            MyCommand.Parameters["@Documento"].Value = DropDownList1.Text;

            MyCommand.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.NChar, 20));
            MyCommand.Parameters["@Direccion"].Value = TextBox5.Text;

            MyCommand.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.NChar, 20));
            MyCommand.Parameters["@Telefono"].Value = TextBox6.Text;

            MyCommand.Parameters.Add(new SqlParameter("@Sexo", SqlDbType.NChar, 20));
            MyCommand.Parameters["@Sexo"].Value = DropDownList2.Text;

            MyCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.NChar, 20));
            MyCommand.Parameters["@Email"].Value = TextBox7.Text;

            MyCommand.Parameters.Add(new SqlParameter("@contrasena", SqlDbType.NChar, 20));
            MyCommand.Parameters["@contrasena"].Value = TextBox8.Text;

           
            try
            {
                cnn.Open();
                if ((agrega.ejecutanonquery(MyCommand)) != 0)
                    Label10.Text = "Registro agregado satisfactoriamente";
                else
                {
                    string msg = agrega.P_Error.ToString();
                    Label10.Text = msg;
                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                Label10.Text = msg;
            }

            MyCommand.Connection.Close();
            agrega.Desconectar();
        }
        else Label10.Text = "No se pudo establecer comunicación con el servidor";
    }
}