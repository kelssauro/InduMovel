using System.ComponentModel.DataAnnotations;

namespace InduMovel.Models
{
    public class Movel
    {
        public int MovelId{get; set;}
        [Required(ErrorMessage = "informe o nome do movel")]
        [Display(Name = "movel")]
        [MinLength(3, ErrorMessage = "movel deve ter no minimo {1} caracteres")]
        [MaxLength(30, ErrorMessage = "movel dever ter no maximo {1} caracteres")]
        public string Nome{get; set;}


        [Required(ErrorMessage = "informe o nome da descricao")]
        [Display(Name = "descricao")]
        [MinLength(3, ErrorMessage = "descricao deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "descricao dever ter no maximo {1} caracteres")]
        public string Descricao{get;set;}


        [Display(Name = "cor")]
        [MaxLength(20, ErrorMessage = "cor deve ter no maximo {1} caracteres")]
        public string Cor{get;set;}


        [Display(Name = "caminho da imagem")]
        public string ImagemUrl{get;set;}


        [Display(Name = "caminho da imagem pequena")]
        public string ImagemPequena{get;set;}


        [Required(ErrorMessage = "informe o valor")]
        [Display(Name = "valor")]
        [Range(1,99999.99, ErrorMessage = "o valor deve estar entre {1} e {2}")]
        public double Valor{get;set;}


        [Display(Name = "em linha de producao")]
        public bool EmProducao{get;set;}


        [Display(Name = "ativo")]
        public bool Ativo{get;set;}


        [Required(ErrorMessage ="informe a categoria")]
        public int CategoriaId{get;set;}
        public virtual Categoria Categoria  {get;set;}
    }
}