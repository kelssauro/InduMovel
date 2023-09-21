using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace InduMovel.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId{get; set;}
        [Required(ErrorMessage = "informe o nome da categoria")]
        [Display(Name = "categoria")]
        [MinLength(3, ErrorMessage = "categoria deve ter no minimo {1} caracteres")]
        [MaxLength(20, ErrorMessage = "categoria dever ter no maximo {1} caracteres")]
        public string Nome{get; set;}
        public List<Movel> Moveis{get;set;}
    }
}