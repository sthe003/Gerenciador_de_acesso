using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassEntidades;
using System.Data.Sql;
using System.Configuration;
using System.Data;


namespace BibliotecaDados
{
    public class ClasseDados
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable Dlogin(ClasseEntidade obje)
        {
            SqlCommand cmd = new SqlCommand("sp_logar", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.userform);
            cmd.Parameters.AddWithValue("@senha", obje.passform);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
