namespace Core.Entities.Security
{
    public class Modulos
    {
        public Modulos(string nombre, bool actvio)
        {
            Nombre = nombre;
            Activo = actvio;
        }
        
        public bool Activo { get; set; }
        public string Nombre { get; set; }

    }
}
