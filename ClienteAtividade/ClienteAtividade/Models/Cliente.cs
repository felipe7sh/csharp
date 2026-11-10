using System.ComponentModel.DataAnnotations;

namespace ClienteAtividade.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
        public string Nome { get; set; }

        [StringLength(100, ErrorMessage = "O Email deve ter no máximo 100 caracteres")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [StringLength(20, ErrorMessage = "O Telefone deve ter no máximo 20 caracteres")]
        [Phone(ErrorMessage = "Telefone Invalido")]
        public string Telefone { get; set; }

    }
}
