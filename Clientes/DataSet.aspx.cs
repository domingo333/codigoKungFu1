using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Text;


public partial class Consultas_DataSet : System.Web.UI.Page
{    

    protected void Page_Load(object sender, EventArgs e)
    {
        string consulta = "select * from Persona";
        DataSet ds = null; ;

        Datos dset = new Datos();

        if ((dset.ConectarBase()) != null)
        {
            ds = dset.ConsultaDataset(consulta);
            if (ds.Tables.Count != 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            else
            {
                string msg = dset.P_Error.ToString();                
                Label1.Text = msg;

            }
        }
        else
        {
            string msg = dset.P_Error.ToString();
            Label1.Text = msg;                        
        } 
    }
}
