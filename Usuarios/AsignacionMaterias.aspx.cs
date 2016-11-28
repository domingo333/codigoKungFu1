using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Usuarios_AsignacionMaterias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string consulta = "select * from Maestro";
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        DataSet Ds;
        SqlDataReader dr;

        Datos Proc_A = new Datos();

        if ((cnn = Proc_A.ConectarBase()) != null)
        {
            cmd = Proc_A.Proc_AlmacenadoParametroMaestro();

            SqlParameter para1 = new SqlParameter("@Nombre", SqlDbType.NVarChar);
            para1.Size = 20;
            para1.Value = TextBox1.Text; //valor del parámetro
            para1.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para1);

            

            adapter = Proc_A.ConfiguraAdapterProc_A(cmd);
           
   
             cnn.Open();
                try{
                   dr = cmd.ExecuteReader();
                    if(dr.Read()==true){

                          
                          TextBox2.Text = dr["Id"].ToString();
                   
                    }

                }  
            catch(Exception ed)
                {

                    string msg = Proc_A.P_Error.ToString();
                    Label2.Text = msg;
            }
                finally
                {
                    cnn.Close();
                }
            
           
        }
        else Label2.Text = "No se pudo establecer comunicación con el servidor";
  }




    protected void Button2_Click(object sender, EventArgs e)
    {
        
        SqlCommand MyCommand;
        SqlConnection cnn;

        Datos agrega = new Datos();

        if ((cnn = agrega.ConectarBase()) != null)
        {

            MyCommand = agrega.ActualizaCmd("Insert into Materias (Nombre,id_maestro) values (@Nombre, @id_maestro)");


            MyCommand.Parameters.Add(new SqlParameter("@id_maestro", SqlDbType.NVarChar, 50));
            MyCommand.Parameters["@id_maestro"].Value = TextBox2.Text;

            MyCommand.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 50));
            MyCommand.Parameters["@Nombre"].Value = DropDownList1.Text;

 

           
            try
            {
                cnn.Open();
                if ((agrega.ejecutanonquery(MyCommand)) != 0)
                    Label5.Text = "Registro agregado satisfactoriamente";
                else
                {
                    string msg = agrega.P_Error.ToString();
                    Label5.Text = msg;
                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                Label5.Text = msg;
            }

            MyCommand.Connection.Close();
            agrega.Desconectar();
        }
        else Label5.Text = "No se pudo establecer comunicación con el servidor";
    }
 }
