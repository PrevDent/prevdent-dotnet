using System.ComponentModel.DataAnnotations;

namespace PrevDent.Appllication.Dtos
{
    public class PacienteDTO
    {
        [Required(ErrorMessage = $"Campo {nameof(Nome)} é obrigatorio")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "Campo deve ter no minimo 2 caracteres")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = $"Campo {nameof(Idade)} é obrigatorio")]
        [Range(18, int.MaxValue, ErrorMessage = "O a idade deve ser no mínimo de 18 anos e ser um valor inteiro.")]
        public int Idade { get; set; }

        [Required(ErrorMessage = $"Campo {nameof(Email)} é obrigatorio")]
        [EmailAddress(ErrorMessage = "O Email não é valido")]
        public string Email { get; set; } = string.Empty;
    }
}
