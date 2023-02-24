namespace Manejo_Presupuesto.Models
{
    public class ParametrosObtenerTransaccionesPorUsuario
    {
        public int UsuarioId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}