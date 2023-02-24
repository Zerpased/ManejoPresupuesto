using System.ComponentModel.DataAnnotations;
using Manejo_Presupuesto.Validaciones;
using Microsoft.AspNetCore.Mvc;

namespace Manejo_Presupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [PrimeraLetraMayuscula]
        [Remote(action: "VerificarExisteTipoCuenta", controller: "TiposCuentas", 
            AdditionalFields = nameof(Id))]
        public string Nombre { get; set; }         
        public int UsuarioId { get; set; } 
        public int Orden { get; set; }
    }
}