using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        public int LancheId { get; set; }

        [Required]
        [Display(Name = "Nome do Lanche")]
        public string Nome { get; set; }

        [Required(ErrorMessage="sdfsdfsdfsdf")]
        [Display(Name = "Nome do Lanche")]
        [MinLength(20, ErrorMessage = "sdfsdfsdfsdf")]
        [MaxLength(200)]
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }  
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }   
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; } 

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }    
    }
}
