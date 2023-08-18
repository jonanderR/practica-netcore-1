using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60,MinimumLength =3, ErrorMessage = "El título debe tener entre 3-60 caracteres"),Required(ErrorMessage = "Título requerido")]
        public string? Title { get; set; }

        [Display(Name ="Fecha de lanzamiento"), DataType(DataType.Date,ErrorMessage = "Valor inválido"), Required(ErrorMessage = "Fecha requerida")]
        public DateTime RealeseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Formato incorrecto"), Required(ErrorMessage = "Género requerido"), StringLength(30,ErrorMessage = "El texto debe contener máximo 30 caracteres")]
        public string? Genre { get; set; }

        [Range(1, 100,ErrorMessage = "El precio debe estar entre 1 y 100 €"), DataType(DataType.Currency, ErrorMessage = "Formato incorrecto"), Column(TypeName = "decimal(18, 2)"), Required(ErrorMessage = "Precio requerido")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$",ErrorMessage = "Formato incorrecto"), StringLength(5, ErrorMessage = "El texto debe contener máximo 5 caracteres"), Required(ErrorMessage = "Rating requerido")]
        public string? Rating { get; set; }
    }
}
