
using System.ComponentModel.DataAnnotations;

namespace Models.Tienda_CS
{
    //Esta clase representa un producto en la tienda
    internal class Producto
    {
        //CLASE PARA EL MODELO DE PRODUCTO


        [Key]
        [Display(Name = "#")]
        public int Id { get; set; }     // ID único del producto


        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        [Display(Name = "Nombre del producto")]
        public string Nombre { get; set; }   // Nombre del producto


        [Required(ErrorMessage = "El precio del producto es obligatorio")]
        [Range(0.01, 9999999.99, ErrorMessage = "El precio debe estar entre 0.01 y 9,999,999.99")]
        [Display(Name = "Precio del producto")]
        public decimal Precio { get; set; }  // Precio del producto


        [Required(ErrorMessage = "Seleccionar un tipo de producto es obligatorio")]
        [Display(Name = "Tipo de producto")]
        public int TipoProductoId { get; set; } // ID del tipo de producto al que pertenece


        [Required(ErrorMessage = "Ingresar la cantidad en stock es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
        [Display(Name = "Stock disponible")]
        public int Stock { get; set; }  // Cantidad disponible del producto en stock


    }
}
