using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadLivro.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título do livro é obrigatório.")]
        [StringLength(100, ErrorMessage = "O título deve ter no máximo 100 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O nome do autor do livro é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do autor deve ter no máximo 100 caracteres.")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "O preço do livro é obrigatório.")]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "A categoria do livro é obrigatória.")]
        [StringLength(100, ErrorMessage = "A categoria deve ter no máximo 100 caracteres.")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "O ano de publicação é obrigatório.")]
        [Range(1000, 2100, ErrorMessage = "Digite um ano de publicação válido.")]
        public int AnoPublicacao { get; set; }
    }
}
