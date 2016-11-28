using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;



public partial class Modificacion_Eliminar : System.Web.UI.Page
{    
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd;
        SqlConnection cnn;

        Datos elimina = new Datos();

        if ((cnn = elimina.ConectarBase()) != null)
        {
            cmd = elimina.ActualizaCmd("Delete from autores where id = @Id");

            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.NVarChar, 7));
            cmd.Parameters["@Id"].Value = TextBox1.Text;

            try
            {
                cnn.Open();
                if ((elimina.ejecutanonquery(cmd)) != 0)
                {
                    Label2.Text = "Registro eliminado de la base exitosamente";
                    cmd.Connection.Close();
                    elimina.Desconectar();
                }
                else
                {
                    string msg = elimina.P_Error.ToString();                    
                    Label2.Text = msg;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();                
                Label2.Text = msg;
            }            
        }
        else Label2.Text = "Error al establecer comunicación con el servidor";        
    }
}
