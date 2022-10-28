using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{

    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }



        [StringLength(100, ErrorMessage = "O tamanho máx é de 100 carac.")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máx é de 200 carac.")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }
      

        public List<Lanche> Lanches { get; set; }   
    }
}
