using pruebaCinestar.Controllers.bd;
using pruebaCinestar.Controllers.dto;
using pruebaCinestar.Models;
using System.Data;
namespace pruebaCinestar.Controllers.dao
{
    public class daoCine
    {
        clsdb db = new clsdb();
        public List<Cine> getCines()
        {
            List<Cine> cines = new List<Cine>();
            DataTable dt = db.Sentencia("sp_getCines");
            foreach (DataRow row in dt.Rows)
            {
                Cine cine = new Cine(
                    Convert.ToInt32(row["Id"]),
                    row["RazonSocial"].ToString(),
                    Convert.ToInt32(row["Salas"]),
                    Convert.ToInt32(row["idDistrito"]),
                    row["Direccion"].ToString(),
                    row["Telefonos"].ToString(),
                    row["Detalle"].ToString()
                );
                cines.Add(cine);
            }
            return cines;
        }

        public Cine getCine(string id)
        {
            DataTable dt = db.Sentencia($"sp_getCine", id);

            Cine cine = new Cine(
                Convert.ToInt32(dt.Rows[0]["Id"]),
                dt.Rows[0]["RazonSocial"].ToString(),
                Convert.ToInt32(dt.Rows[0]["Salas"]),
                Convert.ToInt32(dt.Rows[0]["idDistrito"]),
                dt.Rows[0]["Direccion"].ToString(),
                dt.Rows[0]["Telefonos"].ToString(),
                dt.Rows[0]["Detalle"].ToString()
            );

            return cine;
        }

        public List<TarifasDTO> getCineTarifas(string id)
        {
            List<TarifasDTO> tarifas = new List<TarifasDTO>();
            DataTable dt = db.Sentencia("sp_getCineTarifas", id);
            foreach (DataRow row in dt.Rows)
            {
                TarifasDTO tarifa = new TarifasDTO
                {
                    DiasSemana = row["DiasSemana"].ToString(),
                    Precio = row["Precio"].ToString()
                };
                tarifas.Add(tarifa);
            }

            return tarifas;
        }

        public List<PeliculasDTO> getCinePeliculas(string id)
        {
            List<PeliculasDTO> peliculas = new List<PeliculasDTO>();
            DataTable dt = db.Sentencia("sp_getCinePeliculas", id);
            foreach (DataRow row in dt.Rows)
            {
                PeliculasDTO pelicula = new PeliculasDTO
                {
                    Titulo = row["Titulo"].ToString(),
                    Horarios = row["Horarios"].ToString()
                };
                peliculas.Add(pelicula);
            }
            return peliculas;
        }

    }

}
