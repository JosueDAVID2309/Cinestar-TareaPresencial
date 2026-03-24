namespace pruebaCinestar.Models
{
    public class Cine
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public int Salas { get; set; }
        public int idDistrito { get; set; }
        public string Direccion { get; set; }
        public string Telefonos { get; set; }
        public string Detalle { get; set; }

        public Cine(int Id,
            string RazonSocial,
            int Salas,
            int idDistrito,
            string Direccion,
            string Telefono,
            string Detalle) {
            
            this.Id = Id;
            this.RazonSocial = RazonSocial;
            this.Salas = Salas;
            this.idDistrito = idDistrito;
            this.Direccion = Direccion;
            this.Telefonos = Telefono;
            this.Detalle = Detalle;
        }
    }
}
