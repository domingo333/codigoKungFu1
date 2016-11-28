using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


    public class Datos
    {
        private SqlConnection dbconnection;
        private string Error;
        string conexion;       

        public SqlConnection P_dbconnection
        {
            set
            {
                dbconnection = value;
            }
        }

        public string P_Error
        {
            set
            {
                Error = value;
            }
            get
            {
                return (Error);
            }
        }



        public SqlConnection ConectarBaseAu()
        {
            conexion = ConfigurationManager.ConnectionStrings["AspNetSqlServer"].ConnectionString;
            try
            {
                dbconnection = new SqlConnection(conexion);
            }
            catch (Exception e)
            {
                Error = e.Message;
            }

            return (dbconnection);
        }

        public void DesconectarAu()
        {
            dbconnection.Close();
        }



        public SqlConnection ConectarBase()
        {
            conexion = ConfigurationManager.ConnectionStrings["ConectaAutores"].ConnectionString;
            try
            {
                dbconnection = new SqlConnection(conexion);
            }
            catch (Exception e)
            {
                Error = e.Message;
            }

            return (dbconnection);
        }

            public void Desconectar()
            {
                dbconnection.Close();
            }

        public DataSet ConsultaDataset(string consulta)
        {
            DataSet Ds = new DataSet();
            SqlCommand dbcommnad = new SqlCommand();

            dbcommnad.CommandText = consulta;
            dbcommnad.Connection = dbconnection;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = dbcommnad;

            try
            {
                adapter.Fill(Ds);
            }
            catch (Exception e)
            {
                Error = e.Message;
            }

            dbcommnad.Connection.Close();
            dbcommnad.Dispose();
            adapter.Dispose();

            return (Ds);
        }

        public SqlDataReader ConsultaReader(string consulta)
        {
            SqlDataReader dr = null;

            SqlCommand dbCommand = new SqlCommand();

            dbCommand.CommandText = consulta;
            dbCommand.Connection = dbconnection;

            try
            {
                dbconnection.Open();
                dr = dbCommand.ExecuteReader();

                //dbCommand.Connection.Close(); /* No se debe liberar la conexiòn puesto que el objeto
                //dbCommand.Dispose();          /* Reader trabaja en modo conectado
            }
            catch (Exception e)
            {
                Error = e.Message;
                return (null);
            }

            return dr;
        }

        public int ejecutanonquery(SqlCommand cmd)
        {
            int afectados;
            try
            {

                afectados = cmd.ExecuteNonQuery();
                return (afectados);

            }
            catch (Exception e)
            {
                Error = e.Message;
                return (0);
            }
        }
        public SqlCommand ActualizaCmd(string consulta)
        {
            SqlCommand cmd = new SqlCommand(consulta, dbconnection);
            return (cmd);

        }

        public SqlDataAdapter ActualizaAdapt(string consulta)
        {
            SqlDataAdapter adapt = new SqlDataAdapter(consulta, dbconnection);
            return (adapt);
        }

        public DataRow ExtraeRegistro(SqlDataAdapter adp)
        {

            DataRow fila;

            DataSet ds = new DataSet();

            try
            {
                adp.Fill(ds, "Persona");
                DataTable tabla = ds.Tables["Persona"];
                fila = tabla.Rows[0];
                return (fila);

            }
            catch (Exception e)
            {
                Error = e.Message;
                return (null);

            }
        }

        public SqlCommand Proc_Almacenado()
        {
            SqlCommand cmd = new SqlCommand(conexion, dbconnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Registros"; ;

            return (cmd);
        }

        public SqlDataAdapter ConfiguraAdapterProc_A(SqlCommand cmd)
        {
            SqlDataAdapter adapt = new SqlDataAdapter();
            adapt.SelectCommand = cmd;
            adapt.SelectCommand.Connection = dbconnection;
            return (adapt);
        }

        public DataSet Llenado_DataSet(SqlDataAdapter adapter)
        {
            DataSet ds;

            ds = new DataSet();

            try
            {
                adapter.Fill(ds);
                return (ds);
            }

            catch (Exception e)
            {
                Error = e.Message;
                return (null);
            }

        }
  //------------------------------------------------------------------
        public SqlCommand Proc_AlmacenadoParametro()
        {
            SqlCommand cmd = new SqlCommand(conexion, dbconnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BuscarCorreo"; ;

            return (cmd);
        }

        public SqlCommand Proc_AlmacenadoParametroMaestro()
        {
            SqlCommand cmd = new SqlCommand(conexion, dbconnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BuscarMaestro"; ;

            return (cmd);
        }

        public SqlCommand Proc_AlmacenadoParametroAuto()
        {
            SqlCommand cmd = new SqlCommand(conexion, dbconnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BuscarAu"; ;

            return (cmd);
        }

    }

