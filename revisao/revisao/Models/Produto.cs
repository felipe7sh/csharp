using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace revisao.Models
{
    public class Produto
    {


        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatorio")]
        public string Nome { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Qtd nao pode ser negativa")]
        public int Qtde { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Valor { get; set; }
        public DateTime Validade { get; set; }

    }
}
