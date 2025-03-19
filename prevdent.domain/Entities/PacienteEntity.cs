using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrevDent.Domain.Entities
{
    [Table("tb_paciente")]
    public class PacienteEntity
    {
        [Key]
        public int id_paciente { get; set; }
        public string nome { get; set; } = string.Empty;
        public int idade { get; set; }
        public string email { get; set; } = string.Empty;
    }
}
