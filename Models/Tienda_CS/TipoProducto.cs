
using System.ComponentModel.DataAnnotations;

namespace Models.Tienda_CS
{
    // Esta clase representa un tipo de producto en la tienda
    public class TipoProducto
    {
        //CLASE PARA EL MODELO DE TIPO PRODUCTO

        [Key]
        [Display(Name = "#")]
        public int Id { get; set; }     // ID único del tipo de producto


        [Required(ErrorMessage = "El nombre del tipo de producto es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        [Display(Name = "Nombre del tipo de producto")]
        public string Nombre { get; set; }   // Nombre del tipo de producto
    }
}
