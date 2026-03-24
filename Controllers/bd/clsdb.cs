using System.Data;
using System.Data.SqlClient;
namespace pruebaCinestar.Controllers.bd
{
    public class clsdb
    {
        SqlConnection conexion = new SqlConnection("Data Source=.;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False; Initial Catalog = Cinestar;");


        public DataTable Sentencia(string procedure, string param="")
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conexion;
            cmd.CommandText = procedure+" "+param ;
            cmd.Parameters.Clear();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            da.Dispose();
            cmd.Dispose();

            return dt;
        }

    }
}
