using pruebaCinestar.Models;
using pruebaCinestar.Controllers.bd;
using System.Data;
namespace pruebaCinestar.Controllers.dao
{
    public class daoPelicula
    {
        clsdb db = new clsdb();
        public List<Pelicula> getPeliculas(string id)
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            DataTable dt = db.Sentencia("sp_getPeliculas", id);
            foreach (DataRow dr in dt.Rows)
            {
                Pelicula pelicula = new Pelicula
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Titulo = dr["Titulo"].ToString(),
                    Link = dr["Link"].ToString(),
                    Sinopsis = dr["Sinopsis"].ToString()
                };
                peliculas.Add(pelicula);
            }

            return peliculas;
        }

        public Pelicula getPelicula(string id)
        {
            DataTable dt = db.Sentencia("sp_getPelicula", id);
            Pelicula pelicula = new Pelicula
            {
                Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                Titulo = dt.Rows[0]["Titulo"].ToString(),
                FechaEstreno = dt.Rows[0]["FechaEstreno"].ToString(),
                Director = dt.Rows[0]["Director"].ToString(),
                Generos = dt.Rows[0]["Generos"].ToString(),
                idClasificacion = Convert.ToInt32(dt.Rows[0]["idClasificacion"]),
                idEstado = Convert.ToInt32(dt.Rows[0]["idEstado"]),
                Duracion = dt.Rows[0]["Duracion"].ToString(),
                Link = dt.Rows[0]["Link"].ToString(),
                Reparto = dt.Rows[0]["Reparto"].ToString(),
                Sinopsis = dt.Rows[0]["Sinopsis"].ToString(),
                Geneross = dt.Rows[0]["Geneross"].ToString()
            };
            return pelicula;

        }
    }
}
