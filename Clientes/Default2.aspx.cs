using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Clientes_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
        SqlDataReader Dr;
        string consulta;

        Datos reader = new Datos();
        consulta = "select Nombre  from TipoCliente";

        if ((reader.ConectarBase()) != null)
        {
            Dr = reader.ConsultaReader(consulta);

            if (Dr != null)
            {
                try
                {

                    if (Dr.Read() == true)
                    {
                       
                        TextBox1.Text = Dr["Nombre"].ToString();

                    }

                }
                catch (Exception ed)
                {


                }
                finally
                {
                    reader.Desconectar();
                }


            }
            else
            {
                string msg = reader.P_Error.ToString();
                Label1.Text = msg;
            }

        }
        else Label1.Text = "No se pudo establecer comunicación con el servidor";
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
    
    }
}











       /*     if (ds.Tables.Count != 0)
            {

                DropDownList1.DataSource = ds.["Nombre"].ToString;
                DropDownList1.DataBind();
            }
            else
            {
                string msg = dset.P_Error.ToString();                
                Label2.Text = msg;

            }
        }
        else
        {
            string msg = dset.P_Error.ToString();
            Label2.Text = msg;                        
        } 
    }

    
}
        */