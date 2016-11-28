using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Clientes_Busqueda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Label2.Text = User.Identity.Name;
        SqlCommand cmd;
        SqlConnection cnn;
        SqlDataAdapter adapter2;
        DataSet Ds;
        SqlDataReader dr;

        Datos Proc_A = new Datos();

        if ((cnn = Proc_A.ConectarBaseAu()) != null)
        {
            cmd = Proc_A.Proc_AlmacenadoParametroAuto();

            SqlParameter para1 = new SqlParameter("@Nombre", SqlDbType.NVarChar);
            para1.Size = 20;
            para1.Value = Label2.Text; //valor del parámetro
            para1.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para1);



            adapter2 = Proc_A.ConfiguraAdapterProc_A(cmd);

            cnn.Open();
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {


                    TextBox3.Text = dr["Email"].ToString();

                }

            }
            catch (Exception ed)
            {


            }
            finally
            {
                cnn.Close();
            }


        }


        else Label1.Text = "No se pudo establecer comunicación con el servidor";

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        SqlCommand cmd;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        DataSet Ds;
        SqlDataReader dr;

        Datos Proc_A = new Datos();

        if ((cnn = Proc_A.ConectarBase()) != null)
        {
            cmd = Proc_A.Proc_AlmacenadoParametro();

            SqlParameter para1 = new SqlParameter("@Nombre", SqlDbType.NVarChar);
            para1.Size = 20;
            para1.Value = TextBox1.Text; //valor del parámetro
            para1.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para1);


            
            adapter = Proc_A.ConfiguraAdapterProc_A(cmd);
           
   

            if ((Ds = Proc_A.Llenado_DataSet(adapter)) != null)
            {
            

                GridView1.DataSource = Ds.Tables[0];
                GridView1.DataBind();
                cmd.Connection.Close();
                cmd.Dispose();
                adapter.Dispose();
            }

            else
            {
                string msg = Proc_A.P_Error.ToString();
                Label1.Text = msg;
            }
           
             cnn.Open();
                try{
                   dr = cmd.ExecuteReader();
                    if(dr.Read()==true){

                          
                          TextBox5.Text = dr["Email"].ToString();
                          Panel1.GroupingText = "Gracias por Ser parte de nuestra educacion " + "usuario =" + dr["Nombre"] + " contraseña=" + dr["contrasena"];
                   
                    }

                }  
            catch(Exception ed)
                {

                    string msg = Proc_A.P_Error.ToString();
                    Label1.Text = msg;
            }
                finally
                {
                    cnn.Close();
                }
            
           
        }
        else Label1.Text = "No se pudo establecer comunicación con el servidor";
  }


    protected void Button2_Click(object sender, EventArgs e)
    {
        EnviarCorreo();

    }
    public void EnviarCorreo() {
        string from = TextBox3.Text;
        string pass = TextBox4.Text;
        string to = TextBox5.Text;
        string msn = Panel1.GroupingText;
        new Email().EnviarCorreo(from, pass, to, msn);
    
    }
    
}